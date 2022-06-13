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
    public class CatalogRepository : ICatalogRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public CatalogRepository(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<bool> CreateAsync(CatalogDAL model)
        {
            var catalogEntity = _mapper.Map<Catalog>(model);
            var entityEntry = await _dbContext.Catalogs.AddAsync(catalogEntity);

            return entityEntry.Entity != null;
        }

        public async Task<bool> DeleteAsync(int catalogId)
        {
            var catalogEntity = await _dbContext.Catalogs.FirstOrDefaultAsync(c => c.Id == catalogId);

            if (catalogEntity != null)
            {
                var entityEntry = _dbContext.Catalogs.Remove(catalogEntity);
                return entityEntry.Entity != null;
            }

            return false;
        }

        public async Task<IReadOnlyCollection<CatalogDAL>> GetAllAsync()
        {
            var catalogsEntities = await _dbContext.Catalogs.AsNoTracking().ToListAsync();

            return _mapper.Map<IReadOnlyCollection<CatalogDAL>>(catalogsEntities);
        }

        public async Task<CatalogDAL> GetByIdAsync(int catalogId)
        {
            var catalogEntity = await _dbContext.Catalogs.FirstOrDefaultAsync(c => c.Id == catalogId);

            return _mapper.Map<CatalogDAL>(catalogEntity);
        }

        public async Task SaveAsync()
        {
            _ = await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> UpdateAsync(CatalogDAL model)
        {
            var catalogEntity = await _dbContext.Catalogs.FirstOrDefaultAsync(c => c.Id == model.Id);
            _mapper.Map(model, catalogEntity);

            return catalogEntity != null;
        }
    }
}
