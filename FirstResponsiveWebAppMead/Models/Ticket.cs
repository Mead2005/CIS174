using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppMead.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public string Description { get; set; } = "";

        [Range(1, 100)]
        public int SprintNumber { get; set; }

        [Range(1, 100)]
        public int PointValue { get; set; }

        [Required]
        public string Status { get; set; } = "To Do";
    }
}
