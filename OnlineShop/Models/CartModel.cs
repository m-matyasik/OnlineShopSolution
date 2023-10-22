namespace OnlineShop.Models
{
    public class CartModel
    {
        public IList<ProductModel> products { get; set; }
        public double totalPrice { get; set; }

    }
}
