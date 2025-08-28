using Microsoft.AspNetCore.Mvc;
using MyWeb.Data;
using MyWeb.Models;

namespace MyWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = ProductStorage.getListProducts();
            return View(products);
        }

        public IActionResult Detail(int id)
        {
            var product = ProductStorage.getProductById(id);
            return View(product);
        }

        public IActionResult AddToCart(int id)
        {
            var products = ProductStorage.getListProducts();
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                CartStorage.AddToCart(product);
            }
            return RedirectToAction("Index", "Cart");
        }
    }
}
