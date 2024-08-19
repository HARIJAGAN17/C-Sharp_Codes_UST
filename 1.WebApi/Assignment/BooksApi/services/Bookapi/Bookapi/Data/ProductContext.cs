using Bookapi.Model;
using Microsoft.EntityFrameworkCore;

namespace Bookapi.Data
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions options):base(options) 
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}
