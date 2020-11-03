using Microsoft.EntityFrameworkCore;
using ProductsApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsApp.Infrastructure.Data
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options) 
            : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}