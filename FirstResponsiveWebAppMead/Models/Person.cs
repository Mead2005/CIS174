using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppMead.Models
{
    public class Person
    {
        public string Name { get; set; } = "";

        public int BirthYear { get; set; }

        const int CurrentYear = 2026;

        public int AgeThisYear()
        {
            return CurrentYear - BirthYear;
        }
    }
}
