using HB.Ecommerce.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace HB.Ecommerce.Domain.Entity
{
    public class Product
    {
        public int ProductId { get; private set; }
        public string ProductCode { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }

        public Product(string ProductCode, decimal Price, int Stock)
        {
            this.ProductCode = ProductCode;
            this.Price = Price;
            this.Stock = Stock;
        }

        public void ApplyDiscount(decimal value)
        {
            this.Price -= value;
        }

    }
}
