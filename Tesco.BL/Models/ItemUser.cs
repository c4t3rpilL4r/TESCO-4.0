namespace Tesco.BL.Models
{
	public class ItemUser
	{
		public int? Id { get; set; }
		public int? ItemId { get; set; }
		public int? ModifiedBy { get; set; }
		public string Modification { get; set; }
		public string DateTimeModification { get; set; }
	}
}
