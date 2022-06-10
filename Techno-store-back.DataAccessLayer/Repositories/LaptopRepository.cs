using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Techno_store_back.DataAccessLayer.Data;
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

        public Task<bool> CreateAsync(LaptopDAL model)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteAsync(int laptopId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IReadOnlyCollection<LaptopDAL>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<LaptopDAL> GetByIdAsync(int laptopId)
        {
            throw new System.NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateAsync(LaptopDAL model)
        {
            throw new System.NotImplementedException();
        }
    }
}
