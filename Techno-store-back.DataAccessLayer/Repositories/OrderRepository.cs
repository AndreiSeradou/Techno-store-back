using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Techno_store_back.DAL.Data;
using Techno_store_back.DAL.Entities;
using Techno_store_back.DAL.Interfaces.Repositories;
using Techno_store_back.DAL.Models.DTOs;

namespace Techno_store_back.DAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public OrderRepository(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<bool> CreateAsync(OrderDAL model)
        {
            var orderEntity = _mapper.Map<Order>(model);
            var entityEntry = await _dbContext.Orders.AddAsync(orderEntity);

            return entityEntry.Entity != null;
        }

        public async Task<bool> DeleteAsync(int orderId)
        {
            var orderEntity = await _dbContext.Orders.FirstOrDefaultAsync(o => o.Id == orderId);

            if (orderEntity != null)
            {
                var entityEntry = _dbContext.Orders.Remove(orderEntity);
                return entityEntry.Entity != null;
            }

            return false;
        }

        public async Task<IReadOnlyCollection<OrderDAL>> GetAllAsync()
        {
            var ordersEntities = await _dbContext.Orders.AsNoTracking().ToListAsync();

            return _mapper.Map<IReadOnlyCollection<OrderDAL>>(ordersEntities);
        }

        public async Task<OrderDAL> GetByIdAsync(int orderId)
        {
            var orderEntity = await _dbContext.Orders.FirstOrDefaultAsync(o => o.Id == orderId);

            return _mapper.Map<OrderDAL>(orderEntity);
        }

        public async Task SaveAsync()
        {
            _ = await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> UpdateAsync(OrderDAL model)
        {
            var orderEntity = await _dbContext.Orders.FirstOrDefaultAsync(o => o.Id == model.Id);
            _mapper.Map(model, orderEntity);

            return orderEntity != null;
        }
    }
}
