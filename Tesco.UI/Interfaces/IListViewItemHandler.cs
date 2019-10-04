using System.Windows.Forms;
using Tesco.DL.Models;

namespace Tesco.UI.Interfaces
{
	internal interface IListViewItemHandler
	{
		ListViewItem FormatListViewRow(Item item, string userType = "customer");
	}
}
