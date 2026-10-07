using FirstResponsiveWebAppMead.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppMead.Controllers
{
    public class Assignment61Controller : Controller
    {
        [Route("Assignment61/{accessLevel:int}")]
        public IActionResult Index(int accessLevel)
        {
            if (accessLevel < 1 || accessLevel > 10)
            {
                return BadRequest("Access level must be between 1 and 10.");
            }

            var students = new List<Student>
            {
                new Student { FirstName = "Ron", LastName = "Oxford", Grade = 92 },
                new Student { FirstName = "Brandon", LastName = "Bishop", Grade = 87 },
                new Student { FirstName = "Warren", LastName = "Mead", Grade = 95 },
                new Student { FirstName = "Austin", LastName = "Kidder", Grade = 81 }
            };

            var viewModel = new StudentViewModel
            {
                Students = students,
                AccessLevel = accessLevel
            };

            return View(viewModel);
        }
    }
}
