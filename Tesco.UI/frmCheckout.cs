using System;
using System.Linq;
using System.Windows.Forms;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.DL.Models;
using Tesco.UI.Helpers;
using Tesco.UI.Interfaces;

namespace Tesco.UI
{
	public partial class frmCheckout : Form
	{
		private readonly ICustomerManager _customerManager;
		private readonly IItemManager _itemManager;
		private readonly IOrderManager _orderManager;
		private readonly ITransactionManager _transactionManager;
		private readonly IEmailValidationHelper _emailValidationHelper;
		private readonly IOrderItemStateHelper _orderItemStateHelper;
		private readonly User _user;
		private readonly Customer _customer;
		private int _total = 0;

		public frmCheckout(User user)
		{
			_customerManager = new CustomerManager();
			_itemManager = new ItemManager();
			_orderManager = new OrderManager();
			_transactionManager = new TransactionManager();
			_emailValidationHelper = new EmailValidationHelper();
			_orderItemStateHelper = new OrderItemStateHelper();
			_customer = _customerManager.RetrieveDataById<Customer>((int) user.CustomerId);
			_user = user;
			InitializeComponent();
		}

		private void FrmCheckout_Load(object sender, EventArgs e)
		{
			_orderManager.RetrieveAll<Order>()
				.Where(x => x.CustomerId == _user.CustomerId
							&& x.IsCurrentOrder == true
							&& x.IsUnpaid == true)
				.Select(x => x)
				.ToList()
				.ForEach(x =>
				{
					var item = _itemManager.RetrieveDataById<Item>((int) x.ItemId);

					var row = new ListViewItem(item.Id.ToString());
					row.SubItems.Add(item.Name);
					row.SubItems.Add(item.Price.ToString());
					row.SubItems.Add(x.Quantity.ToString());
					row.SubItems.Add(x.Amount.ToString());

					lvCheckoutItems.Items.Add(row);

					_total += (int) x.Amount;
				});

			lblAmountToPay.Text = _total.ToString();

			txtFullName.Text = _user.FullName;
			txtEmail.Text = _customer.Email;
			txtPhoneNumber.Text = _customer.PhoneNumber;
			
			txtCashOnHand.Focus();
		}

		private void TxtCashOnHand_TextChanged(object sender, EventArgs e)
		{
			btnPayOrder.Enabled = !string.IsNullOrWhiteSpace(txtFullName.Text)
				&& !string.IsNullOrWhiteSpace(txtEmail.Text) && _emailValidationHelper.CheckEmailIfValid(txtEmail.Text)
				&& !string.IsNullOrWhiteSpace(txtPhoneNumber.Text)
				&& int.Parse(txtCashOnHand.Text) >= _total;
		}

		private void TxtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

		private void TxtCashOnHand_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

		private void TxtFullName_Leave(object sender, EventArgs e)
		{
			if (_user.FullName.SequenceEqual(txtFullName.Text)) return;
			
			if (CheckIfDataIsNew())
			{
				_customer.FullName = txtFullName.Text;

				MessageBox.Show(_customerManager.Update(_customer) != 0 ? "Update successful." : "Update failed.");
			}
			else
			{
				txtFullName.Text = _customer.FullName;
			}
		}

		private void TxtEmail_Leave(object sender, EventArgs e)
		{
			if (_customer.Email.SequenceEqual(txtEmail.Text)) return;
			
			if (CheckIfDataIsNew())
			{
				_customer.Email = txtEmail.Text;

				MessageBox.Show(_customerManager.Update(_customer) != 0 ? "Update successful." : "Update failed.");
			}
			else
			{
				txtEmail.Text = _customer.Email;
			}
		}

		private void TxtPhoneNumber_Leave(object sender, EventArgs e)
		{
			if (_customer.PhoneNumber.SequenceEqual(txtPhoneNumber.Text)) return;
			
			if (CheckIfDataIsNew())
			{
				_customer.PhoneNumber = txtPhoneNumber.Text;

				MessageBox.Show(_customerManager.Update(_customer) != 0 ? "Update successful." : "Update failed.");
			}
			else
			{
				txtPhoneNumber.Text = _customer.PhoneNumber;
			}
		}

		private void BtnPayOrder_Click(object sender, EventArgs e)
		{
			var transaction = new Transaction()
			{
				CustomerId = _user.CustomerId,
				CashOnHand = int.Parse(txtCashOnHand.Text),
				TransactDateTime = DateTime.Now
			};

			var transactionId = _transactionManager.Add(transaction);

			_orderManager.RetrieveAll<Order>()
				.Where(x => x.CustomerId == _user.CustomerId
							&& x.IsCurrentOrder == true
							&& x.IsUnpaid == true)
				.ToList()
				.ForEach(x =>
				{
					_orderManager.Add(new Order()
					{
						TransactionId = transactionId,
						CustomerId = _user.CustomerId,
						ItemId = x.ItemId,
						Quantity = x.Quantity,
						Amount = x.Amount,
						IsCurrentOrder = false,
						IsUnpaid = false
					});
				});

			var frmReceipt = new frmReceipt(transactionId);
			this.Hide();
			frmReceipt.Show();
		}

		private void FrmCheckout_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to close the window?",
					"Close Window?",
					MessageBoxButtons.OKCancel,
					MessageBoxIcon.Question) == DialogResult.OK)
			{

				MessageBox.Show("You are signed off.");

				lvCheckoutItems.Items.Cast<ListViewItem>()
					.ToList()
					.ForEach(x =>
					{
						_orderItemStateHelper.ChangeOrderItemStatusToUnfinished(new Order()
						{
							CustomerId = _user.CustomerId,
							ItemId = int.Parse(x.SubItems[0].Text),
							Quantity = int.Parse(x.SubItems[3].Text),
							Amount = int.Parse(x.SubItems[4].Text)
						});
					});

				var welcome = new frmWelcome();
				welcome.Show();
			}
			else
			{
				e.Cancel = true;
			}
		}
		
		

		// <--------------------------------------------------     METHODS     -------------------------------------------------->

		private bool CheckIfDataIsNew()
		{
			return MessageBox.Show($"Do you want to update your data from:" +
								   $"FullName:\t{_user.FullName}\n" +
								   $"Email:\t\t{_customer.Email}\n" +
								   $"PhoneNumber:\t{_customer.PhoneNumber}\n\ninto:\n" +
								   $"FullName:\t{txtFullName.Text}\n" +
								   $"Email:\t\t{txtEmail.Text}\n" +
								   $"PhoneNumber:\t{txtPhoneNumber.Text}?",
								   "Do you want to update?",
								   MessageBoxButtons.YesNo,
								   MessageBoxIcon.Question) == DialogResult.Yes;
		}
	}
}
