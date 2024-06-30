using CarsApiInMemory.Database;
using CarsApiInMemory.Repository;
using Microsoft.EntityFrameworkCore;


namespace CarsApiInMemory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<ICarRepository, CarInMemoryRepo>();
            builder.Services.AddDbContext<CarDbContext>(Options => {

                var CarConfiguratoin = builder.Configuration.GetConnectionString("CarSettings");

                Options.UseSqlServer(CarConfiguratoin);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
