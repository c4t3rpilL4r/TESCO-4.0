using System.Collections.Generic;
using System.Linq;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.DL.Models;
using Tesco.UI.Interfaces;

namespace Tesco.UI.Utilities
{
	public class SortHandler : ISortHandler
	{
		private readonly IItemManager _itemManager;
		private readonly IItemTypeManager _itemTypeManager;
		private readonly IItemTypeHandler _itemTypeHandler;

		public SortHandler()
		{
			_itemManager = new ItemManager();
			_itemTypeManager = new ItemTypeManager();
			_itemTypeHandler = new ItemTypeHandler();
		}

		public List<Item> SortItems(int sortByType, int sortByNameOrPrice)
		{
			var itemList = _itemManager.RetrieveAll<Item>();

			if (sortByType != -1)
			{
				var type = _itemTypeHandler.ItemTypeValuesHandler()[sortByType];

				itemList = itemList.Where(x => _itemTypeManager.RetrieveDataById<ItemType>(x.ItemTypeId).TypeDescription == type).Select(x => x).ToList();
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
