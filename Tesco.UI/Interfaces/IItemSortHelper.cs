using System.Collections.Generic;
using Tesco.BL.Models;

namespace Tesco.UI.Interfaces
{
	internal interface IItemSortHelper
	{
		List<Item> SortItems(int sortByType, int sortByNameOrPrice);
	}
}
