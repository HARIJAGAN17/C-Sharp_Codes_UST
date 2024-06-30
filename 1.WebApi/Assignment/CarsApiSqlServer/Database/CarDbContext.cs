using CarsApiInMemory.Model;
using Microsoft.EntityFrameworkCore;

namespace CarsApiInMemory.Database
{
    public class CarDbContext : DbContext
    {
        public CarDbContext(DbContextOptions<CarDbContext> options) : base(options)
        {

        }

        public DbSet<Car> carsDatabase { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id= 1,
                    Name= "Ford Mustang",
                    Category= "Sport",
                    Price= 55999.99
                }
                );
        }
    }
}
