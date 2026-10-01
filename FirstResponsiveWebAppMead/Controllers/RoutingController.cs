using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppMead.Controllers
{
    public class RoutingController : Controller
    {
        public IActionResult Default()
        {
            return View();
        }

        [Route("custom-page")]
        public IActionResult Custom()
        {
            return View();
        }

        [HttpGet("attribute-page")]
        public IActionResult Attribute()
        {
            return View();
        }
    }
}
