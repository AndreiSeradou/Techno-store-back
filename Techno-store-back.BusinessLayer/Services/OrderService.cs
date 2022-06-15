using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_store_back.BL.Interfaces.Services;
using Techno_store_back.BL.Models.DTOs;
using Techno_store_back.DAL.Interfaces.Repositories;
using Techno_store_back.DAL.Models.DTOs;

namespace Techno_store_back.BL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<bool> CreateAsync(OrderBL model)
        {
            var order = _mapper.Map<OrderDAL>(model);

            var result = await _orderRepository.CreateAsync(order);

            if (result != false)
            {
               await _orderRepository.SaveAsync();
            }

            return result;
        }

        public async Task<bool> DeleteAsync(int orderId)
        {
            var result = await _orderRepository.DeleteAsync(orderId);

            if (result != false)
            {
                await _orderRepository.SaveAsync();
            }

            return result;
        }

        public async Task<IReadOnlyCollection<OrderBL>> GetAllAsync()
        {
            var orders = await _orderRepository.GetAllAsync();

            return _mapper.Map<IReadOnlyCollection<OrderBL>>(orders);
        }

        public async Task<OrderBL> GetByIdAsync(int orderId)
        {
            var order = await _orderRepository.GetByIdAsync(orderId);

            return _mapper.Map<OrderBL>(order);
        }

        public async Task<bool> UpdateAsync(OrderBL model)
        {
            var order = _mapper.Map<OrderDAL>(model);

            var result = await _orderRepository.UpdateAsync(order);

            if (result != false)
            {
               await _orderRepository.SaveAsync();
            }

            return result;
        }
    }
}
