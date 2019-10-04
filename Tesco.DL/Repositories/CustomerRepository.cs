using Tesco.DL.Interfaces;

namespace Tesco.DL.Repositories
{
	public class CustomerRepository : BaseRepository, ICustomerRepository
	{
		protected override string TableName => "Customers";
	}
}
