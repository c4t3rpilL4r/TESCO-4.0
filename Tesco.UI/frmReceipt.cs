using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.BL.Models;
using _resource = Tesco.UI.Resources.Strings.en_US.Resources;

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
				.ToList()
				.ForEach(x =>
				{
					var item = _itemManager.RetrieveDataById<Item>((int) x.ItemId);
					
					lblTransactionDetails.Text += string.Format(_resource.TransactionDetails,
						item.Name,
						x.Amount / x.Quantity,
						x.Quantity);

					lblTransactionAmount.Text += x.Amount;

					total += (int) x.Amount;
				});

			lblDateTime.Text = transaction.TransactDateTime.ToString(CultureInfo.CurrentCulture);
			lblTotalAmount.Text = total.ToString();
			lblCashAmount.Text = transaction.CashOnHand.ToString();
			lblChangeText.Text = (int.Parse(lblCashAmount.Text) - int.Parse(lblTotalAmount.Text)).ToString();
		}

		private void FrmReceipt_FormClosing(object sender, FormClosingEventArgs e)
		{
			var welcome = new frmWelcome();
			welcome.Show();
		}
	}
}
