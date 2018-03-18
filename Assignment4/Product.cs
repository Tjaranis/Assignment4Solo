﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public double UnitPrice { get; set; }
        public object QuantityPerUnit { get; set; }
        public int UnitsInStock { get; set; }
    }
}
