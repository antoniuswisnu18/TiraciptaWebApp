using Microsoft.AspNetCore.Mvc;
using TiraciptaAPI.Business_Logic.Services;
using TiraciptaAPI.Models;

namespace TiraciptaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalesOrderController : ControllerBase
    {
        private readonly ISalesOrderService _service;
        public SalesOrderController(ISalesOrderService service)
        {
            _service = service;
        }
        [HttpPost("CreateSalesOrder")]
        public IActionResult CreateSalesOrder([FromBody] SalesOrder salesOrder)
        {
            if(salesOrder == null)
            {
                return BadRequest(ModelState);
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                if (_service.CreateSalesOrder(salesOrder))
                {
                    return Ok("Sales order inserted successfully.");
                }
                else
                {
                    return BadRequest("Failed To Insert Sales Order");
                }
                
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        [HttpGet("GenerateSoNumber")]
        public IActionResult GenerateNextSalesOrderNo()
        {
            var output = _service.GenerateNextSalesOrderNo();
            return Ok(output);
        }
    }
}
