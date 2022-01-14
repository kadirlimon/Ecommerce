using HB.Ecommerce.Application.Contracts;
using HB.Ecommerce.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyApiWithToken.Domain.Response;

namespace HB.Ecommerce.Application
{
    public class BaseService<TEntity>  where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _baseRepository;
        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }
    }
}
