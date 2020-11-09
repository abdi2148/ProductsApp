using ProductsApp.Core.DomainServices;
using ProductsApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ProductsApp.Infrastructure.Data
{
    public class DbInitializer : IDbInitializer
    {
        private readonly IUserRepository<User> _productRepository;


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
                    new Product{
                       Name = "Car",
                       Color = "Blue",
                       Type = "SUV",
                       Price = 2500000,
                       CreatedDate =  DateTime.Now.Date.AddYears(1)
                   },
                   

            };
            string password = "12345";
            List<User> users = new List<User>{
                new User
                {
                    Username = "Jenifer",
                    Password = password,
                    IsAdmin = true

                },
                 new User
                {
                    Username = "Martin",
                    Password = password,
                    IsAdmin = false

                }
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}