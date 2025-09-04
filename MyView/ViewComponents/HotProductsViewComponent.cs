using Microsoft.AspNetCore.Mvc;
using MyView.Models;

namespace MyView.ViewComponents
{
    public class HotProductsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var products = new List<Product>
            {
                new Product{Id=4, Name="Nồi cơm điện cao tần Nagakawa NAG0102", Image="/images/noicom.jpg"},
                new Product{Id=5, Name="Nồi cơm điện cao tần Nagakawa NAG0102", Image="/images/noicom.jpg"},
                new Product{Id=6, Name="Nồi cơm điện cao tần Nagakawa NAG0102", Image="/images/noicom.jpg"},
            };
            return View(products);
        }
    }
}
