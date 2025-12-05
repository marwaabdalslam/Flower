namespace FlowerShop.Models
{
    public class StockTransaction
    {
        public int Id { get; set; }
        public int ProductId { get; set; } // رقم فقط
        public int ChangeQty { get; set; }
        public string Type { get; set; }  // inbound / outbound
        public int RefId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
