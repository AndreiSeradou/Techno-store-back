using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Techno_store_back.DataAccessLayer.Data;
using Techno_store_back.DataAccessLayer.Entities;
using Techno_store_back.DataAccessLayer.Interfaces.Repositories;
using Techno_store_back.DataAccessLayer.Models.DTOs;

namespace Techno_store_back.DataAccessLayer.Repositories
{
    public class LaptopRepository : ILaptopRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public LaptopRepository(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<bool> CreateAsync(LaptopDAL model)
        {
            var laptopEntity = _mapper.Map<Laptop>(model);
            var entityEntry = await _dbContext.Laptops.AddAsync(laptopEntity);

            return entityEntry.Entity != null;
        }

        public async Task<bool> DeleteAsync(int laptopId)
        {
            var laptopEntity = await _dbContext.Laptops.FirstOrDefaultAsync(l => l.Id == laptopId);

            if (laptopEntity != null)
            {
                var entityEntry = _dbContext.Laptops.Remove(laptopEntity);
                return entityEntry.Entity != null;
            }

            return false;
        }

        public async Task<IReadOnlyCollection<LaptopDAL>> GetAllAsync()
        {
            var laptopsEntities = await _dbContext.Laptops.AsNoTracking().ToListAsync();

            return _mapper.Map<IReadOnlyCollection<LaptopDAL>>(laptopsEntities);
        }

        public async Task<LaptopDAL> GetByIdAsync(int laptopId)
        {
            var laptopEntity = await _dbContext.Laptops.FirstOrDefaultAsync(l => l.Id == laptopId);

            return _mapper.Map<LaptopDAL>(laptopEntity);
        }

        public async Task SaveAsync()
        {
            _ = await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> UpdateAsync(LaptopDAL model)
        {
            var laptopEntity = await _dbContext.Laptops.FirstOrDefaultAsync(o => o.Id == model.Id);
            _mapper.Map(model, laptopEntity);

            return laptopEntity != null;
        }
    }
}
