using HB.Ecommerce.Application;
using HB.Ecommerce.Domain.Entity;
using HB.Ecommerce.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HB.Ecommerce.Infrastructure.Repository
{
    public class CampaignRepository : BaseRepository<Campaign>, ICampaignRepository
    {
        public readonly AppDbContext _appDbContext;
        public CampaignRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

    }
}
