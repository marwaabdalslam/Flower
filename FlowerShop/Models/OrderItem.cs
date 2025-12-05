namespace FlowerShop.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }     // رقم فقط
        public int ProductId { get; set; }   // رقم فقط
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
