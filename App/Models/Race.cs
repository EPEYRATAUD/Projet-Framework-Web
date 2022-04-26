
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Race
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime EventDate { get; set; }
        public TimeOnly StartHour { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public int MaxEntryAmount { get; set; }
        public string? Image { get; set; }
        public int DriversArrayID { get; set; }
        public int MinAge { get; set; }
        public int ResultArrayID { get; set; }
        public int RaceCategoryArrayID { get; set; }
    }
}