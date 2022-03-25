
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Race
    {
        [Required(ErrorMessage = "Tu t'es gouré chef")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tu t'es gouré chef")]
        public string? Name { get; set; }
        public DateOnly EventDate { get; set; }
    }
}