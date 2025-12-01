using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Test_1_12.Models;

namespace Test_1_12.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ShopDbContext _context;

        public HomeController(ILogger<HomeController> logger, ShopDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(int? Id)
        {
            var query = _context.Products.Where(p => p.Available == true && p.UnitPrice <= 1000).AsQueryable();
            if(Id is not null)
            {
                query = query.Where(p => p.CategoryId == Id);
            }
            var productList = query.ToList();
            return View("Vuz_MainContent", productList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
