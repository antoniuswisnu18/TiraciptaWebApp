using Microsoft.AspNetCore.Mvc;
using TiraciptaAPI.Business_Logic.Services;
using TiraciptaWebApp.BusinessLogic;
using TiraciptaWebApp.Models;

namespace TiraciptaWebApp.Controllers
{
    public class SalesOrderAppController : Controller
    {
        private readonly ISalesOrderServiceApp _service;
        private readonly ICustomerServiceApp _customerService;
        private readonly IProductServiceApp _productService;
        private readonly ISalesOrderInterfaceServiceApp _SoInterfaceService;

        public SalesOrderAppController(ISalesOrderServiceApp service, ICustomerServiceApp customerService, 
            IProductServiceApp productService, ISalesOrderInterfaceServiceApp SoInterfaceService)
        {
            _service = service;
            _customerService = customerService;
            _productService = productService;
            _SoInterfaceService = SoInterfaceService;
        }
        
        public async Task<IActionResult> GetAllSalesOrder()
        {
            return View();
        }

        //GET
        public async Task<IActionResult> CreateSalesOrder()
        {
            var viewModel = new SalesOrderViewModel()
            {
                SalesOrderNo = await _service.GenerateSalesOrderNo(),
                Customers = await _customerService.GetCustomers(),
                Products = await _productService.GetAllProducts(),
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSalesOrder(SalesOrderViewModel salesOrder, string customerId, 
            string productId)
        {
            var SoBody = new Dictionary<string, object>()
            {
                {"orderDate", salesOrder.OrderDate },
                {"salesOrderNo", salesOrder.SalesOrderNo },
                {"custCode", customerId },
                {"productCode", productId },
                {"qty",salesOrder.Qty },
                {"price", salesOrder.Price }
            };

            var SoInterfaceBody = new JsonRequestModel
            {
                salesOrderNo = salesOrder.SalesOrderNo,
                custId = customerId,
                orderDetail = new OrderDetail
                {
                    productCode = productId,
                    qty = salesOrder.Qty
                }
            };


            if(await _service.CreateSalesOrder(SoBody))
            {
                //if(await _SoInterfaceService.CreateSoInterface(SoInterfaceBody))
                //{
                    ViewBag.SuccessMessage = "Data has been inserted Successfully.";
                    var viewModel = new SalesOrderViewModel()
                    {
                        SalesOrderNo = await _service.GenerateSalesOrderNo(),
                        Customers = await _customerService.GetCustomers(),
                        Products = await _productService.GetAllProducts(),
                    };
                    return View(viewModel);
                //}
                return View("Error");
            }
            else
            {
                return View("Error");
            }
        }
    }
}
