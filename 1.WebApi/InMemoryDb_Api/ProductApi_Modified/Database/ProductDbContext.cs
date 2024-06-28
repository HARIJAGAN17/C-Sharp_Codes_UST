using Microsoft.EntityFrameworkCore;
using ProductApi.Model;

namespace ProductApi.Database
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions options):base(options) { 
        
            

        }

        public DbSet<Product> Products { get; set; }
     
    }
}
