using ProductApi.Database;
using ProductApi.Model;

namespace ProductApi.Repository
{
    public class ProductEfRepository : IProductRepository
    {
        ProductDbContext _ProductDbContext;
        public ProductEfRepository(ProductDbContext dbContext)
        {
            _ProductDbContext = dbContext;
        }
        public bool DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProduct()
        {
           return _ProductDbContext.Products;
        }

        public IEnumerable<Product> GetProductGreater(int ProductAmount)
        {
            throw new NotImplementedException();
        }

        public bool SendProduct(Product product)
        {
            _ProductDbContext.Products.Add(product);
            _ProductDbContext.SaveChanges();
            return true;
        }

        public bool UpdateProduct(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
