using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyApiWithToken.Domain.Response;

namespace HB.Ecommerce.Application.Contracts
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        Task<BaseResponse<TEntity>> GetAsync(int id);

        Task<BaseResponse<IList<TEntity>>> GetListAsync();

        Task<BaseResponse<TEntity>> CreateAsync(TEntity entity);

        Task<BaseResponse<TEntity>> UpdateAsync(TEntity entity);

        Task<BaseResponse<int>> DeleteAsync(int id);
    }
}
