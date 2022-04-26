using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class Driver
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly Birthdate { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int OwnedVehiculesArrayID { get; set; }
        public int RacesArrayID { get; set; }
    }
}