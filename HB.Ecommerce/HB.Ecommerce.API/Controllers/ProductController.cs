using HB.Ecommerce.Application.Contracts.Dto;
using HB.Ecommerce.Application.Contracts.Services;
using HB.Ecommerce.Domain.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyApiWithToken.Domain.Response;

namespace HB.Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<BaseResponse<IList<Product>>> GetAll()
        {
            return await _productService.GetListAsync();
        }

        [HttpGet("{id}")]
        public async Task<BaseResponse<Product>> Get(int id)
        {
            return await _productService.GetAsync(id);
        }

        [HttpPost("productinfo")]
        public async Task<BaseResponse<Product>> GetProductByProductCode([FromBody] string productCode)
        {
            return await _productService.GetProductByProductCodeAsync(productCode);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductDto _product)
        {
            var response = await _productService.CreateAsync(new Product(_product.ProductCode, _product.Price, _product.Stock));
            var prodoctDto = new ProductDto();
            prodoctDto.ProductCode = response.Data.ProductCode;
            prodoctDto.Price = response.Data.Price;
            prodoctDto.Stock = response.Data.Stock;
            var resp = new BaseResponse<ProductDto>(prodoctDto);

            return new JsonResult(resp);
        }


    }
}
