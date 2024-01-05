using Microsoft.AspNetCore.Mvc;
using TiraciptaWebApp.BusinessLogic;

namespace TiraciptaWebApp.Controllers
{
    public class CustomerAppController : Controller
    {
        private readonly ICustomerServiceApp _service;
        public CustomerAppController(ICustomerServiceApp service)
        {
            _service = service;
        }


        public async Task<IActionResult> Index()
        {
            var recipes = await _service.GetCustomers();
            return View(recipes); 
        }
    }
}
