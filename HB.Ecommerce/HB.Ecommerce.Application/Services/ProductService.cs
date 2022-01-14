using HB.Ecommerce.Application;
using HB.Ecommerce.Application.Contracts;
using HB.Ecommerce.Application.Contracts.Services;
using HB.Ecommerce.Domain.Entity;
using HB.Ecommerce.Domain.Repository;
using HB.Ecommerce.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyApiWithToken.Domain.Response;

namespace HB.Ecommerce.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICampaignRepository _campaignRepository;
        public ProductService(IProductRepository productRepository, ICampaignRepository campaignRepository)
        {
            _productRepository = productRepository;
            _campaignRepository = campaignRepository;
        }

        public async Task<BaseResponse<Product>> CreateAsync(Product product)
        {
            try
            {
                await _productRepository.CreateAsync(product);
                return new BaseResponse<Product>(product);
            }
            catch (Exception ex)
            {
                return new BaseResponse<Product>(ex.Message);
            }
        }

        public async Task<BaseResponse<int>> DeleteAsync(int id)
        {
            try
            {
                var product = await _productRepository.GetAsync(id);
                if (product != null)
                {
                    await _productRepository.DeleteAsync(id);
                    return new BaseResponse<int>(id);
                }
                else
                    return new BaseResponse<int>($"Not found product, id:{id}");
            }
            catch (Exception ex)
            {
                return new BaseResponse<int>(ex.Message);
            }
        }

        public async Task<BaseResponse<Product>> GetAsync(int id)
        {
            try
            {
                var product = await _productRepository.GetAsync(id);
                return new BaseResponse<Product>(product);
            }
            catch (Exception ex)
            {
                return new BaseResponse<Product>(ex.Message);
            }
        }

        public async Task<BaseResponse<IList<Product>>> GetListAsync()
        {
            try
            {
                var productList = await _productRepository.GetListAsync();
                return new BaseResponse<IList<Product>>(productList);
            }
            catch (Exception ex)
            {
                return new BaseResponse<IList<Product>>(ex.Message);
            }
        }

        public async Task<BaseResponse<Product>> GetProductByProductCodeAsync(string productCode)
        {
            try
            {
                var product = await _productRepository.SingleOrDefaultAsync(x => x.ProductCode == productCode);
                if (product != null)
                {
                    var systemTimeNow = SystemTime.Now;
                    var campaign = await _campaignRepository.SingleOrDefaultAsync(x => x.ProductCode == product.ProductCode && x.CampaignEndDate >= systemTimeNow == x.CampaignStartDate <= systemTimeNow);
                    var discount = campaign?.GetCurrentDiscount() ?? 0;
                    product.ApplyDiscount(discount);
                    await _productRepository.UpdateAsync(product);
                    return new BaseResponse<Product>(product);
                }
                else
                    return new BaseResponse<Product>($"Not found product, product code={productCode}");
            }
            catch (Exception ex)
            {
                return new BaseResponse<Product>(ex.Message);
            }
        }

        public async Task<BaseResponse<Product>> UpdateAsync(Product entity)
        {
            try
            {
                var updateEntity = await _productRepository.UpdateAsync(entity);
                return new BaseResponse<Product>(updateEntity);
            }
            catch (Exception ex)
            {
                return new BaseResponse<Product>(ex.Message);
            }
        }
    }
}
