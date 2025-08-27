using MyWeb.Models;

namespace MyWeb.Data
{
    public class ProductStorage
    {
        private static List<Product> products = new List<Product>
        {
            new Product {Id = 1, Name = "Laptop", Description = "Laptop mạnh mẽ cho lập trình viên", Price = 1200},
            new Product {Id = 2, Name = "Điện thoại", Description = "Điện thoại này xịn", Price = 800},
            new Product {Id = 3, Name = "Tai nghe", Description = "Tai nghe không dây kết nối từ xa", Price = 100},
            new Product {Id = 4, Name = "Túi chống sốc", Description = "Bảo vệ laptop", Price = 50},
            new Product {Id = 5, Name = "Máy ảnh", Price = 1200, Description = "Máy ảnh chuyên nghiệp" }
        };

        public static List<Product> getListProducts()
        {
            return products;
        }

        public static Product getProductById(int id)
        {
            return products[id - 1];
        }
    }
}
