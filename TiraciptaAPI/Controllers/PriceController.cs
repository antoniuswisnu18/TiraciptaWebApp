using Microsoft.AspNetCore.Mvc;
using TiraciptaAPI.Business_Logic.Services;

namespace TiraciptaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PriceController : ControllerBase
    {
        private readonly IPriceService _priceService;
        public PriceController(IPriceService priceService)
        {
            _priceService = priceService;
        }
        [HttpGet("GetAllPrices")]
        public IActionResult GetPrices()
        {
            var output = _priceService.GetPrices();
            return Ok(output);
        }

        [HttpGet("GetPriceForProduct/{productId}")]
        public IActionResult GetPrice(string productId)
        {
            var output = _priceService.GetByProductId(productId);
            return Ok(output);
        }
    }
}
