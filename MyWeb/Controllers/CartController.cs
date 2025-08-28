using Microsoft.AspNetCore.Mvc;
using MyWeb.Data;

namespace MyWeb.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var cart = CartStorage.GetCart();
            return View(cart);
        }

        public IActionResult Remove(int id)
        {
            CartStorage.RemoveFromCart(id);
            return RedirectToAction("Index");
        }
    }
}
