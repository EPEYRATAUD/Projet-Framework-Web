using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class Car
    {
        public int ID { get; set; }
        public int CategoryArrayID { get; set; }
        public int ConstructionYear { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int PowerLevel { get; set; }
        public int OwnersArrayID { get; set; }
        public string? Image { get; set; }
    }
}