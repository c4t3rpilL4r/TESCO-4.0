using System;
using System.Linq;
using System.Windows.Forms;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.BL.Models;
using Tesco.UI.Helpers;
using Tesco.UI.Interfaces;
using _resource = Tesco.UI.Resources.Strings.en_US.Resources;


namespace Tesco.UI
{
	public partial class frmCheckout : Form
	{
		private readonly ICustomerManager _customerManager;
		private readonly IItemManager _itemManager;
		private readonly IOrderManager _orderManager;
		private readonly ITransactionManager _transactionManager;
		private readonly ICloseWindowHelper _closeWindowHelper;
		private readonly IEmailValidationHelper _emailValidationHelper;
		private readonly User _user;
		private readonly Customer _customer;
		private int _total = 0;

		public frmCheckout(User user)
		{
			_customerManager = new CustomerManager();
			_itemManager = new ItemManager();
			_orderManager = new OrderManager();
			_transactionManager = new TransactionManager();
			_closeWindowHelper = new CloseWindowHelper();
			_emailValidationHelper = new EmailValidationHelper();
			_customer = _customerManager.RetrieveDataById<Customer>((int) user.CustomerId);
			_user = user;
			InitializeComponent();
		}

		private void FrmCheckout_Load(object sender, EventArgs e)
		{
			_orderManager.RetrieveAll<Order>()
				.Where(x => x.CustomerId == _user.CustomerId
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

				MessageBox.Show(_customerManager.Update(_customer) != 0
					? _resource.UpdateSuccessful
					: _resource.UpdateFailed);
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

				MessageBox.Show(_customerManager.Update(_customer) != 0
					? _resource.UpdateSuccessful
					: _resource.UpdateFailed);
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

				MessageBox.Show(_customerManager.Update(_customer) != 0
					? _resource.UpdateSuccessful
					: _resource.UpdateFailed);
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
				CashOnHand = int.Parse(txtCashOnHand.Text),
				TransactDateTime = DateTime.Now
			};

			var transactionId = _transactionManager.Add(transaction);

			_orderManager.RetrieveAll<Order>()
				.Where(x => x.CustomerId == _user.CustomerId
							&& x.IsUnpaid == true)
				.ToList()
				.ForEach(x =>
				{
					x.TransactionId = transactionId;
					x.IsUnpaid = false;

					_orderManager.Update(x);
				});

			var frmReceipt = new frmReceipt(transactionId);
			this.Hide();
			frmReceipt.Show();
		}

		private void FrmCheckout_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = !_closeWindowHelper.NotifyUserForCloseWindow();


		// <--------------------------------------------------     METHODS     -------------------------------------------------->

		private bool CheckIfDataIsNew()
		{
			return MessageBox.Show(string.Format(_resource.CustomerUpdateDataNotification,
					_user.FullName,
					_customer.Email,
					_customer.PhoneNumber,
					txtFullName.Text,
					txtEmail.Text,
					txtPhoneNumber.Text),
				_resource.UpdateDataTitle,
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question) == DialogResult.Yes;
		}
	}
}
