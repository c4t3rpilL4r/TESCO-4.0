using System;
using System.Windows.Forms;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.DL.Models;
using Tesco.UI.Interfaces;
using Tesco.UI.Utilities;

namespace Tesco.UI
{
	public partial class frmItemInventory : Form
	{
		private readonly IItemManager _itemManager;
		private readonly IItemTypeManager _itemTypeManager;
		private readonly IItemTypeHandler _itemTypeHandler;
		private readonly IListViewItemHandler _listViewItemHandler;
		private readonly ISortHandler _sortHandler;
		private readonly User _user;

		public frmItemInventory(User user)
		{
			_itemManager = new ItemManager();
			_itemTypeManager = new ItemTypeManager();
			_itemTypeHandler = new ItemTypeHandler();
			_listViewItemHandler = new ListViewItemHandler();
			_sortHandler = new SortHandler();
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
				Text = "TESCO Add Item"
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
				Stocks = int.Parse(lvItems.SelectedItems[0].SubItems[5].Text)
			};

			var frmModifyItem = new frmModifyItem(item, _user, "Edit")
			{
				Text = "TESCO Edit Item"
			};

			this.Hide();
			frmModifyItem.Show();
		}

		private void BtnDeleteItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show(_itemManager.Delete(int.Parse(lvItems.SelectedItems[0].SubItems[0].Text)) > 0
				? "Item deletion successful."
				: "Item deletion failed.");

			DisplayItemsInListView();
		}

		private void TxtType_Leave(object sender, EventArgs e)
		{
			if (_itemTypeManager.RetrieveDataByWhereCondition(new ItemType() { TypeDescription = txtType.Text }) == null) return;
			
			MessageBox.Show($@"Item type: {txtType.Text} is registered already.");
			txtType.Text = string.Empty;
			txtType.Focus();
		}

		private void BtnAddItemType_Click(object sender, EventArgs e)
		{
			MessageBox.Show(!string.IsNullOrWhiteSpace(txtType.Text)
				? _itemTypeManager.Add(new ItemType() { TypeDescription = txtType.Text }) != 0
					? "Item type adding successful."
					: "Item type adding failed."
				: "Please enter a valid item type.");

			DisplayItemsInListView();
		}

		private void BtnDeleteItemType_Click(object sender, EventArgs e)
		{
			MessageBox.Show(!cboSortByType.Items.Contains(cboType.SelectedText)
				? _itemTypeManager.Delete(_itemTypeManager.RetrieveDataByWhereCondition(new ItemType() { TypeDescription = cboType.SelectedItem.ToString() }).Id) > 0
					? "Item type deletion successful."
					: "Item type deletion failed."
				: "Cannot delete. Item type has item stocks.");

			DisplayItemsInListView();
		}

		private void CboType_SelectedIndexChanged(object sender, EventArgs e) => btnDeleteItemType.Enabled = cboType.SelectedIndex != -1;


		// <--------------------------------------------------     METHODS     -------------------------------------------------->

		// handles the displaying of the items in the lvItems
		private void DisplayItemsInListView()
		{
			lvItems.Items.Clear();

			_sortHandler.SortItems(cboSortByType.SelectedIndex, cboSortByNamePrice.SelectedIndex).ForEach(x => lvItems.Items.Add(ConvertToListViewItem(x)));
		}

		private void PopulateComboBoxes()
		{
			cboSortByNamePrice.Items.Clear();
			cboSortByType.Items.Clear();
			cboType.Items.Clear();

			// Combobox of Name-Price Sort
			cboSortByNamePrice.Items.Add("By Name: Ascending");
			cboSortByNamePrice.Items.Add("By Name: Descending");
			cboSortByNamePrice.Items.Add("By Price: Small to Big");
			cboSortByNamePrice.Items.Add("By Price: Big to Small");

			// Combobox of Type Sort
			_itemTypeHandler.ItemTypeValuesHandler().ForEach(x => cboSortByType.Items.Add(x));

			// Combobox of Type
			_itemTypeManager.RetrieveAll<ItemType>().ForEach(x => cboType.Items.Add(x.TypeDescription));
		}

		private ListViewItem ConvertToListViewItem(Item item)
		{
			var row = new ListViewItem(item.Id.ToString());
			row.SubItems.Add(item.Name);
			row.SubItems.Add(_itemTypeManager.RetrieveDataById<ItemType>(item.ItemTypeId).TypeDescription);
			row.SubItems.Add(item.Discount.ToString());
			row.SubItems.Add(item.Price.ToString());
			row.SubItems.Add(item.Stocks.ToString());

			return row;
		}
	}
}
