using System;
using System.Collections.Generic;
using System.Text;

namespace StoreManager.Common.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Decimal Price { get; set; }
    }
}
