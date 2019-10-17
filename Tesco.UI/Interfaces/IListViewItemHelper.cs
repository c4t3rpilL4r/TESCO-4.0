using System.Windows.Forms;
using Tesco.BL.Models;

namespace Tesco.UI.Interfaces
{
	internal interface IListViewItemHelper
	{
		ListViewItem FormatListViewRow(Item item, string userType = "customer");
	}
}
