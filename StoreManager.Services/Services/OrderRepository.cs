using StoreManager.Common.Entities;
using StoreManager.DA.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManager.Services.Services
{
    public class OrderRepository
    {
        private StoreManagerContext storeManagerContext;

        public OrderRepository(StoreManagerContext storeManagerContext)
        {
            this.storeManagerContext = storeManagerContext;
        }

        public IEnumerable<Order> GetOrders()
        {
            return storeManagerContext.Orders.ToList();
        }

        public IEnumerable<Order> GetOrders(int pageNumber = 1, int pageSize = 5)
        {
            return storeManagerContext.Orders.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}
