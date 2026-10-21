using System.Collections.Generic;

namespace FirstResponsiveWebAppMead.Models
{
    public static class OlympicCountryData
    {
        public static List<OlympicCountry> GetCountries()
        {
            return new List<OlympicCountry>
            {
                new OlympicCountry
                { CountryName = "Austria", FlagImage = "/images/flags/w320/at.png", Game = "Paralympics", Category = "Canoe Sprint" },
                new OlympicCountry
                { CountryName = "Brazil", FlagImage = "/images/flags/w320/br.png", Game = "Summer Olympics", Category = "Road Cycling" },
                new OlympicCountry
                { CountryName = "Canada", FlagImage = "/images/flags/w320/ca.png", Game = "Winter Olympics", Category = "Curling" },
                new OlympicCountry
                { CountryName = "China", FlagImage = "/images/flags/w320/cn.png", Game = "Summer Olympics", Category = "Diving" },
                new OlympicCountry
                { CountryName = "Cyprus", FlagImage = "/images/flags/w320/cy.png", Game = "Youth Olympic Games", Category = "Breakdancing" },
                new OlympicCountry
                { CountryName = "Finland", FlagImage = "/images/flags/w320/fi.png", Game = "Youth Olympic Games", Category = "Skateboarding" },
                new OlympicCountry
                { CountryName = "France", FlagImage = "/images/flags/w320/fr.png", Game = "Youth Olympic Games", Category = "Breakdancing" },
                new OlympicCountry
                { CountryName = "Germany", FlagImage = "/images/flags/w320/de.png", Game = "Summer Olympics", Category = "Diving" },
                new OlympicCountry
                { CountryName = "Great Britain", FlagImage = "/images/flags/w320/gb.png", Game = "Winter Olympics", Category = "Curling" },
                new OlympicCountry
                { CountryName = "Italy", FlagImage = "/images/flags/w320/it.png", Game = "Winter Olympics", Category = "Bobsleigh" },
                new OlympicCountry
                { CountryName = "Jamaica", FlagImage = "/images/flags/w320/jm.png", Game = "Winter Olympics", Category = "Bobsleigh" },
                new OlympicCountry
                { CountryName = "Japan", FlagImage = "/images/flags/w320/jp.png", Game = "Winter Olympics", Category = "Bobsleigh" },
                new OlympicCountry
                { CountryName = "Mexico", FlagImage = "/images/flags/w320/mx.png", Game = "Summer Olympics", Category = "Diving" },
                new OlympicCountry
                { CountryName = "Netherlands", FlagImage = "/images/flags/w320/nl.png", Game = "Summer Olympics", Category = "Cycling" },
                new OlympicCountry
                { CountryName = "Pakistan", FlagImage = "/images/flags/w320/pk.png", Game = "Paralympics", Category = "Canoe Sprint" },
                new OlympicCountry
                { CountryName = "Portugal", FlagImage = "/images/flags/w320/pt.png", Game = "Youth Olympic Games", Category = "Skateboarding" },
                new OlympicCountry
                { CountryName = "Russia", FlagImage = "/images/flags/w320/ru.png", Game = "Youth Olympic Games", Category = "Breakdancing" },
                new OlympicCountry
                { CountryName = "Slovakia", FlagImage = "/images/flags/w320/sk.png", Game = "Youth Olympic Games", Category = "Skateboarding" },
                new OlympicCountry
                { CountryName = "Sweden", FlagImage = "/images/flags/w320/se.png", Game = "Winter Olympics", Category = "Curling" },
                new OlympicCountry
                { CountryName = "Thailand", FlagImage = "/images/flags/w320/th.png", Game = "Paralympics", Category = "Archery" },
                new OlympicCountry
                { CountryName = "Ukraine", FlagImage = "/images/flags/w320/ua.png", Game = "Paralympics", Category = "Archery" },
                new OlympicCountry
                { CountryName = "United States", FlagImage = "/images/flags/w320/us.png", Game = "Summer Olympics", Category = "Road Cycling" },
                new OlympicCountry
                { CountryName = "Uruguay", FlagImage = "/images/flags/w320/uy.png", Game = "Paralympics", Category = "Archery" },
                new OlympicCountry
                { CountryName = "Zimbabwe", FlagImage = "/images/flags/w320/zw.png", Game = "Paralympics", Category = "Canoe Sprint" }
            };
        }
    }
}