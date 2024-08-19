using Bookapi.Data;
using Carter;
using Microsoft.EntityFrameworkCore;

namespace Bookapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddMediatR(media => { media.RegisterServicesFromAssembly(typeof(Program).Assembly); });
            builder.Services.AddCarter();
            builder.Services.AddDbContext<ProductContext>(options => { options.UseInMemoryDatabase("BokkDb"); });
            var app = builder.Build();

            app.MapCarter();
            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
