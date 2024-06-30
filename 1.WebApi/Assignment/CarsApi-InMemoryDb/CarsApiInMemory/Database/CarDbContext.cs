using CarsApiInMemory.Model;
using Microsoft.EntityFrameworkCore;

namespace CarsApiInMemory.Database
{
    public class CarDbContext:DbContext
    {
        public CarDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Car> carsDatabase {  get; set; }

       
    }
}
