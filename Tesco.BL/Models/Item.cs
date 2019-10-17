namespace Tesco.BL.Models
{
	public class Item
	{
		public int? Id { get; set; }
		public string Name { get; set; }
		public int? ItemTypeId { get; set; }
		public int? Discount { get; set; }
		public int? Price { get; set; }
		public int? Stocks { get; set; }
		public bool? IsDeleted { get; set; }
	}
}
