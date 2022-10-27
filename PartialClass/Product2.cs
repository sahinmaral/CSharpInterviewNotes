using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    partial class Product
    {
        public decimal GetPrice()
        {
            return this.UnitPrice;
        }

        public decimal GetDiscountedPrice()
        {
            return this.UnitPrice - ((this.UnitPrice * this.Discount) / 100);
        }
    }
}
