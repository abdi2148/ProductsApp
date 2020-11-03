using ProductsApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsApp.Core.DomainServices
{
    public interface IProductRepository
    {
        IEnumerable<Product> ReadAllProducts();

        public List<Product> GetAllProducts();

        Product CreateProduct(Product product);

        Product GetProductById(int id);

        Product UpdateProduct(Product updateProduct);

        Product DeleteProduct(int id);
    }
}

