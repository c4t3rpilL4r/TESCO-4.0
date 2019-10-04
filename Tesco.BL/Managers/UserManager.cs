using System.Linq;
using Tesco.BL.Interfaces;
using Tesco.DL.Interfaces;
using Tesco.DL.Models;
using Tesco.DL.Repositories;

namespace Tesco.BL.Managers
{
	public class UserManager : BaseManager, IUserManager
	{
		protected override IRepository Repository => new UserRepository();

		public bool ValidateUserLogin(User user) => ((IUserRepository) Repository).ValidateUserLogin(user);
		
		public int Delete(int id)
		{
			var data = Repository.RetrieveDataById<User>(id);

			data.IsDeleted = true;
			
			return Repository.Update(data);
		}
	}
}
