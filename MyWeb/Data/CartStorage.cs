using MyWeb.Models;

namespace MyWeb.Data
{
    public class CartStorage
    {
        private static List<Product> cartList = new List<Product>();

        public static List<Product> GetCart()
        {
            return cartList;
        }

        public static void AddToCart(Product product)
        {
            cartList.Add(product);
        }

        public static void RemoveFromCart(int id)
        {
            var product = cartList.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                cartList.Remove(product);
            }
        }
    }
}
