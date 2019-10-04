using Tesco.DL.Interfaces;

namespace Tesco.DL.Repositories
{
    public class OrderCustomerRepository : BaseRepository, IOrderCustomerRepository
    {
        protected override string TableName => "OrderCustomer";
    }
}