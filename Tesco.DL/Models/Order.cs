using System;

namespace Tesco.DL.Models
{
	public class Order
	{
		public int Id { get; set; }
		public int TransactionId { get; set; }
		public int OrderCustomerId { get; set; }
	}
}
