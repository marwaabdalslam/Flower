namespace FlowerShop.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; } // رقم فقط
        public string Method { get; set; }
        public string Status { get; set; }
        public decimal Amount { get; set; }
        public string TransactionId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
