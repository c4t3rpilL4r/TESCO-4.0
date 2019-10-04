using Tesco.BL.Interfaces;
using Tesco.DL.Interfaces;
using Tesco.DL.Repositories;

namespace Tesco.BL.Managers
{
    public class OrderCustomerManager : BaseManager, IOrderCustomerManager
    {
        protected override IRepository Repository => new OrderCustomerRepository();
    }
}