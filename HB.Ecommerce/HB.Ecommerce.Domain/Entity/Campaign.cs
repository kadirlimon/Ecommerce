using HB.Ecommerce.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace HB.Ecommerce.Domain.Entity
{
    public class Campaign
    {
        public int CampaignId { get; private set; }
        public string Name { get; private set; }
        public string ProductCode { get; private set; }
        public int Duration { get; private set; }
        public decimal PriceManipulationLimit { get; private set; }
        public decimal TargetSalesCount { get; private set; }

        public DateTime CampaignStartDate { get; private set; }
        public DateTime CampaignEndDate { get; private set; }

        public string Status { get { return CampaignEndDate < SystemTime.Now ? "Ended" : "Active"; } }

        public Campaign(string Name, string ProductCode, int Duration, decimal PriceManipulationLimit, decimal TargetSalesCount)
        {
            this.Name = Name;
            this.ProductCode = ProductCode;
            this.Duration = Duration;
            this.PriceManipulationLimit = PriceManipulationLimit;
            this.TargetSalesCount = TargetSalesCount;
            this.CampaignStartDate = SystemTime.Now;
            this.CampaignEndDate = SystemTime.Now.AddHours(Duration);
        }

        public decimal GetCurrentDiscount()
        {
            var remainingHour = (CampaignEndDate - SystemTime.Now).Hours;
            var unitDiscount = ((this.PriceManipulationLimit - 1) / this.Duration);
            var currentDiscount=remainingHour > 0 ? ((this.PriceManipulationLimit / unitDiscount) + 1) : 0;
            return Math.Round(currentDiscount, 1);
        }

    }
}
