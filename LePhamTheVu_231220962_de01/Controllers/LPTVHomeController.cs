using System.Diagnostics;
using LePhamTheVu_231220962_de01.Models;
using Microsoft.AspNetCore.Mvc;

namespace LePhamTheVu_231220962_de01.Controllers
{
    public class LPTVHomeController : Controller
    {
        private readonly ILogger<LPTVHomeController> _logger;

        public LPTVHomeController(ILogger<LPTVHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult lptvIndex()
        {
            return View();
        }

        public IActionResult lptvPrivacy()
        {
            return View();
        }

        public IActionResult lptvContact()
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
