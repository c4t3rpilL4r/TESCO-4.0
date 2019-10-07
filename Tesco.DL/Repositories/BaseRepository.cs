using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Tesco.DL.Interfaces;
using Tesco.DL.Models;

namespace Tesco.DL.Repositories
{
	public abstract class BaseRepository : IRepository
	{
		protected abstract string TableName { get; }

		private readonly IDbConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["Tesco.UI.Properties.Settings.DBTesco"].ConnectionString);

		public int Add<T>(T data)
		{
			var propertyToBeExcludedFields = new List<string>();
			var propertyToBeExcludedValues = new List<string>();
			
			var fields = string.Join(",", data.GetType().GetProperties().Where(x =>
			{
				var propertyName = $"{x.Name}".ToLower();

				if (x.GetValue(data) == null || x.GetValue(data).ToString().Equals("0"))
				{
					propertyToBeExcludedFields.Add(propertyName);
				}
				
				return !propertyToBeExcludedFields.Contains(value: propertyName);
			}).Select(x => $"{x.Name}"));

			var values = string.Join(",", data.GetType().GetProperties().Where(x =>
			{
				var propertyName = $"{x.Name}".ToLower();
				
				if (x.GetValue(data) == null || x.GetValue(data).ToString().Equals("0"))
				{
					propertyToBeExcludedValues.Add(propertyName);
				}
				
				return !propertyToBeExcludedValues.Contains(value: propertyName);
			}).Select(x => $"@{x.Name}"));
			return _db.Query<int>($@"INSERT INTO {TableName} ({fields}) VALUES ({values}) SELECT CAST(SCOPE_IDENTITY() as int);", data).Single();
		}

		//public int Delete(int id) => _db.Execute(sql: $"DELETE FROM {TableName} WHERE Id = '{id}';");

		public List<T> RetrieveAll<T>() => _db.Query<T>($"SELECT * FROM {TableName};").ToList();

		public T RetrieveDataById<T>(int id) => _db.Query<T>($"SELECT * FROM {TableName} WHERE Id = '{id}';").SingleOrDefault();

		public T RetrieveDataByWhereCondition<T>(T data)
		{
			var propertyToBeExcluded = new List<string>();
			
			var condition = string.Join(" AND ", data.GetType().GetProperties().Where(x =>
			{
				var propertyName = $"{x.Name}".ToLower();

				if (x.GetValue(data) == null || x.GetValue(data).ToString().Equals("0"))
				{
					propertyToBeExcluded.Add(propertyName);
				}

				return !propertyToBeExcluded.Contains(value: propertyName);
			}).Select(x => $"{x.Name} = @{x.Name}"));
			
			return _db.Query<T>($"SELECT * FROM {TableName} WHERE {condition};", data).SingleOrDefault();
		}

		public int Update<T>(T data)
		{
			var propertyToBeExcluded = new List<string>() { "id" };

			var fields = string.Join(",", data.GetType().GetProperties().Where(x =>
			{
				var propertyName = $"{x.Name}".ToLower();

				if (x.GetValue(data) == null || x.GetValue(data).ToString().Equals("0"))
				{
					propertyToBeExcluded.Add(propertyName);
				}

				return !propertyToBeExcluded.Contains(value: propertyName);
			}).Select(x => $"{x.Name} = @{x.Name}"));

			return _db.Execute($@"UPDATE {TableName} SET {fields} WHERE Id = @Id", data);
		}
	}
}
