using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class OwnedVehiculesArray
    {
        [Key]
        public int DriverID { get; set; }
        public int CarID { get; set; }
    }
}