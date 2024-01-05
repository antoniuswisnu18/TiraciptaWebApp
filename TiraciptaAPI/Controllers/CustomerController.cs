using Microsoft.AspNetCore.Mvc;
using TiraciptaAPI.Business_Logic.Services;

namespace TiraciptaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("GetAllCustomers")]
        public IActionResult Get()
        {
            var customers = _customerService.GetCustomers();
            return Ok(customers);
        }
    }
}
