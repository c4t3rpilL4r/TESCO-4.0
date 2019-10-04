using Tesco.BL.Interfaces;
using Tesco.DL.Interfaces;
using Tesco.DL.Models;
using Tesco.DL.Repositories;

namespace Tesco.BL.Managers
{
	public class ItemTypeManager : BaseManager, IItemTypeManager
	{
		protected override IRepository Repository => new ItemTypeRepository();
		
		public int Delete(int id)
		{
			var data = Repository.RetrieveDataById<ItemType>(id);

			data.IsDeleted = true;
			
			return Repository.Update(data);
		}
	}
}
