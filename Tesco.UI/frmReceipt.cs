using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.DL.Models;

namespace Tesco.UI
{
	public partial class frmReceipt : Form
	{
		private readonly IItemCustomerManager _itemCustomerManager;
		private readonly IItemManager _itemManager;
		private readonly IOrderManager _orderManager;
		private readonly ITransactionManager _transactionManager;
		private readonly int _transactionId;

		public frmReceipt(int transactionId)
		{
			_itemCustomerManager = new ItemCustomerManager();
			_itemManager = new ItemManager();
			_orderManager = new OrderManager();
			_transactionManager = new TransactionManager();
			_transactionId = transactionId;
			InitializeComponent();
		}

		private void FrmReceipt_Load(object sender, EventArgs e)
		{
			var transaction = _transactionManager.RetrieveDataById<Transaction>(_transactionId);
			var total = 0;

			lblTransactionAmount.Location = new Point(315, 129);
			
			_orderManager.RetrieveAll<Order>()
				.Where(x => x.TransactionId == _transactionId)
				.Select(x => x)
				.ToList()
				.ForEach(x =>
				{
					var itemCustomer = _itemCustomerManager.RetrieveDataById<ItemCustomer>(x.ItemCustomerId);
					var item = _itemManager.RetrieveDataById<Item>(itemCustomer.ItemId);
					
					var transactionDetails = $"{item.Name} @{itemCustomer.Amount / itemCustomer.Quantity} x{itemCustomer.Quantity}{Environment.NewLine}";
					lblTransactionDetails.Text += transactionDetails;

					var transactionAmount = $"{itemCustomer.Amount}{Environment.NewLine}";
					lblTransactionAmount.Text += transactionAmount;

					total += itemCustomer.Amount;
				});

			lblDateTime.Text = transaction.TransactDateTime.ToString(CultureInfo.CurrentCulture);
			lblTotalAmount.Text = total.ToString();
			lblCashAmount.Text = transaction.CashOnHand.ToString();
			lblChange.Text = (int.Parse(lblCashAmount.Text) - int.Parse(lblTotalAmount.Text)).ToString();
		}

		private void FrmReceipt_FormClosing(object sender, FormClosingEventArgs e)
		{
			var welcome = new frmWelcome();
			welcome.Show();
			welcome.Dispose();
		}
	}
}
