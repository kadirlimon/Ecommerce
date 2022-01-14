using System;
using System.Collections.Generic;
using System.Text;

namespace HB.Ecommerce.Application.Contracts.Dto
{
    public class ProductDto
    {
        public string ProductCode { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
