namespace Tesco.DL.Models
{
    public class ItemCustomer
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }
        public bool? IsCurrentOrder { get; set; }
        public bool? IsUnpaid { get; set; }
    }
}