using Microsoft.AspNetCore.Mvc;
using DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DatabaseFirst.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookStoreContext _context;

        public BooksController(BookStoreContext context)
        {
            _context = context;
        }

        // GET: Books
        public IActionResult Index()
        {
            var books = _context.Books
                .Include(b => b.Publisher)
                .Include(b => b.Category)
                .ToList();

            return View(books);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            ViewBag.Publishers = _context.Publishers.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Books.Add(book);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Publishers = _context.Publishers.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            return View(book);
        }

        // GET: Books/Edit/5
        public IActionResult Edit(string id)
        {
            var book = _context.Books.Find(id);
            if (book == null) return NotFound();

            ViewBag.Publishers = _context.Publishers.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            return View(book);
        }

        // POST: Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, Book book)
        {
            if (id != book.BookId) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(book);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Publishers = _context.Publishers.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            return View(book);
        }

        // GET: Books/Delete/5
        public IActionResult Delete(string id)
        {
            var book = _context.Books.Find(id);
            if (book == null) return NotFound();

            _context.Books.Remove(book);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
