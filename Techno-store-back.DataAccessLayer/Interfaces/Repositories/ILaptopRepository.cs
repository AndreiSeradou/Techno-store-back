using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_store_back.DataAccessLayer.Models.DTOs;

namespace Techno_store_back.DataAccessLayer.Interfaces.Repositories
{
    public interface ILaptopRepository
    {
        Task<IReadOnlyCollection<LaptopDAL>> GetAllAsync();
        Task<LaptopDAL> GetByIdAsync(int laptopId);
        Task<bool> CreateAsync(LaptopDAL model);
        Task<bool> UpdateAsync(LaptopDAL model);
        Task<bool> DeleteAsync(int laptopId);
        Task SaveAsync();
    }
}
