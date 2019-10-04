using Tesco.BL.Interfaces;
using Tesco.DL.Interfaces;
using Tesco.DL.Repositories;

namespace Tesco.BL.Managers
{
    public class ItemCustomerManager : BaseManager, IItemCustomerManager
    {
        protected override IRepository Repository => new ItemCustomerRepository();
    }
}