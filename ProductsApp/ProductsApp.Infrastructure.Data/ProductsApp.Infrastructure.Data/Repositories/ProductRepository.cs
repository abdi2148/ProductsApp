using ProductsApp.Core.DomainServices;
using ProductsApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductsApp.Infrastructure.Data.Repositories
{
    public class ProductRepository : IProductRepository

    {
        readonly ProductsAppContext _context;

        public static int ProductId = 1;
        private static List<Product> _productList = new List<Product>();

        public ProductRepository(ProductsAppContext context)
        {
            _context = context;
        }

        public Product CreateProduct(Product product)
        {
            Product prod = _context.Products.Add(product).Entity;
            _context.SaveChanges();
            return prod;
        }

        public Product DeleteProduct(int Id)
        {
            Product p = GetAllProducts().Find(x => x.Id == Id);
            GetAllProducts().Remove(p);
            if (p != null)
            {
                return p;
            }
            return null;
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int Id)
        {
            return _context.Products.FirstOrDefault(prod => prod.Id == Id);
        }

        public IEnumerable<Product> ReadAllProducts()
        {
            return _productList;
        }

        public Product UpdateProduct(Product updateProduct)
        {
            var product = GetProductById(updateProduct.Id);
            if (product != null)
            {
                product.Name = updateProduct.Name;
                product.Price = updateProduct.Price;
                product.Color = updateProduct.Color;
                product.CreatedDate = updateProduct.CreatedDate;
                product.Type = updateProduct.Type;
            }
            return product;
        }
    }

}
