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
    }
}
