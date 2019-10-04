using Tesco.BL.Interfaces;
using Tesco.DL.Interfaces;
using Tesco.DL.Repositories;

namespace Tesco.BL.Managers
{
	public class OrderManager : BaseManager, IOrderManager
	{
		protected override IRepository Repository => new OrderRepository();
	}
}
