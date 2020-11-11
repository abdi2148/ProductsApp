using ProductsApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsApp.Core.ApplicationServices.Services.Implementation
{
    public interface IProductService
    {
        public List<Product> GetProducts();

        Product ProductCreate(string name, double price, string color, string type, DateTime createdDate);

        Product CreateProduct(Product product);

        Product UpdateProduct(Product product);

        Product DeleteProduct(int id);

        Product ReadById(int id);
    }
}

