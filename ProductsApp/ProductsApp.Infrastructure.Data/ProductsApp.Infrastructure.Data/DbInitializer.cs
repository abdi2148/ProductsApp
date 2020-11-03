using ProductsApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsApp.Infrastructure.Data
{
    public class DbInitializer : IDbInitializer
    {
        public void Initialize(DbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();


            List<Product> products = new List<Product>
               {

               };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}