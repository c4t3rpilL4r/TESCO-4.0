using System;
using System.Windows.Forms;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.BL.Models;
using Tesco.UI.Helpers;
using Tesco.UI.Interfaces;
using _resource = Tesco.UI.Resources.Strings.en_US.Resources;


namespace Tesco.UI
{
	public partial class frmModifyItem : Form
	{
		private readonly IItemManager _itemManager;
		private readonly IItemTypeManager _itemTypeManager;
		private readonly IItemUserManager _itemUserManager;
		private readonly ICloseWindowHelper _closeWindowHelper;
		private readonly IItemTypeHelper _itemTypeHelper;
		private readonly Item _item;
		private readonly User _user;
		private string _modification;

		public frmModifyItem(Item item, User user, string modification)
		{
			_itemManager = new ItemManager();
			_itemTypeManager = new ItemTypeManager();
			_itemUserManager = new ItemUserManager();
			_closeWindowHelper = new CloseWindowHelper();
			_itemTypeHelper = new ItemTypeHelper();
			_item = item;
			_user = user;
			_modification = modification;
			InitializeComponent();
		}

		private void FrmModifyItem_Load(object sender, System.EventArgs e)
		{
			// Combobox of Item Type
			_itemTypeHelper.ItemTypeValuesHandler().ForEach(x => cboItemType.Items.Add(x));

			if (_modification.Equals(ItemUser.ModificationTypes.Edit))
			{
				txtItemName.Text = _item.Name;
				cboItemType.SelectedItem =
					_itemTypeManager.RetrieveDataById<ItemType>((int) _item.ItemTypeId).TypeDescription;
				txtItemDiscount.Text = _item.Discount.ToString();
				txtItemPrice.Text = _item.Price.ToString();
				txtItemStocks.Text = _item.Stocks.ToString();
			}
		}

		private void TxtItemName_Leave(object sender, EventArgs e)
		{
			var checkItem = _itemManager.RetrieveDataByWhereCondition(new Item() { Name = txtItemName.Text});

			if (checkItem == null) return;

			if (MessageBox.Show(string.Format(_resource.ItemUpdateDataNotification,
					checkItem.Name,
					_itemTypeManager.RetrieveDataById<ItemType>((int)checkItem.ItemTypeId).TypeDescription,
					checkItem.Discount,
					checkItem.Price,
					checkItem.Stocks),
				_resource.ItemVerification,
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question) == DialogResult.Yes)
			{
				_modification = ItemUser.ModificationTypes.Edit.ToString();
				txtItemName.Text = checkItem.Name;
				cboItemType.Text = _itemTypeManager.RetrieveDataById<ItemType>((int) checkItem.ItemTypeId).TypeDescription;
				txtItemDiscount.Text = checkItem.Discount.ToString();
				txtItemPrice.Text = checkItem.Price.ToString();
				txtItemStocks.Text = checkItem.Stocks.ToString();
				btnSave.Focus();
			}
			else
			{
				MessageBox.Show(_resource.UsedItemNameNotification);
				txtItemName.Text = string.Empty;
				txtItemName.Focus();
			}
		}

		private void BtnSave_Click(object sender, System.EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtItemName.Text)
				&& cboItemType.SelectedIndex != -1
				&& !string.IsNullOrWhiteSpace(txtItemDiscount.Text)
				&& !string.IsNullOrWhiteSpace(txtItemPrice.Text)
				&& !string.IsNullOrWhiteSpace(txtItemStocks.Text))
			{
				var itemUser = new ItemUser()
				{
					ModifiedBy = _user.Id,
					DateTimeModification = DateTime.Now.ToString(_resource.DateTimeFormat)
				};

				_item.Name = txtItemName.Text;
				_item.ItemTypeId = _itemTypeManager.RetrieveDataByWhereCondition(new ItemType() { TypeDescription = cboItemType.SelectedItem.ToString() }).Id;
				_item.Discount = int.Parse(txtItemDiscount.Text);
				_item.Price = int.Parse(txtItemPrice.Text);
				_item.Stocks = int.Parse(txtItemStocks.Text);

				if (_modification.Equals(ItemUser.ModificationTypes.Add))
				{
					itemUser.ItemId = _itemManager.Add(_item);
					itemUser.Modification = _modification;
					_itemUserManager.Add(itemUser);

					MessageBox.Show(itemUser.ItemId != 0
						? _resource.AddItemSuccessful
						: _resource.AddItemFailed);
				}
				else if (_modification.Equals(ItemUser.ModificationTypes.Edit))
				{
					itemUser.ItemId = (int) _item.Id;
					itemUser.Modification = _modification;
					_itemUserManager.Add(itemUser);

					MessageBox.Show(_itemManager.Update(_item) != 0
						? _resource.EditItemSuccessful
						: _resource.EditItemFailed);
				}
			}
			else
			{
				MessageBox.Show(_resource.EmptyTextboxNotification);
			}

			var frmItemInventory = new frmItemInventory(_user);
			this.Hide();
			frmItemInventory.Show();
		}

		private void frmModifyItem_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = !_closeWindowHelper.NotifyUserForCloseWindow(_user);
	}
}
