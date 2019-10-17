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
	public partial class frmItemInventory : Form
	{
		private readonly IItemManager _itemManager;
		private readonly IItemTypeManager _itemTypeManager;
		private readonly ICloseWindowHelper _closeWindowHelper;
		private readonly IItemTypeHelper _itemTypeHelper;
		private readonly IItemSortHelper _itemSortHelper;
		private readonly User _user;

		public frmItemInventory(User user)
		{
			_itemManager = new ItemManager();
			_itemTypeManager = new ItemTypeManager();
			_closeWindowHelper = new CloseWindowHelper();
			_itemTypeHelper = new ItemTypeHelper();
			_itemSortHelper = new ItemSortHelper();
			_user = user;
			InitializeComponent();
		}

		private void FrmItemInventory_Load(object sender, EventArgs e)
		{
			DisplayItemsInListView();
			PopulateComboBoxes();

			txtType.Text = string.Empty;
			cboType.Text = string.Empty;

			if (_user.Type != "attendant") return;
			
			btnDeleteItem.Visible = false;
			grpItemTypes.Visible = false;
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
			btnEditItem.Enabled = lvItems.SelectedItems.Count > 0;
			btnDeleteItem.Enabled = lvItems.SelectedItems.Count > 0;
		}

		private void BtnAddItem_Click(object sender, EventArgs e)
		{
			var item = new Item();
			var frmModifyItem = new frmModifyItem(item, _user, "Add")
			{
				Text = _resource.AddItemTitle
			};

			this.Hide();
			frmModifyItem.Show();
		}

		private void BtnEditItem_Click(object sender, EventArgs e)
		{
			var item = new Item() {
				Id = int.Parse(lvItems.SelectedItems[0].SubItems[0].Text),
				Name = lvItems.SelectedItems[0].SubItems[1].Text,
				ItemTypeId = _itemTypeManager.RetrieveDataByWhereCondition(new ItemType() { TypeDescription = lvItems.SelectedItems[0].SubItems[2].Text }).Id,
				Discount = int.Parse(lvItems.SelectedItems[0].SubItems[3].Text),
				Price = int.Parse(lvItems.SelectedItems[0].SubItems[4].Text),
				Stocks = int.Parse(lvItems.SelectedItems[0].SubItems[5].Text),
				IsDeleted = false
			};

			var frmModifyItem = new frmModifyItem(item, _user, "Edit")
			{
				Text = _resource.EditItemTitle
			};

			this.Hide();
			frmModifyItem.Show();
		}

		private void BtnDeleteItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show(_itemManager.Delete<Item>(int.Parse(lvItems.SelectedItems[0].SubItems[0].Text)) > 0
				? _resource.DeleteItemSuccessful
				: _resource.DeleteItemFailed);

			DisplayItemsInListView();
		}

		private void TxtType_Leave(object sender, EventArgs e)
		{
			if (_itemTypeManager.RetrieveDataByWhereCondition(new ItemType() { TypeDescription = txtType.Text }) == null) return;
			
			MessageBox.Show(string.Format(_resource.RegisteredItemNotification, txtType.Text));
			txtType.Text = string.Empty;
			txtType.Focus();
		}

		private void BtnAddItemType_Click(object sender, EventArgs e)
		{
			MessageBox.Show(!string.IsNullOrWhiteSpace(txtType.Text)
				? _itemTypeManager.Add(new ItemType()
				{
					TypeDescription = txtType.Text,
					IsDeleted = false
				}) != 0
					? _resource.AddItemTypeSuccessful
					: _resource.AddItemTypeFailed
				: _resource.ValidItemTypeNotification);

			DisplayItemsInListView();
		}

		private void BtnDeleteItemType_Click(object sender, EventArgs e)
		{
			var item = _itemTypeManager.RetrieveDataByWhereCondition(new ItemType()
			{
				TypeDescription = cboType.SelectedItem.ToString(),
				IsDeleted = false
			});
			
			MessageBox.Show(!cboSortByType.Items.Contains(cboType.SelectedText)
				? item.Id != null && _itemTypeManager.Delete<ItemType>((int) item.Id) > 0
					? _resource.DeleteItemTypeSuccessful
					: _resource.DeleteItemTypeFailed
				: _resource.ItemTypeDeletionNotification);

			DisplayItemsInListView();
		}

		private void CboType_SelectedIndexChanged(object sender, EventArgs e) => btnDeleteItemType.Enabled = cboType.SelectedIndex != -1;

		private void frmItemInventory_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = !_closeWindowHelper.NotifyUserForCloseWindow();



		// <--------------------------------------------------     METHODS     -------------------------------------------------->

		private void DisplayItemsInListView()
		{
			lvItems.Items.Clear();

			_itemSortHelper.SortItems(cboSortByType.SelectedIndex, cboSortByNamePrice.SelectedIndex)
				.ForEach(x => lvItems.Items.Add(ConvertToItemsListViewItem(x)));
		}

		private void PopulateComboBoxes()
		{
			cboSortByNamePrice.Items.Clear();
			cboSortByType.Items.Clear();
			cboType.Items.Clear();

			// Combobox of Name-Price Sort
			cboSortByNamePrice.Items.Add(_resource.SortByAscending);
			cboSortByNamePrice.Items.Add(_resource.SortByDescending);
			cboSortByNamePrice.Items.Add(_resource.SortBySmallToBig);
			cboSortByNamePrice.Items.Add(_resource.SortByBigToSmall);

			// Combobox of Type Sort
			_itemTypeHelper.ItemTypeValuesHandler().ForEach(x => cboSortByType.Items.Add(x));

			// Combobox of Type
			_itemTypeManager.RetrieveAll<ItemType>().ForEach(x => cboType.Items.Add(x.TypeDescription));
		}

		private ListViewItem ConvertToItemsListViewItem(Item item)
		{
			var row = new ListViewItem(item.Id.ToString());
			row.SubItems.Add(item.Name);
			row.SubItems.Add(_itemTypeManager.RetrieveDataById<ItemType>((int) item.ItemTypeId).TypeDescription);
			row.SubItems.Add(item.Discount.ToString());
			row.SubItems.Add(item.Price.ToString());
			row.SubItems.Add(item.Stocks.ToString());

			return row;
		}
	}
}
