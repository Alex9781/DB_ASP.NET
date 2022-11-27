using DB_ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace DB_ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}