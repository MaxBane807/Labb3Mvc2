using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3Mvc2.Models
{
    public class DatabaseInitializer
    {
        public static void Initialize(CarShopDbContext context)
        {
            context.Database.Migrate();
            SeedData(context);

        }
        private static void SeedData(CarShopDbContext context)
        {
            if(!context.Cars.Any(car => car.Id == 1))
            {
                context.Cars.Add(new Car
                {
                    Manufacturer = "Volvo",
                    Model = "V70",
                    Price= 10000,
                    Year=1996,
                    Seats=2
                });
                context.SaveChanges();
            }
        }
    }
}
