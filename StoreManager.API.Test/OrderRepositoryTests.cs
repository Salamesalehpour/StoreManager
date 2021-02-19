using StoreManager.Common.Entities;
using StoreManager.DA.DbContexts;
using StoreManager.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace StoreManager.API.Test
{
    public class OrderRepositoryTests
    {
        [Fact]
        public void GetOrders_PageSizeIsThree_ReturnThreeOrders()
        {
            using (var db = DbContextFactory.InMemoryStoreManagerContext())
            {
                //Arange
                var customer = new Customer { FirstName = "Ali", LastName = "Alavi", Address = "Tehran", Phone = "02147382947" };

                customer.Orders = new List<Order>
                {
                    new Order { OrderDate = DateTime.Now },
                    new Order { OrderDate = DateTime.Now.AddDays(-1)},
                    new Order { OrderDate = DateTime.Now.AddDays(-2)},
                };

                db.Customers.Add(customer);

                db.SaveChanges();

                var orderRepository = new OrderRepository(db);

                //Act
                var ordersCount = orderRepository.GetOrders(1, 3).Count();

                //Assert
                Assert.Equal(3, ordersCount);
            }
        }
    }
}
