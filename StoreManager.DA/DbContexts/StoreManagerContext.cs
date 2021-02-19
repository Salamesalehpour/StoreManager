using Microsoft.EntityFrameworkCore;
using StoreManager.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreManager.DA.DbContexts
{
    public class StoreManagerContext : DbContext
    {
        public StoreManagerContext(DbContextOptions<StoreManagerContext> dbContextOptions)
            : base(dbContextOptions)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
