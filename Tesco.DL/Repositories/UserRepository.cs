using Tesco.DL.Interfaces;

namespace Tesco.DL.Repositories
{
	public class UserRepository : BaseRepository, IUserRepository
	{
		protected override string TableName => "Users";

		public bool ValidateUserLogin<T>(T user) => RetrieveDataByWhereCondition(user) != null;
	}
}
