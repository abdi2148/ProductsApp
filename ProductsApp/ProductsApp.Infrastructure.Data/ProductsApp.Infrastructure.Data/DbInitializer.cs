using ProductsApp.Core.DomainServices;
using ProductsApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsApp.Infrastructure.Data
{
    public class DbInitializer : IDbInitializer
    {
        private readonly IProductRepository _productRepository;


        public void Initialize(DbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();



            List<Product> products = new List<Product>
               {
                   new Product{
                       Name = "Car",
                       Color = "Black",
                       Type = "SUV",
                       Price = 2000000,
                       CreatedDate =  DateTime.Now.Date.AddYears(1)
                   },
                                 
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}