using Tesco.DL.Interfaces;

namespace Tesco.DL.Repositories
{
	public class ItemRepository : BaseRepository, IItemRepository
	{
		protected override string TableName => "Items";
	}
}
