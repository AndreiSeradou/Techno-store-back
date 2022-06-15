using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Techno_store_back.BL.Interfaces.Services;
using Techno_store_back.BL.Models.DTOs;
using Techno_store_back.DAL.Interfaces.Repositories;
using Techno_store_back.DAL.Models.DTOs;

namespace Techno_store_back.BL.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly ICatalogRepository _catalogRepository;
        private readonly IMapper _mapper;

        public CatalogService(ICatalogRepository catalogRepository, IMapper mapper)
        {
            _catalogRepository = catalogRepository;
            _mapper = mapper;
        }

        public async Task<bool> CreateAsync(CatalogBL model)
        {
            var laptop = _mapper.Map<CatalogDAL>(model);

            var result = await _catalogRepository.CreateAsync(laptop);

            if (result != false)
            {
                await _catalogRepository.SaveAsync();
            }

            return result;
        }

        public async Task<bool> DeleteAsync(int catalogId)
        {
            var result = await _catalogRepository.DeleteAsync(catalogId);

            if (result != false)
            {
                await _catalogRepository.SaveAsync();
            }

            return result;
        }

        public async Task<IReadOnlyCollection<CatalogBL>> GetAllAsync()
        {
            var catalogs = await _catalogRepository.GetAllAsync();

            return _mapper.Map<IReadOnlyCollection<CatalogBL>>(catalogs);
        }

        public async Task<CatalogBL> GetByIdAsync(int catalogId)
        {
            var catalog = await _catalogRepository.GetByIdAsync(catalogId);

            return _mapper.Map<CatalogBL>(catalog);
        }

        public async Task<bool> UpdateAsync(CatalogBL model)
        {
            var catalog = _mapper.Map<CatalogDAL>(model);

            var result = await _catalogRepository.UpdateAsync(catalog);

            if (result != false)
            {
                await _catalogRepository.SaveAsync();
            }

            return result;
        }
    }
}
