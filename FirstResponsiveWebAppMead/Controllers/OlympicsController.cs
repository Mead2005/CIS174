using FirstResponsiveWebAppMead.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppMead.Controllers
{
    public class OlympicsController : Controller
    {
        public IActionResult Index()
        {
            var countries = OlympicCountryData.GetCountries()
                .OrderBy(c => c.CountryName)
                .ToList();

            return View(countries);
        }
            
        public IActionResult Filter(string game = "ALL", string category = "ALL")
        {
            var countries = OlympicCountryData.GetCountries();

            if (game != "ALL")
            {
                countries = countries
                    .Where(c => c.Game == game)
                    .ToList();
            }

            if (category != "ALL")
            {
                countries = countries
                    .Where(c => c.Category == category)
                    .ToList();
            }

            ViewBag.Game = game;
            ViewBag.Category = category;

            return View(countries.OrderBy(c => c.CountryName).ToList());
        }

        public IActionResult Details(string countryName)
        {
            var country = OlympicCountryData.GetCountries()
                .FirstOrDefault(c => c.CountryName == countryName);
            return View(country);
        }

    }

}

