using Tesco.BL.Interfaces;
using Tesco.DL.Interfaces;
using Tesco.DL.Repositories;

namespace Tesco.BL.Managers
{
	public class ItemTypeManager : BaseManager, IItemTypeManager
	{
		protected override IRepository Repository => new ItemTypeRepository();
	}
}
