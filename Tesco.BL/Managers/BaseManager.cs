using System.Collections.Generic;
using Tesco.BL.Interfaces;
using Tesco.DL.Interfaces;

namespace Tesco.BL.Managers
{
	public abstract class BaseManager : IManager
	{
		protected abstract IRepository Repository { get; }

		public int Add<T>(T data) => Repository.Add(data);

		public int Delete<T>(int id)
		{
			var data = RetrieveDataById<T>(id);

			return Update<T>(data);
		}

		public List<T> RetrieveAll<T>() => Repository.RetrieveAll<T>();

		public T RetrieveDataByWhereCondition<T>(T data) => Repository.RetrieveDataByWhereCondition<T>(data);

		public T RetrieveDataById<T>(int id) => Repository.RetrieveDataById<T>(id);

		public int Update<T>(T data) => Repository.Update(data);
	}
}
