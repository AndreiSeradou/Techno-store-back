using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Techno_store_back.DAL.Interfaces.Repositories;
using Techno_store_back.DAL.Models.DTOs;

namespace Techno_store_back.DAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Task<bool> CreateAsync(OrderDAL model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<OrderDAL>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OrderDAL> GetByIdAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(OrderDAL model)
        {
            throw new NotImplementedException();
        }
    }
}
