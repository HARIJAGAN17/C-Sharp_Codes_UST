﻿using ProductApi.Model;

namespace ProductApi.Repository
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProduct();

        public IEnumerable<Product> GetProductGreater(int ProductAmount);

        public bool SendProduct(Product product);

        public bool UpdateProduct(int id, Product product);

        public bool DeleteProduct(int id);

    }
}
