using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Techno_store_back.BL.Interfaces.Services;
using Techno_store_back.BL.Models.DTOs;
using Techno_store_back.DAL.Interfaces.Repositories;
using Techno_store_back.DAL.Models.DTOs;

namespace Techno_store_back.BL.Services
{
    public class LaptopService : ILaptopService
    {
        private readonly ILaptopRepository _laptopRepository;
        private readonly IMapper _mapper;

        public LaptopService(ILaptopRepository laptopRepository, IMapper mapper)
        {
            _laptopRepository = laptopRepository;
            _mapper = mapper;
        }

        public async Task<bool> CreateAsync(LaptopBL model)
        {
            var laptop = _mapper.Map<LaptopDAL>(model);

            var result = await _laptopRepository.CreateAsync(laptop);

            if (result != false)
            {
                await _laptopRepository.SaveAsync();
            }

            return result;
        }

        public async Task<bool> DeleteAsync(int laptopId)
        {
            var result = await _laptopRepository.DeleteAsync(laptopId);

            if (result != false)
            {
                await _laptopRepository.SaveAsync();
            }

            return result;
        }

        public async Task<IReadOnlyCollection<LaptopBL>> GetAllAsync()
        {
            var laptops = await _laptopRepository.GetAllAsync();

            return _mapper.Map<IReadOnlyCollection<LaptopBL>>(laptops);
        }

        public async Task<LaptopBL> GetByIdAsync(int laptopId)
        {
            var laptop = await _laptopRepository.GetByIdAsync(laptopId);

            return _mapper.Map<LaptopBL>(laptop);
        }

        public async Task<bool> UpdateAsync(LaptopBL model)
        {
            var laptop = _mapper.Map<LaptopDAL>(model);

            var result = await _laptopRepository.UpdateAsync(laptop);

            if (result != false)
            {
                await _laptopRepository.SaveAsync();
            }

            return result;
        }
    }
}
