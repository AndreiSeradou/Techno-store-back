using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_store_back.DAL.Models.DTOs;

namespace Techno_store_back.DAL.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        Task<IReadOnlyCollection<OrderDAL>> GetAllAsync();
        Task<OrderDAL> GetByIdAsync(int orderId);
        Task<bool> CreateAsync(OrderDAL model);
        Task<bool> UpdateAsync(OrderDAL model);
        Task<bool> DeleteAsync(int orderId);
        Task SaveAsync();
    }
}
