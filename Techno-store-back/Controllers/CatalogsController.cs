using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Techno_store_back.BL.Interfaces.Services;
using Techno_store_back.BL.Models.DTOs;
using Techno_store_back.Configuration;
using Techno_store_back.Web.Models.DTOs;

namespace Techno_store_back.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogsController : ControllerBase
    {
        private readonly ICatalogService _catalogService;
        private readonly IMapper _mapper;

        public CatalogsController(ICatalogService catalogService, IMapper mapper)
        {
            _catalogService = catalogService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetCatalogs")]
        public async Task<IActionResult> GetAllAsync()
        {
            var catalogs = await _catalogService.GetAllAsync();
            var result = _mapper.Map<IReadOnlyCollection<CatalogPL>>(catalogs);

            return Ok(result);
        }

        [HttpPost]
        [Route("CreateCatalog")]
        public async Task<IActionResult> CreateAsync([FromBody] CatalogPL model)
        {
            if (ModelState.IsValid)
            {
                var catalog = _mapper.Map<CatalogBL>(model);
                var result = await _catalogService.CreateAsync(catalog);

                return Ok(result);
            }

            return BadRequest(GeneralConfiguration.InvalidModel);
        }

        [HttpPut]
        [Route("UpdateCatalog")]
        public async Task<IActionResult> UpdateAsync([FromBody] CatalogPL model)
        {
            if (ModelState.IsValid)
            {
                var catalog = _mapper.Map<CatalogBL>(model);
                var result = await _catalogService.UpdateAsync(catalog);

                if (result == false)
                    return NotFound();

                return Ok(result);
            }

            return BadRequest(GeneralConfiguration.InvalidModel);
        }

        [HttpDelete]
        [Route("DeleteCatalog")]
        public async Task<IActionResult> DeleteAsync([FromBody] CatalogPL model)
        {
            var result = await _catalogService.DeleteAsync(model.Id);

            if (result == false)
                return NotFound();

            return Ok(result);
        }
    }
}
