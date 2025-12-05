namespace FlowerShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; } // رقم فقط بدون علاقة
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } // pending, paid, shipped...
        public DateTime CreatedAt { get; set; }
    }
}
