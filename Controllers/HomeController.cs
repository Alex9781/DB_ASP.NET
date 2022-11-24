using DB_ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace DB_ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext _context;

        public HomeController(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public List<User> Users()
        {
            return _context.Users.ToList();
        }

        public List<Movie> Movies()
        {
            return _context.Movies.ToList();
        }
    }
}