using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3Mvc2.Models
{
    public class CarShopDbContext : DbContext
    {
        public CarShopDbContext(DbContextOptions<CarShopDbContext> options)
            :base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
    }
}
