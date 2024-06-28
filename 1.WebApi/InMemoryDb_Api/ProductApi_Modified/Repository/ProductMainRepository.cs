using ProductApi.Model;

namespace ProductApi.Repository
{
    public class ProductMainRepository:IProductRepository
    {
        List<Product> products = new List<Product>();

        public ProductMainRepository()
        {

            products.Add(new Product { Name = "Desk", Description = "Office work", Amount = 5000 });
            products.Add(new Product { Name = "Chair", Description = "Comfort seating", Amount = 1500 });
            products.Add(new Product { Name = "Bookshelf", Description = "Storage for books", Amount = 3000 });
            products.Add(new Product { Name = "Table", Description = "Dining purpose", Amount = 4000 });
            products.Add(new Product { Name = "Lamp", Description = "Lighting", Amount = 1000 });
        }

        public bool DeleteProduct(int id)
        {
            var deleteProduct = products.FirstOrDefault(x => x.Id == id);
            if (deleteProduct != null)
            {
                products.Remove(deleteProduct);
                return true;
            }
            return false;
        }

        public IEnumerable<Product> GetProduct()
        {

            return products;
        }

        public IEnumerable<Product> GetProductGreater(int ProductAmount)
        {

            return products.FindAll(products => products.Amount > ProductAmount);
        }

        public bool SendProduct(Product product)
        {
            if (product != null)
            {
                products.Add(product);
                return true;
            }
            return false;

        }

        public bool UpdateProduct(int id, Product product)
        {
            var productExist = products.FirstOrDefault(x => x.Id == id);

            if (productExist != null)
            {
                productExist.Name = product.Name;
                productExist.Description = product.Description;
                productExist.Amount = product.Amount;
                return true;
            }
            return false;

        }


    }
}
