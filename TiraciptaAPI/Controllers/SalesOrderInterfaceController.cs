using Microsoft.AspNetCore.Mvc;
using TiraciptaAPI.Business_Logic.Services;
using TiraciptaAPI.Models;

namespace TiraciptaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalesOrderInterfaceController : ControllerBase
    {
        private readonly ISalesOrderInterfaceService _service;
        public SalesOrderInterfaceController(ISalesOrderInterfaceService service)
        {
            _service = service;
        }

        [HttpPost("CreateSoInterface")]
        public IActionResult CreateSoInterface(SalesOrderInterface SoInterface)
        {
            if(SoInterface == null)
            {
                return BadRequest(ModelState);
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                if (_service.CreateSoInterface(SoInterface))
                {
                    return Ok("Sales Order Interface Created Successfully.");
                }
                else
                {
                    return BadRequest("Failed To Insert Sales Order Interface.");
                }
            }catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }
    }
}
