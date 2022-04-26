using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class DriverArray
    {
        [Key]
        public int RaceID { get; set; }
        public int DriverID { get; set; }
    }
}