﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.DL.Models;
using Tesco.UI.Interfaces;
using Tesco.UI.Utilities;

namespace Tesco.UI
{
	public partial class frmCheckout : Form
	{
		private readonly ICustomerManager _customerManager;
		private readonly IItemManager _itemManager;
		private readonly IOrderCustomerManager _orderCustomerManager;
		private readonly IOrderManager _orderManager;
		private readonly ITransactionManager _transactionManager;
		private readonly IEmailValidator _emailValidator;
		private readonly User _user;
		private Customer _customer;
		private int _total = 0;

		public frmCheckout(User user)
		{
			_customerManager = new CustomerManager();
			_itemManager = new ItemManager();
			_orderCustomerManager = new OrderCustomerManager();
			_orderManager = new OrderManager();
			_transactionManager = new TransactionManager();
			_emailValidator = new EmailValidator();
			_user = user;
			_customer = _customerManager.RetrieveDataById<Customer>(_user.CustomerId);
			InitializeComponent();
		}

		private void FrmCheckout_Load(object sender, EventArgs e)
		{
			txtCashOnHand.Focus();
			
			_orderCustomerManager.RetrieveAll<OrderCustomer>()
				.Where(x => x.CustomerId == _user.CustomerId && x.IsCurrentOrder == true && x.IsUnpaid == true)
				.Select(x => x)
				.ToList()
				.ForEach(x =>
				{
					var item = _itemManager.RetrieveDataById<Item>(x.ItemId);

					var row = new ListViewItem(item.Id.ToString());
					row.SubItems.Add(item.Name);
					row.SubItems.Add(item.Price.ToString());
					row.SubItems.Add(x.Quantity.ToString());
					row.SubItems.Add(x.Amount.ToString());

					lvCheckoutItems.Items.Add(row);

					_total += x.Amount;
				});

			lblAmountToPay.Text = _total.ToString();

			txtFullName.Text = _user.FullName;
			txtEmail.Text = _customer.Email;
			txtPhoneNumber.Text = _customer.PhoneNumber;
		}

		private void TxtCashOnHand_TextChanged(object sender, EventArgs e)
		{
			btnPayOrder.Enabled = !string.IsNullOrWhiteSpace(txtFullName.Text)
				&& !string.IsNullOrWhiteSpace(txtEmail.Text) && _emailValidator.CheckEmailIfValid(txtEmail.Text)
				&& !string.IsNullOrWhiteSpace(txtPhoneNumber.Text)
				&& int.Parse(txtCashOnHand.Text) >= _total;
		}

		private void TxtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

		private void TxtCashOnHand_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

		private void TxtFullName_Leave(object sender, EventArgs e)
		{
			_customer = _customerManager.RetrieveDataById<Customer>(_user.CustomerId);

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
			_customer = _customerManager.RetrieveDataById<Customer>(_user.CustomerId);

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
			_customer = _customerManager.RetrieveDataById<Customer>(_user.CustomerId);

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

			_orderCustomerManager.RetrieveAll<OrderCustomer>()
				.Where(x => x.CustomerId == _user.CustomerId && x.IsCurrentOrder == true && x.IsUnpaid == true)
				.Select(x => x)
				.ToList()
				.ForEach(x =>
				{
					var orderCustomer = new OrderCustomer()
					{
						CustomerId = _user.CustomerId,
						ItemId = x.ItemId,
						Quantity = x.Quantity,
						Amount = x.Amount,
						IsCurrentOrder = false,
						IsUnpaid = false
					};

					var order = new Order()
					{
						TransactionId = _transactionManager.Add(transaction),
						OrderCustomerId = _orderCustomerManager.Add(orderCustomer)
					};

					_orderManager.Add(order);
				});

			var frmReceipt = new frmReceipt(transaction.Id);
			this.Hide();
			frmReceipt.Show();
			frmReceipt.Dispose();
		}

		private void FrmCheckout_FormClosing(object sender, FormClosingEventArgs e)
		{
			lvCheckoutItems.Items.Cast<ListViewItem>().ToList()
				.ForEach(x =>
				{
					var orderCustomer = _orderCustomerManager.RetrieveDataByWhereCondition<OrderCustomer>(new OrderCustomer()
					{
						CustomerId = _user.CustomerId,
						ItemId = int.Parse(x.SubItems[0].Text),
						Quantity = int.Parse(x.SubItems[2].Text),
						Amount = int.Parse(x.SubItems[3].Text),
						IsCurrentOrder = true,
						IsUnpaid = true
					});

					orderCustomer.IsCurrentOrder = false;

					_orderCustomerManager.Update(orderCustomer);
				});

			var welcome = new frmWelcome();
			welcome.Show();
			welcome.Dispose();
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
								   "Do you want to update dat?",
								   MessageBoxButtons.YesNo,
								   MessageBoxIcon.Question) == DialogResult.Yes;
		}
	}
}
