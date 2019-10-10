using System.Collections.Generic;
using Tesco.DL.Models;

namespace Tesco.UI.Interfaces
{
	internal interface IItemSortHelper
	{
		List<Item> SortItems(int sortByType, int sortByNameOrPrice);
	}
}
