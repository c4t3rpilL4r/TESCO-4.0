using System;
using System.Linq;
using System.Windows.Forms;
using Tesco.BL.Managers;
using Tesco.UI.Utilities;
using Tesco.DL.Models;
using Tesco.UI.Interfaces;
using Tesco.BL.Interfaces;

namespace Tesco.UI
{
	public partial class frmShopping : Form
	{
		private readonly ICustomerManager _customerManager;
		private readonly IItemManager _itemManager;
		private readonly IItemTypeManager _itemTypeManager;
		private readonly IOrderManager _orderManager;
		private readonly IItemCustomerManager _itemCustomerManager;
		private readonly IUserManager _userManager;
		private readonly IItemTypeHandler _itemTypeHandler;
		private readonly IListViewItemHandler _listViewItemHandler;
		private readonly ISortHandler _sortHandler;
		private readonly Customer _customer;
		private readonly User _user;
		private int _lastSelectedItemInItemsListView = 0;

		public frmShopping(User user)
		{
			_customerManager = new CustomerManager();
			_itemManager = new ItemManager();
			_itemTypeManager = new ItemTypeManager();
			_orderManager = new OrderManager();
			_itemCustomerManager = new ItemCustomerManager();
			_userManager = new UserManager();
			_itemTypeHandler = new ItemTypeHandler();
			_listViewItemHandler = new ListViewItemHandler();
			_sortHandler = new SortHandler();
			_customer = _customerManager.RetrieveDataById<Customer>(user.CustomerId);
			_user = user;
			InitializeComponent();
		}

		private void FrmShopping_Load(object sender, EventArgs e)
		{
			btnSignOff.Enabled = _customer.IsGuest != true;
			btnSignOff.Visible = _customer.IsGuest != true;
			lblUserGreeting.Text = $"Hello, {(_customer.IsGuest != true ? _customer.FullName : "Guest")}.";

			if (_customer.IsGuest != true)
			{
				DisplayCartItems();
			}

			DisplayItemsInListView();
			PopulateComboBoxes();
		}

		private void CboSortByNamePrice_SelectedIndexChanged(object sender, EventArgs e)
		{
			GetSelectedIndexOfItemsListView();
			DisplayItemsInListView();
			KeepSelectedItemFocusInItemsListView();
		}

		private void CboSortByType_SelectedIndexChanged(object sender, EventArgs e)
		{
			GetSelectedIndexOfItemsListView();
			DisplayItemsInListView();
			KeepSelectedItemFocusInItemsListView();
		}

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

				lblQuantity.Text = "0";
			}
			else
			{
				MessageBox.Show(@"Sorry. Item is out of stocks.");
			}

			btnAdd.Enabled = int.Parse(lvItems.SelectedItems[0].SubItems[5].Text) > 0;
			btnAddToCart.Enabled = int.Parse(lvItems.SelectedItems[0].SubItems[5].Text) > 0;
		}

		private void LvItems_Leave(object sender, EventArgs e)
		{
			GetSelectedIndexOfItemsListView();
			KeepSelectedItemFocusInItemsListView();
		}

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

		private void LblQuantity_TextChanged(object sender, EventArgs e) => btnSubtract.Enabled = int.Parse(lblQuantity.Text) > 0;

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
				var item = _itemManager.RetrieveDataById<Item>(int.Parse(lvItems.SelectedItems[0].SubItems[0].Text));

				if (item.Stocks > 0)
				{
					var cartItem = lvCart.Items.Cast<ListViewItem>().FirstOrDefault(x => item.Id == int.Parse(x.SubItems[0].Text));

					if (cartItem != null)
					{
						cartItem.SubItems[2].Text = (int.Parse(cartItem.SubItems[2].Text) + int.Parse(lblQuantity.Text)).ToString();
						cartItem.SubItems[3].Text = (int.Parse(lvItems.SelectedItems[0].SubItems[4].Text) * int.Parse(lblQuantity.Text) + int.Parse(cartItem.SubItems[3].Text)).ToString();
					}
					else
					{
						var row = new ListViewItem(lvItems.SelectedItems[0].Text);
						row.SubItems.Add(lvItems.SelectedItems[0].SubItems[1].Text);
						row.SubItems.Add(lblQuantity.Text);
						row.SubItems.Add((int.Parse(lvItems.SelectedItems[0].SubItems[4].Text) * int.Parse(lblQuantity.Text)).ToString());

						lvCart.Items.Add(row);
					}

					item.Stocks -= int.Parse(lblQuantity.Text);
					_itemManager.Update(item);

					btnAdd.Enabled = item.Stocks > 0;
					btnAddToCart.Enabled = item.Stocks > 0;

					lblTotalAmount.Text = CalculateTotalAmountOfItemsInCart().ToString();
					lblQuantity.Text = "1";

					btnCheckout.Enabled = lvCart.Items.Count > 0;

					GetSelectedIndexOfItemsListView();
					DisplayItemsInListView();
					KeepSelectedItemFocusInItemsListView();
				}
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
			lvCart.Items.Cast<ListViewItem>().ToList().ForEach(x =>
			{
				_itemCustomerManager.Add(new ItemCustomer()
				{
					CustomerId = _user.CustomerId,
					ItemId = int.Parse(x.SubItems[0].Text),
					Quantity = int.Parse(x.SubItems[2].Text),
					Amount = int.Parse(x.SubItems[3].Text),
					IsCurrentOrder = true,
					IsUnpaid = true
				});
			});

			if (_customer.IsGuest != true)
			{
				if (_itemCustomerManager.RetrieveAll<ItemCustomer>().Where(x => x.IsUnpaid == true).ToList().Count > 0)
				{
					if (MessageBox.Show("You have an unfinished transaction. Along with your current orders, would you like to proceed to it?",
										"Unfinished Transaction",
										MessageBoxButtons.YesNo,
										MessageBoxIcon.Question) == DialogResult.Yes)
					{
						var unfinished = new frmUnfinishedTransaction(_user);
						unfinished.Show();

						return;
					}
				}

				var checkOut = new frmCheckout(_user);
				checkOut.Show();
			}
			else
			{
				MessageBox.Show("Please register/login to continue.");
				
				var login = new frmRegisterLogin(0, _user);
				login.Show();
			}
			
			this.Hide();
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
		}
		
		private void frmShopping_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_customer.IsGuest != true)
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
					lvCart.Items.Cast<ListViewItem>()
						.ToList()
						.ForEach(x =>
						{
							var item = _itemManager.RetrieveDataById<Item>(int.Parse(x.SubItems[0].Text));

							item.Stocks += int.Parse(x.SubItems[2].Text);

							_itemManager.Update(item);
						});
				}

				_user.IsDeleted = true;

				_userManager.Update<User>(_user);
			}

			var welcome = new frmWelcome();
			welcome.Show();
		}


		// <--------------------------------------------------     METHODS     -------------------------------------------------->

		private void DisplayItemsInListView()
		{
			lvItems.Items.Clear();

			_sortHandler.SortItems(cboSortByType.SelectedIndex, cboSortByNamePrice.SelectedIndex)
				.ForEach(x => lvItems.Items.Add(_listViewItemHandler.FormatListViewRow(x)));
		}

		private void DisplayCartItems()
		{
			Enumerable.Where(_itemCustomerManager.RetrieveAll<ItemCustomer>(), x => x.CustomerId == _user.CustomerId && x.IsCurrentOrder == true && x.IsUnpaid == true)
				.ToList()
				.ForEach(x =>
				{
					var row = new ListViewItem(x.ItemId.ToString());
					row.SubItems.Add(_itemManager.RetrieveDataById<Item>(x.ItemId).Name);
					row.SubItems.Add(x.Quantity.ToString());
					row.SubItems.Add(x.Amount.ToString());
					
					lvCart.Items.Add(row);
				});
		}

		private void PopulateComboBoxes()
		{
			// Combobox of Name-Price Sort
			cboSortByNamePrice.Items.Add("By Name: Ascending");
			cboSortByNamePrice.Items.Add("By Name: Descending");
			cboSortByNamePrice.Items.Add("By Price: Small to Big");
			cboSortByNamePrice.Items.Add("By Price: Big to Small");

			// Combobox of Type Sort

			_itemTypeHandler.ItemTypeValuesHandler().ForEach(x => cboSortByType.Items.Add(x));
		}

		private void DisplayItemDetailsInLabel() => lblItemDetails.Text =
			$"Name:      {lvItems.SelectedItems[0].SubItems[1].Text}\n" +
			$"Type:      {lvItems.SelectedItems[0].SubItems[2].Text}\n" +
			$"Price:     {lvItems.SelectedItems[0].SubItems[4].Text}\n" +
			$"Quantity:  {(int.Parse(lvItems.SelectedItems[0].SubItems[5].Text) > 0 ? lblQuantity.Text : "")}\n" +
			$"Total:     {(int.Parse(lvItems.SelectedItems[0].SubItems[4].Text) * int.Parse(lblQuantity.Text)).ToString()}";

		private void GetSelectedIndexOfItemsListView()
		{
			if (lvItems.SelectedItems.Count > 0)
			{
				_lastSelectedItemInItemsListView = int.Parse(lvItems.SelectedItems[0].Text);
			}
		}

		private void KeepSelectedItemFocusInItemsListView()
		{
			var selectedItem = lvItems.Items.Cast<ListViewItem>().FirstOrDefault(x => int.Parse(x.SubItems[0].Text) == _lastSelectedItemInItemsListView);

			selectedItem.Selected = selectedItem != null;
		}

		private int CalculateTotalAmountOfItemsInCart() => lvCart.Items.Cast<ListViewItem>().Sum(x => int.Parse(x.SubItems[3].Text));
		
		private void AddCartItemsToDatabase()
		{
			lvCart.Items.Cast<ListViewItem>().ToList().ForEach(x =>
			{
				_itemCustomerManager.Add(new ItemCustomer()
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