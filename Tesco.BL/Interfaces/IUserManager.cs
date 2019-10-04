using Tesco.DL.Models;

namespace Tesco.BL.Interfaces
{
	public interface IUserManager : IManager, IDeleteHandler
	{
		bool ValidateUserLogin(User user);
	}
}
