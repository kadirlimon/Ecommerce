using HB.Ecommerce.Application;
using HB.Ecommerce.Application.Contracts.Services;
using HB.Ecommerce.Domain.Entity;
using HB.Ecommerce.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyApiWithToken.Domain.Response;

namespace HB.Ecommerce.Domain.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<BaseResponse<Order>> CreateAsync(Order order)
        {
            try
            {
                await _orderRepository.CreateAsync(order);
                return new BaseResponse<Order>(order);
            }
            catch (Exception ex)
            {
                return new BaseResponse<Order>(ex.Message);
            }
        }

        public async Task<BaseResponse<int>> DeleteAsync(int id)
        {
            try
            {
                var order = await _orderRepository.GetAsync(id);
                if (order != null)
                {
                    await _orderRepository.DeleteAsync(id);
                    return new BaseResponse<int>(id);
                }
                else
                    return new BaseResponse<int>($"Order is not found, order id:{id}");
            }
            catch (Exception ex)
            {
                return new BaseResponse<int>(ex.Message);
            }
        }

        public async Task<BaseResponse<Order>> GetAsync(int id)
        {
            try
            {
                var order = await _orderRepository.GetAsync(id);
                return new BaseResponse<Order>(order);
            }
            catch (Exception ex)
            {
                return new BaseResponse<Order>(ex.Message);
            }
        }

        public async Task<BaseResponse<IList<Order>>> GetListAsync()
        {
            try
            {
                var orderList = await _orderRepository.GetListAsync();
                return new BaseResponse<IList<Order>>(orderList);
            }
            catch (Exception ex)
            {
                return new BaseResponse<IList<Order>>(ex.Message);
            }
        }

        public async Task<BaseResponse<Order>> UpdateAsync(Order order)
        {
            try
            {
                var updateOrder = await _orderRepository.UpdateAsync(order);
                return new BaseResponse<Order>(updateOrder);
            }
            catch (Exception ex)
            {
                return new BaseResponse<Order>(ex.Message);
            }
        }
    }
}
