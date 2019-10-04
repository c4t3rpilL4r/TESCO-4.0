using System.Collections.Generic;
using Tesco.BL.Managers;
using Tesco.DL.Models;
using Tesco.UI.Interfaces;

namespace Tesco.UI.Utilities
{
	public class ItemTypeHandler : IItemTypeHandler
	{
		private BaseManager _itemManager, _itemTypeManager;

		public ItemTypeHandler()
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
					if (item.ItemTypeId == type.Id)
					{
						if (!itemTypeList.Contains(type.TypeDescription))
						{
							itemTypeList.Add(type.TypeDescription);
						}
					}
				}
			}

			return itemTypeList;
		}
	}
}
