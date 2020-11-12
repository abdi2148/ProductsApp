using Microsoft.EntityFrameworkCore;
using ProductsApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsApp.Infrastructure.Data
{
    public class ProductsAppContext : DbContext
    {
        public ProductsAppContext(DbContextOptions<ProductsAppContext> options) 
            : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}