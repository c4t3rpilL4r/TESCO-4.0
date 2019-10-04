namespace Tesco.DL.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string FullName { get; set; }
		public int CustomerId { get; set; }
		public string Type { get; set; }
		public bool? IsDeleted { get; set; }
	}
}
