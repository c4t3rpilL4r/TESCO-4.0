﻿namespace Tesco.BL.Models
{
	public class Order
	{
		public int? Id { get; set; }
		public int? TransactionId { get; set; }
		public int? CustomerId { get; set; }
		public int? ItemId { get; set; }
		public int? Quantity { get; set; }
		public int? Amount { get; set; }
		public bool? IsUnpaid { get; set; }
		public bool? IsCancelled { get; set; }
	}
}
