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
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<BaseResponse<IList<Order>>> GetAll()
        {
            return await _orderService.GetListAsync();
        }

        [HttpGet("{id}")]
        public async Task<BaseResponse<Order>> Get(int id)
        {
            return await _orderService.GetAsync(id);
        }

        [HttpPost]
        public async Task<BaseResponse<OrderDto>> Create(OrderDto _order)
        {
            var order = await _orderService.CreateAsync(new Order(_order.ProductCode, _order.Quantity));

            var orderDto = new OrderDto();
            orderDto.ProductCode = order.Data.ProductCode;
            orderDto.Quantity = order.Data.Quantity;

            return new BaseResponse<OrderDto>(orderDto);
        }
    }
}
