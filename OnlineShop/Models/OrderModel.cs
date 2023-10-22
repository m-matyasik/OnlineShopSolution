namespace OnlineShop.Models
{
    public class OrderModel
    {
        public int orderId { get; set; }
        public Shipping shipping { get; }
        public OrderStatus orderStatus { get; set; } = 0;
    }
}
