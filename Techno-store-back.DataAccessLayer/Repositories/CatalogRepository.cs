using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Techno_store_back.DAL.Interfaces.Repositories;
using Techno_store_back.DAL.Models.DTOs;

namespace Techno_store_back.DAL.Repositories
{
    public class CatalogRepository : ICatalogRepository
    {
        public Task<bool> CreateAsync(CatalogDAL model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int catalogId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<CatalogDAL>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CatalogDAL> GetByIdAsync(int catalogId)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(CatalogDAL model)
        {
            throw new NotImplementedException();
        }
    }
}
