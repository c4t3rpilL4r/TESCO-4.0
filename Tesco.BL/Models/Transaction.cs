using System;

namespace Tesco.BL.Models
{
	public class Transaction
	{
		public int? Id { get; set; }
		public int? CashOnHand { get; set; }
		public DateTime TransactDateTime { get; set; }
	}
}
