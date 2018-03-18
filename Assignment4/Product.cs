using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }//maybe
        public double UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
        public int UnitsInStock { get; set; }
        public int CategoryId { get; set; }

        public Product()
        {
            var service = new DataService();
            this.Category = service.GetCategory(1);
        }
    }
}
