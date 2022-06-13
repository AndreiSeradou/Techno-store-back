using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_store_back.DAL.Models.DTOs;

namespace Techno_store_back.DAL.Interfaces.Repositories
{
    public interface ICatalogRepository
    {
        Task<IReadOnlyCollection<CatalogDAL>> GetAllAsync();
        Task<CatalogDAL> GetByIdAsync(int catalogId);
        Task<bool> CreateAsync(CatalogDAL model);
        Task<bool> UpdateAsync(CatalogDAL model);
        Task<bool> DeleteAsync(int catalogId);
        Task SaveAsync();
    }
}
