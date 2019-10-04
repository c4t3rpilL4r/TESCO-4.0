using System;

namespace Tesco.DL.Models
{
	public class Transaction
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public int CashOnHand { get; set; }
		public DateTime TransactDateTime { get; set; }
	}
}
