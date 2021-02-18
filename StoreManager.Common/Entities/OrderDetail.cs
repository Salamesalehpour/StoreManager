using System;
using System.Collections.Generic;
using System.Text;

namespace StoreManager.Common.Entities
{
    public class OrderDetail
    {
        public int OrderDetailsId { get; set; }
        public int Qty { get; set; }
        public Decimal Price { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
