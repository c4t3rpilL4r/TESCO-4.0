using Tesco.BL.Interfaces;
using Tesco.DL.Interfaces;
using Tesco.DL.Models;
using Tesco.DL.Repositories;

namespace Tesco.BL.Managers
{
	public class ItemManager : BaseManager, IItemManager
	{
		protected override IRepository Repository => new ItemRepository();
		
		public int Delete(int id)
		{
			var data = Repository.RetrieveDataById<Item>(id);

			data.IsDeleted = true;
			
			return Repository.Update(data);
		}
	}
}
