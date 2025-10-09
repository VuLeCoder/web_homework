using Microsoft.AspNetCore.Mvc;
using DatabaseFirst.Models;
using System.Linq;

namespace DatabaseFirst.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly BookStoreContext _context;

        public CategoriesController(BookStoreContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
            {
                return RedirectToAction("Login", "Account");
            }

            return View(_context.Categories.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        public IActionResult Edit(int id)
        {
            var cat = _context.Categories.Find(id);
            if (cat == null) return NotFound();
            return View(cat);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Category category)
        {
            if (id != category.CategoryId) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(category);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }

        public IActionResult Delete(int id)
        {
            var cat = _context.Categories.Find(id);
            if (cat == null) return NotFound();

            _context.Categories.Remove(cat);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
