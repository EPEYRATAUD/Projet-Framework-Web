using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class CarCategoryArray
    {
        [Key]
        public int CarID { get; set; }
        public int CategoryID { get; set; }

    }
}