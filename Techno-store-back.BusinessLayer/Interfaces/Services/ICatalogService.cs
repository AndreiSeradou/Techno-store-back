using System.Collections.Generic;
using System.Threading.Tasks;
using Techno_store_back.BL.Models.DTOs;

namespace Techno_store_back.BL.Interfaces.Services
{
    public interface ICatalogService
    {
        Task<IReadOnlyCollection<CatalogBL>> GetAllAsync();
        Task<CatalogBL> GetByIdAsync(int catalogId);
        Task<bool> CreateAsync(CatalogBL model);
        Task<bool> UpdateAsync(CatalogBL model);
        Task<bool> DeleteAsync(int catalogId);
    }
}
