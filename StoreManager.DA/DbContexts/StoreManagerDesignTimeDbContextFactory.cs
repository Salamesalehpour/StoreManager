using Microsoft.EntityFrameworkCore.Design;
using StoreManager.DA.DbContexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreManager.DA.DbContexts
{ 
    public class StoreManagerDesignTimeDbContextFactory : IDesignTimeDbContextFactory<StoreManagerContext>
    {
        public StoreManagerContext CreateDbContext(string[] args)
        {
            return DbContextFactory.SqlServerStoreManagerContext();
        }
    }
}
