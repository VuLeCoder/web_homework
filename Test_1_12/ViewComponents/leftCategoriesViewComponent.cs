using Microsoft.AspNetCore.Mvc;
using Test_1_12.Models;

namespace Test_1_12.ViewComponents
{
    public class leftCategoriesViewComponent : ViewComponent
    {
        public readonly ShopDbContext _context;

        public leftCategoriesViewComponent(ShopDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }
    }
}
