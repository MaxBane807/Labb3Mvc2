using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3Mvc2.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }

        public int Seats { get; set; }

    }
}
