using Tesco.DL.Interfaces;

namespace Tesco.DL.Repositories
{
	public class TransactionRepository : BaseRepository, ITransactionRepository
	{
		protected override string TableName => "Transactions";
	}
}
