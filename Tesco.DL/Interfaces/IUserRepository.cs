using Tesco.DL.Models;

namespace Tesco.DL.Interfaces
{
	public interface IUserRepository : IRepository
	{
		bool ValidateUserLogin(User user);
	}
}
