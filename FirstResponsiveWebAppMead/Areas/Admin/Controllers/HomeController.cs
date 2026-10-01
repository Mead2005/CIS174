using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppMead.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}
