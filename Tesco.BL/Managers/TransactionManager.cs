using Tesco.BL.Interfaces;
using Tesco.DL.Interfaces;
using Tesco.DL.Repositories;

namespace Tesco.BL.Managers
{
	public class TransactionManager : BaseManager, ITransactionManager
	{
		protected override IRepository Repository => new TransactionRepository();
	}
}
