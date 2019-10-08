using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.DL.Models;

namespace Tesco.UI
{
	public partial class frmUnfinishedTransaction : Form
	{
		private readonly IItemCustomerManager _itemCustomerManager;
		private readonly IItemManager _itemManager;
		private readonly IOrderCustomerManager _orderCustomerManager;
		private readonly IOrderManager _orderManager;
		private readonly List<OrderCustomer> _currentOrderCustomerList;
		private readonly List<OrderCustomer> _unfinishedOrderCustomerList;
		private readonly User _user;
		private int _lastSelectedItemInCurrentListView = 0;
		private int _lastSelectedItemInUnfinishedListView = 0;

		public frmUnfinishedTransaction(User user)
		{
			_itemCustomerManager = new ItemCustomerManager();
			_itemManager = new ItemManager();
			_orderCustomerManager = new OrderCustomerManager();
			_orderManager = new OrderManager();
			_currentOrderCustomerList = new List<OrderCustomer>();
			_unfinishedOrderCustomerList = new List<OrderCustomer>();
			_user = user;
			InitializeComponent();
		}

		private void frmUnfinishedTransaction_Load(object sender, EventArgs e) => PopulateListViewsWithData();

		private void LvCurrentOrder_Leave(object sender, EventArgs e)
		{
			GetSelectedIndexOfCurrentOrderListView();
			KeepLastSelectedItemFocusInCurrentOrderListView();
		}

		private void LvUnfinishedOrder_Leave(object sender, EventArgs e)
		{
			GetSelectedIndexOfUnfinishedOrderListView();
			KeepLastSelectedItemFocusInUnfinishedOrderListView();
		}
		
		private void lvCurrentOrder_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnCheckout.Enabled = lvCurrentOrder.Items.Count > 0;
			btnMoveToUnfinishedTransaction.Enabled = lvCurrentOrder.Items.Count > 0;
		}
		
		private void lvUnfinishedOrder_SelectedIndexChanged(object sender, EventArgs e) => btnMoveToCurrentOrder.Enabled = lvUnfinishedOrder.Items.Count > 0;

		private void btnMoveToUnfinishedTransaction_Click(object sender, EventArgs e)
		{
			if (lvCurrentOrder.SelectedItems.Count <= 0) return;
			
			if (int.Parse(lvCurrentOrder.SelectedItems[0].SubItems[2].Text) > 0)
			{
				var amount = int.Parse(lvCurrentOrder.SelectedItems[0].SubItems[3].Text) / int.Parse(lvCurrentOrder.SelectedItems[0].SubItems[2].Text);

				var currentOrder = _orderCustomerManager.RetrieveDataByWhereCondition(new OrderCustomer()
				{
					CustomerId = _user.CustomerId,
					ItemId = int.Parse(lvCurrentOrder.SelectedItems[0].SubItems[0].Text),
					IsCurrentOrder = true,
					IsUnpaid = true
				});

				currentOrder.Quantity -= 1;
				currentOrder.Amount -= amount;

				_orderCustomerManager.Update(currentOrder);

				if (currentOrder.Quantity == 0)
				{
					lvCurrentOrder.SelectedItems[0].Remove();
				}

				if (lvUnfinishedOrder.Items.Cast<ListViewItem>()
					.Any(x => int.Parse(x.SubItems[0].Text) == int.Parse(lvCurrentOrder.SelectedItems[0].SubItems[0].Text)))
				{
					var unfinishedOrder = _orderCustomerManager.RetrieveDataByWhereCondition(new OrderCustomer()
					{
						CustomerId = _user.CustomerId,
						ItemId = int.Parse(lvCurrentOrder.SelectedItems[0].SubItems[0].Text),
						IsCurrentOrder = false,
						IsUnpaid = true
					});

					unfinishedOrder.Quantity += 1;
					unfinishedOrder.Amount += amount;

					_orderCustomerManager.Update(unfinishedOrder);

					PopulateListViewsWithData();
				}
				else
				{
					_orderCustomerManager.Add(new OrderCustomer()
					{
						CustomerId = _user.CustomerId,
						ItemId = int.Parse(lvCurrentOrder.SelectedItems[0].SubItems[0].Text),
						Quantity = 1,
						Amount = amount,
						IsCurrentOrder = false,
						IsUnpaid = true
					});
				}

				//GetSelectedIndexOfCurrentOrderListView();
				PopulateListViewsWithData();
				KeepLastSelectedItemFocusInCurrentOrderListView();
			}
			else
			{
				lvCurrentOrder.SelectedItems[0].Remove();
			}
		}

		private void BtnMoveToCurrentOrder_Click(object sender, EventArgs e)
		{
			if (lvUnfinishedOrder.SelectedItems.Count > 0)
			{
				if (int.Parse(lvUnfinishedOrder.SelectedItems[0].SubItems[2].Text) > 0)
				{
					var amount = int.Parse(lvUnfinishedOrder.SelectedItems[0].SubItems[3].Text) / int.Parse(lvUnfinishedOrder.SelectedItems[0].SubItems[2].Text);

					var unfinishedOrder = _orderCustomerManager.RetrieveDataByWhereCondition(new OrderCustomer()
					{
						CustomerId = _user.CustomerId,
						ItemId = int.Parse(lvUnfinishedOrder.SelectedItems[0].SubItems[0].Text),
						IsCurrentOrder = false,
						IsUnpaid = true
					});

					unfinishedOrder.Quantity -= 1;
					unfinishedOrder.Amount -= amount;

					_orderCustomerManager.Update(unfinishedOrder);

					if (unfinishedOrder.Quantity == 0)
					{
						lvCurrentOrder.SelectedItems[0].Remove();
					}

					if (lvCurrentOrder.Items.Cast<ListViewItem>()
						.ToList()
						.Any(x => int.Parse(x.SubItems[0].Text) == int.Parse(lvUnfinishedOrder.SelectedItems[0].SubItems[0].Text)))
					{
						var currentOrder = _orderCustomerManager.RetrieveDataByWhereCondition(new OrderCustomer()
						{
							CustomerId = _user.CustomerId,
							ItemId = int.Parse(lvUnfinishedOrder.SelectedItems[0].SubItems[0].Text),
							IsCurrentOrder = true,
							IsUnpaid = true
						});

						currentOrder.Quantity += 1;
						currentOrder.Amount += amount;

						_orderCustomerManager.Update(currentOrder);
					}
					else
					{
						_orderCustomerManager.Add(new OrderCustomer()
						{
							CustomerId = _user.CustomerId,
							ItemId = int.Parse(lvUnfinishedOrder.SelectedItems[0].SubItems[0].Text),
							Quantity = 1,
							Amount = amount,
							IsCurrentOrder = true,
							IsUnpaid = true
						});
					}

					//GetSelectedIndexOfUnfinishedOrderListView();
					PopulateListViewsWithData();
					KeepLastSelectedItemFocusInUnfinishedOrderListView();
				}
				else
				{
					lvUnfinishedOrder.SelectedItems[0].Remove();
				}
			}
		}
		
		private void btnCheckout_Click(object sender, EventArgs e)
		{
			var checkout = new frmCheckout(_user);
			this.Hide();
			checkout.Show();
		}
		
		private void btnShopping_Click(object sender, EventArgs e)
		{
			var shopping = new frmShopping(_user);
			this.Hide();
			shopping.Show();
		}

		private void FrmUnfinishedTransaction_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (lvCurrentOrder.Items.Count <= 0) return;

			lvCurrentOrder.Items.Cast<ListViewItem>().ToList().ForEach(x =>
			{
				if (Enumerable.Cast<ListViewItem>(lvUnfinishedOrder.Items).Any(y => int.Parse(y.SubItems[0].Text) == int.Parse(x.SubItems[0].Text)))
				{
					var currentOrder = _orderCustomerManager.RetrieveDataByWhereCondition(new OrderCustomer()
					{
						CustomerId = _user.CustomerId,
						ItemId = int.Parse(x.SubItems[0].Text),
						IsCurrentOrder = true,
						IsUnpaid = true
					});

					var unfinishedOrder = _orderCustomerManager.RetrieveDataByWhereCondition(new OrderCustomer()
					{
						CustomerId = _user.CustomerId,
						ItemId = int.Parse(x.SubItems[0].Text),
						IsCurrentOrder = false,
						IsUnpaid = true
					});

					unfinishedOrder.Quantity += currentOrder.Quantity;
					unfinishedOrder.Amount += currentOrder.Amount;

					currentOrder.IsCurrentOrder = false;
					currentOrder.Quantity = 0;
					currentOrder.Amount = 0;

					_orderCustomerManager.Update(unfinishedOrder);
					_orderCustomerManager.Update(currentOrder);
				}
				else
				{
					_orderCustomerManager.Add(new OrderCustomer()
					{
						CustomerId = _user.CustomerId,
						ItemId = int.Parse(x.SubItems[0].Text),
						Quantity = int.Parse(x.SubItems[2].Text),
						Amount = int.Parse(x.SubItems[3].Text),
						IsCurrentOrder = false,
						IsUnpaid = true
					});
				}
			});

			var welcome = new frmWelcome();
			welcome.Show();
		}


		// <--------------------------------------------------     METHODS     -------------------------------------------------->


		private void PopulateListViewsWithData()
		{
			lvCurrentOrder.Items.Clear();
			lvUnfinishedOrder.Items.Clear();

			Enumerable.Where(_orderCustomerManager.RetrieveAll<OrderCustomer>(), x => x.CustomerId == _user.CustomerId && x.IsUnpaid == true)
				.ToList()
				.ForEach(x =>
				{
					if (x.IsCurrentOrder == true)
					{
						lvCurrentOrder.Items.Add(ConvertToListViewItem(x));

						_currentOrderCustomerList.Add(x);
					}
					else
					{
						if (x.Quantity == 0) return;

						lvUnfinishedOrder.Items.Add(ConvertToListViewItem(x));

						_unfinishedOrderCustomerList.Add(x);
					}
				});
		}
		
		private ListViewItem ConvertToListViewItem(OrderCustomer orderCustomer)
		{
			var row = new ListViewItem(_itemManager.RetrieveDataById<Item>(orderCustomer.ItemId).Id.ToString());
			row.SubItems.Add(_itemManager.RetrieveDataById<Item>(orderCustomer.ItemId).Name);
			row.SubItems.Add(orderCustomer.Quantity.ToString());
			row.SubItems.Add(orderCustomer.Amount.ToString());

			return row;
		}

		private void GetSelectedIndexOfCurrentOrderListView()
		{
			if (lvCurrentOrder.SelectedItems.Count > 0)
			{
				_lastSelectedItemInCurrentListView = int.Parse(lvCurrentOrder.SelectedItems[0].Text);
			}
		}

		private void GetSelectedIndexOfUnfinishedOrderListView()
		{
			if (lvUnfinishedOrder.SelectedItems.Count > 0)
			{
				_lastSelectedItemInUnfinishedListView = int.Parse(lvUnfinishedOrder.SelectedItems[0].Text);
			}
		}

		private void KeepLastSelectedItemFocusInCurrentOrderListView()
		{
			var selectedItem = lvCurrentOrder.Items.Cast<ListViewItem>().FirstOrDefault(x => int.Parse(x.SubItems[0].Text) == _lastSelectedItemInCurrentListView);

			if (selectedItem != null)
			{
				selectedItem.Selected = true;
			}
		}

		private void KeepLastSelectedItemFocusInUnfinishedOrderListView()
		{
			var selectedItem = lvUnfinishedOrder.Items.Cast<ListViewItem>().FirstOrDefault(x => int.Parse(x.SubItems[0].Text) == _lastSelectedItemInUnfinishedListView);

			if (selectedItem != null)
			{
				selectedItem.Selected = true;
			}
		}
	}
}