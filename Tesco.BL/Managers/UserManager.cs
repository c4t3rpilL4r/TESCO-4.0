using Tesco.BL.Interfaces;
using Tesco.BL.Models;
using Tesco.DL.Interfaces;
using Tesco.DL.Repositories;

namespace Tesco.BL.Managers
{
	public class UserManager : BaseManager, IUserManager
	{
		protected override IRepository Repository => new UserRepository();

		public bool ValidateUserLogin(User user) => ((IUserRepository) Repository).ValidateUserLogin(user);
	}
}
