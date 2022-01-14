using HB.Ecommerce.Application;
using HB.Ecommerce.Domain.Entity;
using HB.Ecommerce.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HB.Ecommerce.Infrastructure.Repository
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public readonly AppDbContext _appDbContext;
        public OrderRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

    }
}
