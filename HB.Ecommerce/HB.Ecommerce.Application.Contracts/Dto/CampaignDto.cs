using System;
using System.Collections.Generic;
using System.Text;

namespace HB.Ecommerce.Application.Contracts.Dto
{
    public class CampaignDto
    {
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public int Duration { get; set; }
        public decimal PriceManipulationLimit { get; set; }
        public decimal TargetSalesCount { get; set; }
    }
}
