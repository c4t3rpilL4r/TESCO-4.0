using System.Drawing;
using System.Windows.Forms;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.BL.Models;
using Tesco.UI.Interfaces;
using _resource = Tesco.UI.Resources.Resources;


namespace Tesco.UI.Helpers
{
	public class ListViewItemHelper : IListViewItemHelper
	{
		private readonly IItemTypeManager _itemTypeManager;

		public ListViewItemHelper()
		{
			_itemTypeManager = new ItemTypeManager();
		}

		public ListViewItem FormatListViewRow(Item item, string userType = "customer")
		{
			var row = new ListViewItem(item.Id.ToString()) {UseItemStyleForSubItems = false};
			row.SubItems.Add(item.Name);
			row.SubItems.Add(_itemTypeManager.RetrieveDataById<ItemType>((int) item.ItemTypeId).TypeDescription);
			
			if (item.Discount > 0 && userType.Equals(User.UserTypes.customer.ToString()))
			{
				// handles the strikeout ang bold green of discount and price in listview
				row.SubItems.Add(item.Price.ToString()).Font = new Font(_resource.FontFaceConsolas, 9, FontStyle.Strikeout);
				var itemPrice = row.SubItems.Add((item.Price - item.Discount).ToString());
				itemPrice.ForeColor = Color.Green;
				itemPrice.Font = new Font(_resource.FontFaceConsolas, 9, FontStyle.Bold);
			}
			else if (userType.Equals(User.UserTypes.admin.ToString()) || userType.Equals(User.UserTypes.attendant.ToString()))
			{
				row.SubItems.Add(item.Discount.ToString());
				row.SubItems.Add(item.Price.ToString());
			}
			else
			{
				row.SubItems.Add(string.Empty);
				row.SubItems.Add(item.Price.ToString());
			}

			row.SubItems.Add(item.Stocks.ToString());

			return row;
		}
	}
}
