using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreManager.DA.DbContexts
{
    public class DbContextFactory
    {
        public static StoreManagerContext SqlServerStoreManagerContext()
        {
            var builder = new DbContextOptionsBuilder<StoreManagerContext>();

            builder.UseSqlServer("Server=.; Database=StoreManager; Integrated Security= true;")
                .LogTo(Console.WriteLine, LogLevel.Information);

            return new StoreManagerContext(builder.Options);
        }


        public static StoreManagerContext InMemoryStoreManagerContext()
        {
            var builder = new DbContextOptionsBuilder<StoreManagerContext>();

            builder.UseInMemoryDatabase("StoreManagerDb");

            return new StoreManagerContext(builder.Options);
        }
    }
}
