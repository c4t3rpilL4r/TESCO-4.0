using System;
using System.Linq;
using System.Windows.Forms;
using Tesco.BL.Managers;
using Tesco.BL.Interfaces;
using Tesco.BL.Models;
using Tesco.UI.Helpers;
using Tesco.UI.Interfaces;
using _resource = Tesco.UI.Resources.Resources;


namespace Tesco.UI
{
	public partial class frmShopping : Form
	{
		private readonly IItemManager _itemManager;
		private readonly IOrderManager _orderManager;
		private readonly ICloseWindowHelper _closeWindowHelper;
		private readonly IItemTypeHelper _itemTypeHandler;
		private readonly IListViewItemHelper _listViewItemHelper;
		private readonly IItemSortHelper _itemSortHandler;
		private readonly User _user;
		private int _lastSelectedItemInItemsListView = 0, _lastSelectedItemInCartListView = 0;

		public frmShopping(User user = null)
		{
			_itemManager = new ItemManager();
			_orderManager = new OrderManager();
			_closeWindowHelper = new CloseWindowHelper();
			_itemTypeHandler = new ItemTypeHelper();
			_listViewItemHelper = new ListViewItemHelper();
			_itemSortHandler = new ItemSortHelper();
			_user = user;
			InitializeComponent();
		}

		private void FrmShopping_Load(object sender, EventArgs e)
		{
			btnSignOff.Enabled = _user != null;
			btnSignOff.Visible = _user != null;
			lblUserGreeting.Text = _user != null
				? string.Format(_resource.GreetingUser, _user.FullName)
				: _resource.GreetingGuest;

			if (_user != null)
			{
				DisplayCartItems();
			}

			btnCheckout.Enabled = lvCart.Items.Count > 0;

			DisplayItemsInListView();
			PopulateComboBoxes();
		}

		private void CboSortByNamePrice_SelectedIndexChanged(object sender, EventArgs e) => RunMethodsForCombobox();

		private void CboSortByType_SelectedIndexChanged(object sender, EventArgs e) => RunMethodsForCombobox();

		private void BtnResetSort_Click(object sender, EventArgs e)
		{
			cboSortByType.SelectedItem = null;
			cboSortByNamePrice.SelectedItem = null;

			DisplayItemsInListView();
		}

		private void LvItems_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvItems.SelectedItems.Count <= 0) return;

			DisplayItemDetailsInLabel();

			if (int.Parse(lvItems.SelectedItems[0].SubItems[5].Text) > 0)
			{
				lblQuantity.Text = _resource.QuantityLabelDefaultValue;
			}
			else
			{
				MessageBox.Show(_resource.NotificationOutOfStocks);
			}

			btnAdd.Enabled = int.Parse(lvItems.SelectedItems[0].SubItems[5].Text) > 0;
		}

		private void LvItems_Leave(object sender, EventArgs e)
		{
			GetSelectedIndexOfItemsListView();
			KeepSelectedItemFocusInItemsListView();
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			if (int.Parse(lvItems.SelectedItems[0].SubItems[5].Text) > 1
				&& int.Parse(lblQuantity.Text) < int.Parse(lvItems.SelectedItems[0].SubItems[5].Text))
			{
				lblQuantity.Text = (int.Parse(lblQuantity.Text) + 1).ToString();
				
				lvItems.SelectedItems[0].SubItems[5].Text = (int.Parse(lvItems.SelectedItems[0].SubItems[5].Text) - 1).ToString();
			}

			DisplayItemDetailsInLabel();
		}

		private void LblQuantity_TextChanged(object sender, EventArgs e)
		{
			btnSubtract.Enabled = int.Parse(lblQuantity.Text) > 0;
			btnAddToCart.Enabled = int.Parse(lblQuantity.Text) > 0;
		}

		private void BtnSubtract_Click(object sender, EventArgs e)
		{
			if (int.Parse(lblQuantity.Text) <= 0) return;
			
			lblQuantity.Text = (int.Parse(lblQuantity.Text) - 1).ToString();
			
			lvItems.SelectedItems[0].SubItems[5].Text = (int.Parse(lvItems.SelectedItems[0].SubItems[5].Text) + 1).ToString();

			DisplayItemDetailsInLabel();
		}

		private void BtnAddToCart_Click(object sender, EventArgs e)
		{
			if (lvItems.SelectedItems.Count > 0)
			{
				if (_user != null)
				{
					var item = _itemManager.RetrieveDataById<Item>(int.Parse(lvItems.SelectedItems[0].SubItems[0].Text));

					if (item.Stocks > 0)
					{
						var amount = int.Parse(lvItems.SelectedItems[0].SubItems[4].Text) * int.Parse(lblQuantity.Text);
						
						var cancelledOrder = _orderManager.RetrieveDataByWhereCondition(new Order()
						{
							CustomerId = _user.CustomerId,
							ItemId = item.Id,
							IsCancelled = true
						});
						
						var order = _orderManager.RetrieveDataByWhereCondition(new Order()
						{
							CustomerId = _user.CustomerId,
							ItemId = item.Id,
							IsUnpaid = true,
							IsCancelled = false
						});

						if (cancelledOrder != null)
						{
							cancelledOrder.Quantity += int.Parse(lblQuantity.Text);
							cancelledOrder.Amount += amount;
							cancelledOrder.IsCancelled = false;

							_orderManager.Update(cancelledOrder);
						}
						else if (order != null)
						{
							order.Quantity += int.Parse(lblQuantity.Text);
							order.Amount += amount;

							_orderManager.Update(order);
						}
						else
						{
							_orderManager.Add(new Order()
							{
								CustomerId = _user.CustomerId,
								ItemId = item.Id,
								Quantity = int.Parse(lblQuantity.Text),
								Amount = amount,
								IsUnpaid = true,
								IsCancelled = false
							});
						}

						item.Stocks -= int.Parse(lblQuantity.Text);
						_itemManager.Update(item);
						
						btnAdd.Enabled = item.Stocks > 0;
						btnAddToCart.Enabled = item.Stocks > 0;

						GetSelectedIndexOfItemsListView();
						DisplayItemsInListView();
						DisplayCartItems();
						KeepSelectedItemFocusInItemsListView();
					}
				}
				else
				{
					MessageBox.Show(_resource.NotificationLogin);
				
					var login = new frmRegisterLogin(0, _user);
					this.Hide();
					login.Show();
				}
			}
			else
			{
				MessageBox.Show(_resource.NotificationSelectItem);
			}

			KeepSelectedItemFocusInItemsListView();

			btnCheckout.Enabled = lvCart.Items.Count > 0;
		}

		private void LvCart_SelectedIndexChanged(object sender, EventArgs e) => btnRemoveOrder.Enabled = lvCart.SelectedItems.Count > 0;

		private void BtnRemoveOrder_Click(object sender, EventArgs e)
		{
			if (lvCart.SelectedItems.Count > 0)
			{
				var item = _itemManager.RetrieveDataById<Item>(int.Parse(lvCart.SelectedItems[0].SubItems[0].Text));
				item.Stocks += 1;
				_itemManager.Update(item);
				
				var amount = int.Parse(lvCart.SelectedItems[0].SubItems[3].Text) / int.Parse(lvCart.SelectedItems[0].SubItems[2].Text);

				var cartItem = _orderManager.RetrieveDataByWhereCondition(new Order()
				{
					CustomerId = _user.CustomerId,
					ItemId = int.Parse(lvCart.SelectedItems[0].SubItems[0].Text),
					IsUnpaid = true
				});

				cartItem.Quantity -= 1;
				cartItem.Amount -= amount;

				_orderManager.Update(cartItem);

				btnRemoveOrder.Enabled = int.Parse(lvCart.SelectedItems[0].SubItems[2].Text) > 0;
			}

			GetSelectedIndexOfCartListView();
			DisplayItemsInListView();
			DisplayCartItems();
			KeepSelectedItemFocusInCartListView();
			
			if (int.Parse(lvCart.SelectedItems[0].SubItems[2].Text) == 0)
			{
				var order = _orderManager.RetrieveDataByWhereCondition(new Order()
				{
					CustomerId = _user.CustomerId,
					ItemId = int.Parse(lvCart.SelectedItems[0].SubItems[0].Text),
					IsUnpaid = true,
					IsCancelled = false
				});

				order.IsCancelled = true;

				_orderManager.Update(order);
				
				lvCart.SelectedItems[0].Remove();
			}

			lblTotalAmount.Text = CalculateTotalAmountOfItemsInCart().ToString();
			btnCheckout.Enabled = lvCart.Items.Count > 0;
		}

		private void BtnCheckout_Click(object sender, EventArgs e)
		{
			var checkOut = new frmCheckout(_user);
			this.Hide();
			checkOut.Show();
		}

		private void BtnSignOff_Click(object sender, EventArgs e)
		{
			MessageBox.Show(_resource.NotificationSignOff);
			
			var welcome = new frmWelcome();
			this.Hide();
			welcome.Show();
		}
		
		private void frmShopping_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = !_closeWindowHelper.NotifyUserForCloseWindow(_user);

		// <--------------------------------------------------     METHODS     -------------------------------------------------->

		private void DisplayItemsInListView()
		{
			lvItems.Items.Clear();

			_itemSortHandler.SortItems(cboSortByType.SelectedIndex, cboSortByNamePrice.SelectedIndex)
				.ForEach(x => lvItems.Items.Add(_listViewItemHelper.FormatListViewRow(x)));
		}

		private void DisplayCartItems()
		{
			lvCart.Items.Clear();
			
			Enumerable.Where(_orderManager.RetrieveAll<Order>(),
					x => x.CustomerId == _user.CustomerId
						 && x.IsUnpaid == true
						 && x.IsCancelled == false)
				.ToList()
				.ForEach(x =>
				{
					if (lvCart.Items.Cast<ListViewItem>().All(y => x.ItemId != int.Parse(y.SubItems[0].Text)))
					{
						var row = new ListViewItem(x.ItemId.ToString());
						row.SubItems.Add(_itemManager.RetrieveDataById<Item>((int)x.ItemId).Name);
						row.SubItems.Add(x.Quantity.ToString());
						row.SubItems.Add(x.Amount.ToString());

						lvCart.Items.Add(row);
					}
				});
			
			lblTotalAmount.Text = CalculateTotalAmountOfItemsInCart().ToString();
		}

		private void PopulateComboBoxes()
		{
			// Combobox of Name-Price Sort
			cboSortByNamePrice.Items.Add(_resource.SortByAscending);
			cboSortByNamePrice.Items.Add(_resource.SortByDescending);
			cboSortByNamePrice.Items.Add(_resource.SortBySmallToBig);
			cboSortByNamePrice.Items.Add(_resource.SortByBigToSmall);

			// Combobox of Type Sort
			_itemTypeHandler.ItemTypeValuesHandler().ForEach(x => cboSortByType.Items.Add(x));
		}

		private void DisplayItemDetailsInLabel() => lblItemDetails.Text =
			string.Format(_resource.ItemDetailsLabelText,
				lvItems.SelectedItems[0].SubItems[1].Text,
				lvItems.SelectedItems[0].SubItems[2].Text,
				lvItems.SelectedItems[0].SubItems[4].Text,
				int.Parse(lvItems.SelectedItems[0].SubItems[5].Text) > 0 ? lblQuantity.Text : string.Empty,
				(int.Parse(lvItems.SelectedItems[0].SubItems[4].Text) * int.Parse(lblQuantity.Text)).ToString());

		private void GetSelectedIndexOfItemsListView()
		{
			if (lvItems.SelectedItems.Count > 0)
			{
				_lastSelectedItemInItemsListView = int.Parse(lvItems.SelectedItems[0].Text);
			}
		}

		private void GetSelectedIndexOfCartListView()
		{
			if (lvCart.SelectedItems.Count > 0)
			{
				_lastSelectedItemInCartListView = int.Parse(lvCart.SelectedItems[0].Text);
			}
		}

		private void KeepSelectedItemFocusInItemsListView()
		{
			var selectedItem = lvItems.Items.Cast<ListViewItem>().FirstOrDefault(x => int.Parse(x.SubItems[0].Text) == _lastSelectedItemInItemsListView);

			if (selectedItem != null)
			{
				selectedItem.Selected = true;
			}
		}

		private void KeepSelectedItemFocusInCartListView()
		{
			var selectedItem = lvCart.Items.Cast<ListViewItem>().FirstOrDefault(x => int.Parse(x.SubItems[0].Text) == _lastSelectedItemInCartListView);

			if (selectedItem != null)
			{
				selectedItem.Selected = true;
			}
		}

		private void RunMethodsForCombobox()
		{
			GetSelectedIndexOfItemsListView();
			DisplayItemsInListView();
			KeepSelectedItemFocusInItemsListView();
		}

		private int CalculateTotalAmountOfItemsInCart() => lvCart.Items.Cast<ListViewItem>().Sum(x => int.Parse(x.SubItems[3].Text));
	}
}