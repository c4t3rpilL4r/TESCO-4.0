using System.Collections.Generic;
using System.Linq;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.BL.Models;
using Tesco.UI.Interfaces;

namespace Tesco.UI.Helpers
{
	public class ItemSortHelper : IItemSortHelper
	{
		private readonly IItemManager _itemManager;
		private readonly IItemTypeHelper _itemTypeHelper;
		private readonly IItemTypeManager _itemTypeManager;

		public ItemSortHelper()
		{
			_itemManager = new ItemManager();
			_itemTypeHelper = new ItemTypeHelper();
			_itemTypeManager = new ItemTypeManager();
		}

		public List<Item> SortItems(int sortByType, int sortByNameOrPrice)
		{
			var itemList = _itemManager.RetrieveAll<Item>();

			if (sortByType != -1)
			{
				var type = _itemTypeHelper.ItemTypeValuesHandler()[sortByType];

				itemList = itemList.Where(x => _itemTypeManager.RetrieveDataById<ItemType>((int) x.ItemTypeId).TypeDescription == type).Select(x => x).ToList();
			}

			return sortByNameOrPrice == 0
				? itemList.OrderBy(x => x.Name).ToList()
				: sortByNameOrPrice == 1
					? itemList.OrderByDescending(x => x.Name).ToList()
					: sortByNameOrPrice == 2
						? itemList.OrderBy(x => x.Price - x.Discount).ToList()
						: sortByNameOrPrice == 3
							? itemList.OrderByDescending(x => x.Price - x.Discount).ToList()
							: itemList;
		}
	}
}
