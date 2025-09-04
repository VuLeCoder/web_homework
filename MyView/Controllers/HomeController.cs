using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyView.Models;

namespace MyView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product{Id=1, Name="Nồi cơm điện cao tần Nagakawa NAG0102", Image="/images/noicom.jpg"},
                new Product{Id=2, Name="Nồi cơm điện cao tần Nagakawa NAG0102", Image="/images/noicom.jpg"},
                new Product{Id=2, Name="Nồi cơm điện cao tần Nagakawa NAG0102", Image="/images/noicom.jpg"},
            };
            return View(products);
        }

        public PartialViewResult ProductCategories()
        {
            var catalog = new List<string> {
                "Áo dài",
                "Áo đông",
                "Túi xách",
                "Đồng hồ",
                "Ví da",
                "Thắt lưng da",
                "Tủ lạnh",
                "Tivi",
                "Quạt điện",
                "Lò sưởi"
            };
            return PartialView(catalog);
        }
    }
}
