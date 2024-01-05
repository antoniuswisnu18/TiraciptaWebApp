using Microsoft.AspNetCore.Mvc;
using TiraciptaAPI.Business_Logic.Services;

namespace TiraciptaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("GetAllProducts")]
        public IActionResult GetProducts()
        {
            var output = _productService.GetProducts();
            return Ok(output);
        }
    }
}
