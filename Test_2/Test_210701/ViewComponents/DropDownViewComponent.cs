using Microsoft.AspNetCore.Mvc;
using Test_210701.Models;

namespace Test_210701.ViewComponents
{
    public class DropDownViewComponent : ViewComponent
    {
        private readonly ShopDbContext _shopDbContext;

        public DropDownViewComponent(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _shopDbContext.Categories.ToList();
            return View(categories);
        }
    }
}
