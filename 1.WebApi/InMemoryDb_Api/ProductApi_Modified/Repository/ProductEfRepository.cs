using Microsoft.EntityFrameworkCore;
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
            var customerDelete = _ProductDbContext.Products.FirstOrDefault(p => p.Id == id);
            if (customerDelete != null)
            {
                _ProductDbContext.Products.Remove(customerDelete);
                _ProductDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Product> GetProduct()
        {
           return _ProductDbContext.Products;
        }

        public IEnumerable<Product> GetProductGreater(int ProductAmount)
        {
            List<Product> productsGreater = new List<Product>();

            foreach (var item in _ProductDbContext.Products)
            {
                if (item.Amount > ProductAmount)
                {
                    productsGreater.Add(item);
                }
            }

            return productsGreater;
        }

        public bool SendProduct(Product product)
        {
            _ProductDbContext.Products.Add(product);
            _ProductDbContext.SaveChanges();
            return true;
        }

        public bool UpdateProduct(int id, Product product)
        {
            var customerExist = _ProductDbContext.Products.FirstOrDefault(x=> x.Id==id);
            if(customerExist != null)
            {
                customerExist.Amount = product.Amount;
                customerExist.Name = product.Name;
                customerExist.Description = product.Description;
                _ProductDbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
