using HB.Ecommerce.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace HB.Ecommerce.Domain.Entity
{
    public class Order
    {
        public int OrderId { get; private set; }
        public string ProductCode { get; private set; }
        public int Quantity { get; private set; }

        public Order(string ProductCode, int Quantity)
        {
            this.ProductCode = ProductCode;
            this.Quantity = Quantity;
        }
    }
}
