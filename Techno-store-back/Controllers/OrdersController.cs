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
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrdersController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetOrders")]
        public async Task<IActionResult> GetAllAsync()
        {
            var orders = await _orderService.GetAllAsync();
            var result = _mapper.Map<IReadOnlyCollection<OrderPL>>(orders);

            return Ok(result);
        }

        [HttpPost]
        [Route("CreateOrder")]
        public async Task<IActionResult> CreateAsync([FromBody] OrderPL model)
        {
            if (ModelState.IsValid)
            {
                var order = _mapper.Map<OrderBL>(model);
                var result = await _orderService.CreateAsync(order);

                return Ok(result);
            }

            return BadRequest(GeneralConfiguration.InvalidModel);
        }

        [HttpPut]
        [Route("UpdateOrder")]
        public async Task<IActionResult> UpdateAsync([FromBody] OrderPL model)
        {
            if (ModelState.IsValid)
            {
                var order = _mapper.Map<OrderBL>(model);
                var result = await _orderService.UpdateAsync(order);

                if (result == false)
                    return NotFound();

                return Ok(result);
            }

            return BadRequest(GeneralConfiguration.InvalidModel);
        }

        [HttpDelete]
        [Route("DeleteOrder")]
        public async Task<IActionResult> DeleteAsync([FromBody] OrderPL model)
        {
            var result = await _orderService.DeleteAsync(model.Id);

            if (result == false)
                return NotFound();

            return Ok(result);
        }
    }
}
