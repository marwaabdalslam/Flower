namespace FlowerShop.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }      // رقم فقط
        public int ProductId { get; set; }   // رقم فقط
        public int Quantity { get; set; }
    }
}
