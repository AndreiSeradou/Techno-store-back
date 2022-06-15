using System.Collections.Generic;
using System.Threading.Tasks;
using Techno_store_back.BL.Models.DTOs;

namespace Techno_store_back.BL.Interfaces.Services
{
    public interface IOrderService
    {
        Task<IReadOnlyCollection<OrderBL>> GetAllAsync();
        Task<OrderBL> GetByIdAsync(int orderId);
        Task<bool> CreateAsync(OrderBL model);
        Task<bool> UpdateAsync(OrderBL model);
        Task<bool> DeleteAsync(int orderId);
    }
}
