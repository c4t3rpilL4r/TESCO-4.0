using System.Linq;
using Tesco.BL.Interfaces;
using Tesco.DL.Interfaces;
using Tesco.DL.Models;
using Tesco.DL.Repositories;

namespace Tesco.BL.Managers
{
	public class CustomerManager : BaseManager, ICustomerManager
	{
		protected override IRepository Repository => new CustomerRepository();
	}
}
