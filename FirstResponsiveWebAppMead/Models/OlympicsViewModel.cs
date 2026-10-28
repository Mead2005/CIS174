namespace FirstResponsiveWebAppMead.Models
{
    public class OlympicsViewModel
    {
        public string Game { get; set; } = "ALL";
        public string Category { get; set; } = "ALL";

        public List<OlympicCountry> Countries { get; set; } = new();
    }
}
