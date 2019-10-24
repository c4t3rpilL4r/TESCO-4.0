using System.Collections.Generic;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.BL.Models;
using Tesco.UI.Interfaces;

namespace Tesco.UI.Helpers
{
	public class ItemTypeHelper : IItemTypeHelper
	{
		private readonly IItemManager _itemManager;
		private readonly IItemTypeManager _itemTypeManager;

		public ItemTypeHelper()
		{
			_itemManager = new ItemManager();
			_itemTypeManager = new ItemTypeManager();
		}

		public List<string> ItemTypeValuesHandler()
		{
			var itemTypeList = new List<string>();

			foreach (var item in _itemManager.RetrieveAll<Item>())
			{
				foreach (var type in _itemTypeManager.RetrieveAll<ItemType>())
				{
					if (item.ItemTypeId == type.Id && !itemTypeList.Contains(type.TypeDescription))
					{
						itemTypeList.Add(type.TypeDescription);
					}
				}
			}

			return itemTypeList;
		}
	}
}
