using Tesco.DL.Interfaces;

namespace Tesco.DL.Repositories
{
	public class ItemUserRepository : BaseRepository, IItemUserRepository
	{
		protected override string TableName => "ItemUser";
	}
}
