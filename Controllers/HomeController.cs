using Microsoft.AspNetCore.Mvc;
using sports_stats_webApp.Models;
using System.Diagnostics;

namespace sports_stats_webApp.Controllers
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

        public IActionResult NBA()
        {
            return View();
        }

        public IActionResult MLB()
        {
            return View();
        }

        public IActionResult NFL()
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
