using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Techno_store_back.BL.Interfaces.Services;
using Techno_store_back.BL.Models.DTOs;
using Techno_store_back.Configuration;
using Techno_store_back.Web.Models.DTOs;

namespace Techno_store_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LaptopController : ControllerBase
    {
        private readonly ILaptopService _laptopService;
        private readonly IMapper _mapper;

        public LaptopController(ILaptopService laptopService, IMapper mapper)
        {
           _laptopService = laptopService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAllLaptops")]
        public async Task<IActionResult> GetAllLaptopsAsync()

        {
            if (ModelState.IsValid)
            {
                var laptops = await _laptopService.GetAllAsync();
                var result = _mapper.Map<IReadOnlyCollection<LaptopPL>>(laptops);

                return Ok(result);
            }

            return BadRequest(GeneralConfiguration.InvalidModel);
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
    }
}
