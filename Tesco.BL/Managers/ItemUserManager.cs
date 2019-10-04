using Tesco.BL.Interfaces;
using Tesco.DL.Interfaces;
using Tesco.DL.Repositories;

namespace Tesco.BL.Managers
{
	public class ItemUserManager : BaseManager, IItemUserManager
	{
		protected override IRepository Repository => new ItemUserRepository();
	}
}
