namespace FlowerShop.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }  // رقم فقط
        public DateTime CreatedAt { get; set; }
    }
}
