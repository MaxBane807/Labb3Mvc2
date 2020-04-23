using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Labb3Mvc2.VIewModels
{
    public class NewCarViewModel
    {

        [Required]
        [StringLength(50)]
        public string Manufacturer { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        [Required]
        [Range(1980, 2050)]
        public int Year { get; set; }

        [Required]
        [Range(0, 10000000)]
        public decimal Price { get; set; }

        [Required]
        [Range(1, 5)]
        public int Seats { get; set; }
    }
}
