using System;
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
		private readonly IItemManager _itemManager;
		private readonly IOrderManager _orderManager;
		private readonly ITransactionManager _transactionManager;
		private readonly int _transactionId;

		public frmReceipt(int transactionId)
		{
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
					var item = _itemManager.RetrieveDataById<Item>((int) x.ItemId);
					
					var transactionDetails = $"{item.Name} @{x.Amount / x.Quantity} x{x.Quantity}{Environment.NewLine}";
					lblTransactionDetails.Text += transactionDetails;

					var transactionAmount = $"{x.Amount}{Environment.NewLine}";
					lblTransactionAmount.Text += transactionAmount;

					total += (int) x.Amount;
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
		}
	}
}
