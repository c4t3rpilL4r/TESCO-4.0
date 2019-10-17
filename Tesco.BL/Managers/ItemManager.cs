using Tesco.BL.Interfaces;
using Tesco.DL.Interfaces;
using Tesco.DL.Repositories;

namespace Tesco.BL.Managers
{
	public class ItemManager : BaseManager, IItemManager
	{
		protected override IRepository Repository => new ItemRepository();
	}
}
