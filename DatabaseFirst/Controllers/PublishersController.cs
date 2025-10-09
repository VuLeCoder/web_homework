using Microsoft.AspNetCore.Mvc;
using DatabaseFirst.Models;
using System.Linq;

namespace DatabaseFirst.Controllers
{
    public class PublishersController : Controller
    {
        private readonly BookStoreContext _context;

        public PublishersController(BookStoreContext context)
        {
            _context = context;
        }

        // GET: Publishers
        public IActionResult Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
            {
                return RedirectToAction("Login", "Account");
            }

            var publishers = _context.Publishers.ToList();
            return View(publishers);
        }

        // GET: Publishers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Publishers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Publisher publisher)
        {
            if (ModelState.IsValid)
            {
                _context.Publishers.Add(publisher);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(publisher);
        }

        // GET: Publishers/Edit/5
        public IActionResult Edit(int id)
        {
            var publisher = _context.Publishers.Find(id);
            if (publisher == null)
                return NotFound();

            return View(publisher);
        }

        // POST: Publishers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Publisher publisher)
        {
            if (id != publisher.PublisherId)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(publisher);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(publisher);
        }

        // GET: Publishers/Delete/5
        public IActionResult Delete(int id)
        {
            var publisher = _context.Publishers.Find(id);
            if (publisher == null)
                return NotFound();

            _context.Publishers.Remove(publisher);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
