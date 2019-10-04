using Tesco.DL.Interfaces;
using Tesco.DL.Models;

namespace Tesco.DL.Repositories
{
	public class UserRepository : BaseRepository, IUserRepository
	{
		protected override string TableName => "Users";

		public bool ValidateUserLogin(User user) => RetrieveDataByWhereCondition(user) != null;
	}
}
