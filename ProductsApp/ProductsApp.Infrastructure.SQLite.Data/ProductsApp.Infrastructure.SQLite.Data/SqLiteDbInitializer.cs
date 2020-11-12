using ProductsApp.Core.Entities;
using ProductsApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ProductsApp.Infrastructure.SQLite.Data
{
    public class SqLiteDbInitializer : IDbInitializer
    {
        // This method will cre<ate and seed the database.
        public void Initialize(Infrastructure.Data.DbContext context)
        {
            // Delete the database, if it already exists. You need to clean and build
            // the solution for this to take effect.
            context.Database.EnsureDeleted();

            // Create the database, if it does not already exists. If the database
            // already exists, no action is taken (and no effort is made to ensure it
            // is compatible with the model for this context).
            context.Database.EnsureCreated();

            List<Product> products = new List<Product>
            {
                new Product {IsComplete=true, Name="Use SqLite"},
                new Product {IsComplete=false, Name="Exam project"}
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
