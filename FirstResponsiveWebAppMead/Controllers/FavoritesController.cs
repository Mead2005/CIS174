using FirstResponsiveWebAppMead.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppMead.Controllers
{
    public class FavoritesController : Controller
    {
        private const string FavoritesKey = "FavoriteCountries";

        public IActionResult Index()
        {
            var favoriteNames = HttpContext.Session
                .GetObject<List<string>>(FavoritesKey) ?? new List<string>();

            var countries = OlympicCountryData.GetCountries()
                .Where(c => favoriteNames.Contains(c.CountryName))
                .OrderBy(c => c.CountryName)
                .ToList();

            return View(countries);
        }

        [HttpPost]
        public IActionResult Add(string countryName)
        {
            var countryExists = OlympicCountryData.GetCountries()
                .Any(c => c.CountryName == countryName);

            var favorites = HttpContext.Session
                .GetObject<List<string>>(FavoritesKey) ?? new List<string>();

            if (!favorites.Contains(countryName))
            {
                favorites.Add(countryName);
                HttpContext.Session.SetObject(FavoritesKey, favorites);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Clear()
        {
            HttpContext.Session.Remove(FavoritesKey);
            return RedirectToAction("Index");
        }
    }
}
