using System.Collections.Generic;

namespace Tesco.DL.Interfaces
{
	public interface IRepository
	{
		int Add<T>(T data);
		//int Delete(int id);
		List<T> RetrieveAll<T>();
		T RetrieveDataById<T>(int id);
		T RetrieveDataByWhereCondition<T>(T data);
		int Update<T>(T data);
	}
}
