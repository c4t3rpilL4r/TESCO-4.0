using Tesco.BL.Models;

namespace Tesco.BL.Interfaces
{
	public interface IUserManager : IManager
	{
		bool ValidateUserLogin(User user);
	}
}
