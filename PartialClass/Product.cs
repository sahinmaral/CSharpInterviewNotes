using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    partial class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public Product(string name,int stock,decimal unitPrice,decimal discount)
        {
            Id = Guid.NewGuid();
            Name = name;
            Stock = stock;
            UnitPrice = unitPrice;
            Discount = discount;
        }
    }
}
