using HB.Ecommerce.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyApiWithToken.Domain.Response;

namespace HB.Ecommerce.Application.Contracts.Services
{
    public interface IProductService: IBaseService<Product>
    {
        Task<BaseResponse<Product>> GetProductByProductCodeAsync(string productCode);
    }
}
