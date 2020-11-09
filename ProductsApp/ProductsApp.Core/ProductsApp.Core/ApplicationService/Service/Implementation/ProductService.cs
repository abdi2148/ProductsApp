using ProductsApp.Core.DomainServices;
using ProductsApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProductsApp.Core.ApplicationServices.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IUserRepository _productRepo;
        public static IEnumerable<Product> productList;

        public ProductService(IUserRepository productRepo)
        {
            _productRepo = productRepo;
        }
        public Product ProductCreate(string name, double price, string color, string type, DateTime createdDate)
        {
            var product = new Product()
            {
                Name = name,
                Color = color,
                Type = type,
                CreatedDate = createdDate,
                Price = price
            };
            return product;
        }

        public Product CreateProduct(Product product)
        {
            if (product.Name == null || product.Name.Length < 1)
            {
                throw new InvalidDataException("Product name length has to be 1 character or higher ");
            }
            return _productRepo.CreateProduct(product);
        }
        public Product DeleteProduct(int id)
        {
            if (id < 1)
            {

                throw new InvalidDataException("The ID has to be at least 1");
            }
            return _productRepo.DeleteProduct(id);
        }

        public List<Product> GetProducts()
        {
            return _productRepo.GetAllProducts();
        }

        public Product ReadById(int id)
        {
            return _productRepo.GetProductById(id);
        }

        public Product UpdateProduct(Product product)
        {
            if (product.Name.Length < 1)
            {
                throw new InvalidDataException("Product name length has to be 1 character or higher");
            }

            if (product == null)
            {
                throw new InvalidDataException("Did not find the product with the following ID:" + product.id);
            }
            return _productRepo.UpdateProduct(product);
        }


    }
}