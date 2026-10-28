using FirstResponsiveWebAppMead.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppMead.Controllers
{
    public class OlympicsController : Controller
    {        
        public IActionResult Index(OlympicsViewModel model)
        {
            var countries = OlympicCountryData.GetCountries();

            if (model.Game != "ALL")
            {
                countries = countries
                    .Where(c => c.Game == model.Game)
                    .ToList();
            }

            if (model.Category != "ALL")
            {
                countries = countries
                    .Where(c => c.Category == model.Category)
                    .ToList();
            }

            model.Countries = countries
                .OrderBy(c => c.CountryName)
                .ToList();

            return View(model);
        }

        public IActionResult Details(string countryName)
        {
            var country = OlympicCountryData.GetCountries()
                .FirstOrDefault(c => c.CountryName == countryName);
            return View(country);
        }

    }

}

