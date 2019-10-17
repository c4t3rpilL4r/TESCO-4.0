namespace Tesco.DL.Interfaces
{
	public interface IUserRepository : IRepository
	{
		bool ValidateUserLogin<T>(T user);
	}
}
