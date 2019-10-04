using System.Collections.Generic;

namespace Tesco.BL.Interfaces
{
	public interface IManager
	{
		int Add<T>(T data);
//		int Delete<T>(int id);
		List<T> RetrieveAll<T>();
		T RetrieveDataById<T>(int id);
		T RetrieveDataByWhereCondition<T>(T data);
		int Update<T>(T data);
	}
}
