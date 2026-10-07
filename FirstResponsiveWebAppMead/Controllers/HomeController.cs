using FirstResponsiveWebAppMead.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstResponsiveWebAppMead.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AgeCalculator()
        {
            return View("~/Views/AgeCalculator/Index.cshtml");
        }

        [HttpPost]
        public IActionResult AgeCalculator(Person person)
        {
            if (person.BirthYear <= 0)
            {
                ModelState.AddModelError("BirthYear", "Enter birth year.");
            }

            return View("~/Views/AgeCalculator/Index.cshtml", person);
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
