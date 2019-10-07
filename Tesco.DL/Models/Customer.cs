namespace Tesco.DL.Models
{
	public class Customer : User
	{
		public new int Id { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public bool? IsGuest { get; set; }
	}
}
