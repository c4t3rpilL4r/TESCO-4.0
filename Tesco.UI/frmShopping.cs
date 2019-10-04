using System;
using System.Linq;
using System.Windows.Forms;
using Tesco.BL.Managers;
using Tesco.UI.Utilities;
using Tesco.DL.Models;
using System.Collections.Generic;
using Tesco.UI.Interfaces;
using Tesco.BL.Interfaces;
using System.Drawing;

namespace Tesco.UI
{
	public partial class frmShopping : Form
	{
		private readonly IItemManager _itemManager;
		private readonly IItemTypeManager _itemTypeManager;
		private readonly IOrderManager _orderManager;
		private readonly IOrderCustomerManager _orderCustomerManager;
		private readonly IItemTypeHandler _itemTypeHandler;
		private readonly IListViewItemHandler _listViewItemHandler;
		private readonly ISortHandler _sortHandler;
		private readonly User _user;
		private int _lastSelectedItemInItemsListView = 0;

		public frmShopping(User user = null)
		{
			_itemManager = new ItemManager();
			_itemTypeManager = new ItemTypeManager();
			_orderManager = new OrderManager();
			_orderCustomerManager = new OrderCustomerManager();
			_itemTypeHandler = new ItemTypeHandler();
			_listViewItemHandler = new ListViewItemHandler();
			_sortHandler = new SortHandler();
			_user = user;
			InitializeComponent();
		}

		private void FrmShopping_Load(object sender, EventArgs e)
		{
			if (_user != null)
			{
				lblUserGreeting.Visible = true;
				lblUserGreeting.Text = $"\tHello, {_user.Username}.";
				btnSignOff.Enabled = true;
				btnSignOff.Visible = true;
			}
			
			DisplayItemsInListView();

			// Combobox of Name-Price Sort
			cboSortByNamePrice.Items.Add("By Name: Ascending");
			cboSortByNamePrice.Items.Add("By Name: Descending");
			cboSortByNamePrice.Items.Add("By Price: Small to Big");
			cboSortByNamePrice.Items.Add("By Price: Big to Small");

			// Combobox of Type Sort

			_itemTypeHandler.ItemTypeValuesHandler().ForEach(x => cboSortByType.Items.Add(x));
		}

		private void CboSortByNamePrice_SelectedIndexChanged(object sender, EventArgs e) => DisplayItemsInListView();

		private void CboSortByType_SelectedIndexChanged(object sender, EventArgs e) => DisplayItemsInListView();

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

			// check item stocks number
			if (int.Parse(lvItems.SelectedItems[0].SubItems[5].Text) > 0)
			{
				lblQuantity.Text = "1";
			}
			else
			{
				MessageBox.Show(@"Sorry. Item is out of stocks.");
			}

			btnAdd.Enabled = int.Parse(lvItems.SelectedItems[0].SubItems[5].Text) > 0;
			btnAddToCart.Enabled = int.Parse(lvItems.SelectedItems[0].SubItems[5].Text) > 0;
		}

		private void LvItems_Leave(object sender, EventArgs e) => _lastSelectedItemInItemsListView = int.Parse(lvItems.SelectedItems[0].Text);

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			// check if there are stocks available
			if ((int.Parse(lvItems.SelectedItems[0].SubItems[5].Text) > 1)
				&& (int.Parse(lblQuantity.Text) < int.Parse(lvItems.SelectedItems[0].SubItems[5].Text)))
			{
				// add 1 to label
				lblQuantity.Text = (int.Parse(lblQuantity.Text) + 1).ToString();

				// subtract 1 from item stocks
				lvItems.SelectedItems[0].SubItems[5].Text = (int.Parse(lvItems.SelectedItems[0].SubItems[5].Text) - 1).ToString();
			}

			DisplayItemDetailsInLabel();
		}

		private void LblQuantity_TextChanged(object sender, EventArgs e) => btnSubtract.Enabled = int.Parse(lblQuantity.Text) > 1;

		private void BtnSubtract_Click(object sender, EventArgs e)
		{
			if (int.Parse(lblQuantity.Text) <= 1) return;
			
			// subtract 1 from label
			lblQuantity.Text = (int.Parse(lblQuantity.Text) - 1).ToString();

			// add 1 to item stocks
			lvItems.SelectedItems[0].SubItems[5].Text = (int.Parse(lvItems.SelectedItems[0].SubItems[5].Text) + 1).ToString();

			DisplayItemDetailsInLabel();
		}

		private void BtnAddToCart_Click(object sender, EventArgs e)
		{
			if (lvItems.SelectedItems.Count > 0)
			{
				var item = _itemManager.RetrieveDataById<Item>(int.Parse(lvItems.SelectedItems[0].SubItems[0].Text));

				// check if there are stocks available
				if (!(item.Stocks > 0)) return;
				
				// check if lvCart is not empty
				if (lvCart.Items.Count > 0)
				{
					var inList = false;

					// check if item is already in lvCart
					foreach (ListViewItem items in lvCart.Items)
					{
						// comparison by itemId
						if (item.Id != int.Parse(items.Text)) continue;

						// just change the number in quantity and price
						items.SubItems[2].Text =
							(int.Parse(items.SubItems[2].Text) + int.Parse(lblQuantity.Text))
							.ToString();
						items.SubItems[3].Text = (int.Parse(items.SubItems[3].Text) +
														 (int.Parse(lblQuantity.Text) * int.Parse(lvItems.SelectedItems[0].SubItems[4].Text))
														 ).ToString();
						inList = true;
						break;
					}

					// item is not in lvCart
					if (!inList)
					{
						AddItemToCartListView();
					}
				}
				else // if lvCart is empty
				{
					AddItemToCartListView();
				}

				// deduct item stocks number
				item.Stocks -= int.Parse(lblQuantity.Text);
				_itemManager.Update(item);

				btnAdd.Enabled = item.Stocks > 0;
				btnAddToCart.Enabled = item.Stocks > 0;

				lblTotalAmount.Text = CalculateTotalAmountOfItemsInCart().ToString();
				lblQuantity.Text = "1";

				btnCheckout.Enabled = lvCart.Items.Count > 0;
				DisplayItemsInListView();
			}
			else
			{
				MessageBox.Show(@"Please make sure that the item you want to add to cart is seen and is highlighted.
								Try pressing the Reset Sort Order button to show all the items.");
			}

			KeepSelectedItemFocusInItemsListView();
		}

		private void LvCart_SelectedIndexChanged(object sender, EventArgs e) => btnRemoveOrder.Enabled = lvCart.SelectedItems.Count > 0;

		private void BtnRemoveOrder_Click(object sender, EventArgs e)
		{
			// remove items
			if (lvCart.SelectedItems.Count > 0)
			{
				var item = _itemManager.RetrieveDataById<Item>(int.Parse(lvCart.SelectedItems[0].SubItems[0].Text));
				item.Stocks += 1;
				_itemManager.Update(item);
				
				var amount = int.Parse(lvCart.SelectedItems[0].SubItems[3].Text) / int.Parse(lvCart.SelectedItems[0].SubItems[2].Text);
				
				lvCart.SelectedItems[0].SubItems[2].Text = (int.Parse(lvCart.SelectedItems[0].SubItems[2].Text) - 1).ToString();
				lvCart.SelectedItems[0].SubItems[3].Text = (int.Parse(lvCart.SelectedItems[0].SubItems[2].Text) * amount).ToString();

				btnRemoveOrder.Enabled = int.Parse(lvCart.SelectedItems[0].SubItems[2].Text) > 0;
				
				if (int.Parse(lvCart.SelectedItems[0].SubItems[2].Text) == 0)
				{
					lvCart.SelectedItems[0].Remove();
				}
			}

			DisplayItemsInListView();

			lblTotalAmount.Text = CalculateTotalAmountOfItemsInCart().ToString();
		}

		private void BtnCheckout_Click(object sender, EventArgs e)
		{
			if (_user != null)
			{
				lvCart.Items.Cast<ListViewItem>().ToList().ForEach(x =>
				{
					_orderCustomerManager.Add(new OrderCustomer()
					{
						CustomerId = _user.CustomerId,
						ItemId = int.Parse(x.SubItems[0].Text),
						Quantity = int.Parse(x.SubItems[2].Text),
						Amount = int.Parse(x.SubItems[3].Text),
						IsCurrentOrder = true,
						IsUnpaid = true
					});
				});

				var checkOut = new frmCheckout(_user);

				this.Hide();
				checkOut.Show();
				checkOut.Dispose();
			}
			else
			{
				MessageBox.Show("Please login to continue.");
				
				var login = new frmRegisterLogin(0);
				login.Show();
				login.Dispose();
			}
		}

		private void BtnSignOff_Click(object sender, EventArgs e)
		{
			if (lvCart.Items.Count > 0)
			{
				AddCartItemsToDatabase();
			}
			
			MessageBox.Show("You have signed off.");
			
			var welcome = new frmWelcome();
			this.Hide();
			welcome.Show();
			welcome.Dispose();
		}
		
		private void frmShopping_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_user != null)
			{
				if (lvCart.Items.Count > 0)
				{
					AddCartItemsToDatabase();
				}
			}
			else
			{
				if (lvCart.Items.Count > 0)
				{
					lvCart.Items.Cast<ListViewItem>().ToList()
						.ForEach(x =>
						{
							var item = _itemManager.RetrieveDataById<Item>(int.Parse(x.SubItems[0].Text));

							item.Stocks += int.Parse(x.SubItems[2].Text);

							_itemManager.Update(item);
						});
				}
			}

			var welcome = new frmWelcome();
			welcome.Show();
			welcome.Dispose();
		}


		// <--------------------------------------------------     METHODS     -------------------------------------------------->

		// handles the displaying of the items in the lvItems
		private void DisplayItemsInListView()
		{
			lvItems.Items.Clear();

			_sortHandler.SortItems(cboSortByType.SelectedIndex, cboSortByNamePrice.SelectedIndex)
				.ForEach(x => lvItems.Items.Add(_listViewItemHandler.FormatListViewRow(x)));
		}

		// handles the displaying of the item details in the lblItemDetails
		private void DisplayItemDetailsInLabel() => lblItemDetails.Text = $@"Name:     {lvItems.SelectedItems[0].SubItems[1].Text}
Type:     {lvItems.SelectedItems[0].SubItems[2].Text}
Price:    {lvItems.SelectedItems[0].SubItems[4].Text}
Quantity: {(int.Parse(lvItems.SelectedItems[0].SubItems[5].Text) > 0 ? lblQuantity.Text : "")}
Total:    {(int.Parse(lvItems.SelectedItems[0].SubItems[4].Text) * int.Parse(lblQuantity.Text)).ToString()}";

		private void KeepSelectedItemFocusInItemsListView() => lvItems.Items[_lastSelectedItemInItemsListView - 1].Selected = _lastSelectedItemInItemsListView > 0;

		// handles the adding of the items from lvItems to lvCart
		private void AddItemToCartListView()
		{
			var row = new ListViewItem(lvItems.SelectedItems[0].Text);
			row.SubItems.Add(lvItems.SelectedItems[0].SubItems[1].Text);
			row.SubItems.Add(lblQuantity.Text);
			row.SubItems.Add((int.Parse(lvItems.SelectedItems[0].SubItems[4].Text) * int.Parse(lblQuantity.Text)).ToString());
			lvCart.Items.Add(row);
		}

		// handles the calculation of the total amount of the items added to lvCart
		private int CalculateTotalAmountOfItemsInCart() => lvCart.Items.Cast<ListViewItem>().Sum(x => int.Parse(x.SubItems[3].Text));
		
		// handles adding the items from lvCart to ItemCustomer db table when user signs off or closes the form
		private void AddCartItemsToDatabase()
		{
			lvCart.Items.Cast<ListViewItem>().ToList().ForEach(x =>
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
			});
		}
	}
}