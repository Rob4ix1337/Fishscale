using FishApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FishApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        [HttpGet]
        public IActionResult Photo()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Profile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login()
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Exit()
        {
            return View("login");
        }
    }
}