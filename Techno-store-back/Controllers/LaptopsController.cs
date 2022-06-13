using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Techno_store_back.BL.Interfaces.Services;
using Techno_store_back.BL.Models.DTOs;
using Techno_store_back.Configuration;
using Techno_store_back.Web.Models.DTOs;

namespace Techno_store_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LaptopsController : ControllerBase
    {
        private readonly ILaptopService _laptopService;
        private readonly IMapper _mapper;

        public LaptopsController(ILaptopService laptopService, IMapper mapper)
        {
           _laptopService = laptopService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetLaptops")]
        public async Task<IActionResult> GetAllLaptopsAsync()
        {
            var laptops = await _laptopService.GetAllAsync();
            var result = _mapper.Map<IReadOnlyCollection<LaptopPL>>(laptops);

            return Ok(result);
        }

        [HttpPost]
        [Route("CreateLaptop")]
        public async Task<IActionResult> CreateLaptopAsync([FromBody] LaptopPL model)
        {
            if (ModelState.IsValid)
            {
                var laptop = _mapper.Map<LaptopBL>(model);
                var result = await _laptopService.CreateAsync(laptop);

                return Ok(result);
            }

            return BadRequest(GeneralConfiguration.InvalidModel);
        }

        [HttpPut]
        [Route("UpdateLaptop")]
        public async Task<IActionResult> UpdateLaptopAsync([FromBody] LaptopPL model)
        {
            if (ModelState.IsValid)
            {
                var laptop = _mapper.Map<LaptopBL>(model);
                var result = await _laptopService.UpdateAsync(laptop);

                if (result == false)
                    return NotFound();

                return Ok(result);
            }

            return BadRequest(GeneralConfiguration.InvalidModel);
        }

        [HttpDelete]
        [Route("DeleteLaptop")]
        public async Task<IActionResult> DeleteLaptopAsync([FromBody] LaptopPL model)
        {
            var result = await _laptopService.DeleteAsync(model.Id);

            if (result == false)
                return NotFound();

            return Ok(result);
        }
    }
}
