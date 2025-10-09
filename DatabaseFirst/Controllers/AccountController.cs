using DatabaseFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseFirst.Controllers
{
    public class AccountController : Controller
    {
        private readonly BookStoreContext _context;

        public AccountController(BookStoreContext context)
        {
            _context = context;
        }

        // GET: /Account/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        public IActionResult Register(Account acc)
        {
            ModelState.Remove("AccountId");
            ModelState.Remove("IsAdmin");
            ModelState.Remove("Active");

            if (ModelState.IsValid)
            {
                if (_context.Accounts.Any(a => a.Username == acc.Username))
                {
                    ViewBag.Error = "Tên đăng nhập đã tồn tại!";

                    return View(acc);
                }

                acc.AccountId = Guid.NewGuid().ToString();
                acc.Active = true;
                acc.IsAdmin = false;

                _context.Accounts.Add(acc);
                _context.SaveChanges();

                ViewBag.Success = "Đăng ký thành công!";
                return RedirectToAction("Login");
            }
            return View(acc);
        }

        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _context.Accounts.FirstOrDefault(a => a.Username == username && a.Password == password);

            if (user != null)
            {
                HttpContext.Session.SetString("Username", user.Username);
                HttpContext.Session.SetString("FullName", user.FullName ?? "");
                HttpContext.Session.SetString("IsAdmin", user.IsAdmin.ToString());
                return RedirectToAction("Index", "Books");
            }

            ViewBag.Error = "Sai tên đăng nhập hoặc mật khẩu!";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
