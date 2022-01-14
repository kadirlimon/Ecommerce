using System;
using System.Collections.Generic;
using System.Text;

namespace HB.Ecommerce.Application.Contracts.Dto
{
    public class OrderDto
    {
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
    }
}
