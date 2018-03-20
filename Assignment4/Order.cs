using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class Order
    {
        public DateTime Date { get; set; }
        public DateTime Required { get; set; }
        public string OrderDetails { get; set; }
        public string ShipName { get; set; }
        public string ShipCity { get; set; }
    }
}
