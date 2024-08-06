using System.ComponentModel.DataAnnotations;

namespace Mvc_Project.Models
{
    public class Insuree
    {
        public int InsureeId { get; set; }

        [Required]
        [Range(0, 120, ErrorMessage = "Please enter a valid age.")]
        public int Age { get; set; }

        [Required]
        [Range(1886, int.MaxValue, ErrorMessage = "Please enter a valid car year.")]
        public int CarYear { get; set; }

        [Required]
        public string CarMake { get; set; }

        [Required]
        public string CarModel { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number of speeding tickets.")]
        public int SpeedingTickets { get; set; }

        [Required]
        public bool DUI { get; set; }

        [Required]
        public bool FullCoverage { get; set; }

        public decimal Quote { get; set; }
    }
}
