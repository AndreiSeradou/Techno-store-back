using System.Collections.Generic;
using System.Threading.Tasks;
using Techno_store_back.BL.Models.DTOs;

namespace Techno_store_back.BL.Interfaces.Services
{
    public interface ILaptopService
    {
        Task<IReadOnlyCollection<LaptopBL>> GetAllAsync();
        Task<LaptopBL> GetByIdAsync(int laptopId);
        Task<bool> CreateAsync(LaptopBL model);
        Task<bool> UpdateAsync(LaptopBL model);
        Task<bool> DeleteAsync(int laptopId);
    }
}
