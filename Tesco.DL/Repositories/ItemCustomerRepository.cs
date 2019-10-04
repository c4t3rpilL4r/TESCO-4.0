using Tesco.DL.Interfaces;

namespace Tesco.DL.Repositories
{
    public class ItemCustomerRepository : BaseRepository, IItemCustomerRepository
    {
        protected override string TableName => "ItemCustomer";
    }
}