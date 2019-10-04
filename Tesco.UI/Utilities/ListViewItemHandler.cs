using System.Drawing;
using System.Windows.Forms;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.DL.Models;
using Tesco.UI.Interfaces;

namespace Tesco.UI.Utilities
{
	public class ListViewItemHandler : IListViewItemHandler
	{
		private readonly IItemTypeManager _itemTypeManager;

		public ListViewItemHandler()
		{
			_itemTypeManager = new ItemTypeManager();
		}

		public ListViewItem FormatListViewRow(Item item, string userType = "customer")
		{
			var row = new ListViewItem(item.Id.ToString()) {UseItemStyleForSubItems = false};
			row.SubItems.Add(item.Name);
			row.SubItems.Add(_itemTypeManager.RetrieveDataById<ItemType>(item.ItemTypeId).TypeDescription);
			
			if (item.Discount > 0 && userType.Equals("customer"))
			{
				// handles the strikeout ang bold green of discount and price in listview
				row.SubItems.Add(item.Price.ToString()).Font = new Font("Consolas", 9, FontStyle.Strikeout);
				var itemPrice = row.SubItems.Add((item.Price - item.Discount).ToString());
				itemPrice.ForeColor = Color.Green;
				itemPrice.Font = new Font("Consolas", 9, FontStyle.Bold);
			}
			else if (userType.Equals("admin") || userType.Equals("attendant"))
			{
				row.SubItems.Add(item.Discount.ToString());
				row.SubItems.Add(item.Price.ToString());
			}
			else
			{
				row.SubItems.Add("");
				row.SubItems.Add(item.Price.ToString());
			}

			row.SubItems.Add(item.Stocks.ToString());

			return row;
		}
	}
}
