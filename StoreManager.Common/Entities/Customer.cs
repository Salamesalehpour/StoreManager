﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StoreManager.Common.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }
    }
}
