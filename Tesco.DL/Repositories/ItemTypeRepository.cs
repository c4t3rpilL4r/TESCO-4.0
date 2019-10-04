using Tesco.DL.Interfaces;

namespace Tesco.DL.Repositories
{
	public class ItemTypeRepository : BaseRepository, IItemTypeRepository
	{
		protected override string TableName => "ItemTypes";
	}
}
