using System;
using System.Windows.Forms;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.DL.Models;
using Tesco.UI.Interfaces;
using Tesco.UI.Utilities;

namespace Tesco.UI
{
	public partial class frmModifyItem : Form
	{
		private readonly IItemManager _itemManager;
		private readonly IItemTypeManager _itemTypeManager;
		private readonly IItemUserManager _itemUserManager;
		private readonly IItemTypeHandler _itemTypeHandler;
		private readonly Item _item;
		private readonly User _user;
		private string _modification;

		public frmModifyItem(Item item, User user, string modification)
		{
			_itemManager = new ItemManager();
			_itemTypeManager = new ItemTypeManager();
			_itemUserManager = new ItemUserManager();
			_itemTypeHandler = new ItemTypeHandler();
			_item = item;
			_user = user;
			_modification = modification;
			InitializeComponent();
		}

		private void FrmModifyItem_Load(object sender, System.EventArgs e)
		{
			// Combobox of Item Type
			_itemTypeHandler.ItemTypeValuesHandler().ForEach(x => cboItemType.Items.Add(x));

			if (!_modification.Equals("edit")) return;
			
			txtItemName.Text = _item.Name;
			cboItemType.SelectedItem = _itemTypeManager.RetrieveDataById<ItemType>(_item.ItemTypeId).TypeDescription;
			txtItemDiscount.Text = _item.Discount.ToString();
			txtItemPrice.Text = _item.Price.ToString();
			txtItemStocks.Text = _item.Stocks.ToString();
		}

		private void TxtItemName_Leave(object sender, EventArgs e)
		{
			var checkItem = _itemManager.RetrieveDataByWhereCondition(new Item() { Name = txtItemName.Text});

			if (checkItem == null) return;
			if (MessageBox.Show("Another item has the same name:\n" +
			                          $"Name:\t\t{checkItem.Name}\n" +
			                          $"Type:\t\t{_itemTypeManager.RetrieveDataById<ItemType>(checkItem.ItemTypeId).TypeDescription}\n" +
			                          $"Discount:\t{checkItem.Discount}\n" +
			                          $"Price:\t\t{checkItem.Price}\n" +
			                          $"Stocks:\t\t{checkItem.Stocks}\n\n" +
			                          $"Is this the same item?",
				    "Verify Item",
				    MessageBoxButtons.YesNo,
				    MessageBoxIcon.Question) == DialogResult.Yes)
			{
				_modification = "Edit";
				txtItemName.Text = checkItem.Name;
				cboItemType.Text = _itemTypeManager.RetrieveDataById<ItemType>(checkItem.ItemTypeId).TypeDescription;
				txtItemDiscount.Text = checkItem.Discount.ToString();
				txtItemPrice.Text = checkItem.Price.ToString();
				txtItemStocks.Text = checkItem.Stocks.ToString();
				btnSave.Focus();
			}
			else
			{
				MessageBox.Show(@"Item name is taken. Please change item name.");
				txtItemName.Text = string.Empty;
				txtItemName.Focus();
			}
		}

		private void BtnSave_Click(object sender, System.EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtItemName.Text) && !string.IsNullOrWhiteSpace(txtItemName.Text)
				&& cboItemType.SelectedIndex != -1
				&& !string.IsNullOrEmpty(txtItemDiscount.Text) && !string.IsNullOrWhiteSpace(txtItemDiscount.Text)
				&& !string.IsNullOrEmpty(txtItemPrice.Text) && !string.IsNullOrWhiteSpace(txtItemPrice.Text)
				&& !string.IsNullOrEmpty(txtItemStocks.Text) && !string.IsNullOrWhiteSpace(txtItemStocks.Text))
			{
				var itemUser = new ItemUser()
				{
					ModifiedBy = _user.Id,
					DateTimeModification = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss tt")
				};

				_item.Name = txtItemName.Text;
				_item.ItemTypeId = _itemTypeManager.RetrieveDataByWhereCondition(new ItemType() { TypeDescription = cboItemType.SelectedItem.ToString() }).Id;
				_item.Discount = int.Parse(txtItemDiscount.Text);
				_item.Price = int.Parse(txtItemPrice.Text);
				_item.Stocks = int.Parse(txtItemStocks.Text);

				if (_modification.Equals("Add"))
				{
					itemUser.ItemId = _itemManager.Add(_item);
					itemUser.Modification = _modification;
					_itemUserManager.Add(itemUser);

					MessageBox.Show(itemUser.ItemId != 0
						? "Item adding successful."
						: "Item adding failed.");
				}
				else if (_modification.Equals("Edit"))
				{
					itemUser.ItemId = _item.Id;
					itemUser.Modification = _modification;
					_itemUserManager.Add(itemUser);

					MessageBox.Show(_itemManager.Update(_item) != 0
						? "Item editing successful."
						: "Item editing failed.");
				}
			}
			else
			{
				MessageBox.Show(@"Please fill up all the details. Thank you.");
			}

			var frmItemInventory = new frmItemInventory(_user);
			this.Hide();
			frmItemInventory.Show();
		}
	}
}
