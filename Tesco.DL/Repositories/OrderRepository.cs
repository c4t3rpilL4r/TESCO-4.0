using Tesco.DL.Interfaces;

namespace Tesco.DL.Repositories
{
	public class OrderRepository : BaseRepository, IOrderRepository
	{
		protected override string TableName => "Orders";
	}
}
