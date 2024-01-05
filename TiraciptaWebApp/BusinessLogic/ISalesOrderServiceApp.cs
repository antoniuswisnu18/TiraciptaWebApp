using Microsoft.AspNetCore.Mvc;
using TiraciptaWebApp.Models;

namespace TiraciptaWebApp.BusinessLogic
{
    public interface ISalesOrderServiceApp
    {
        Task<IEnumerable<SalesOrderModel>> GetAllSalesOrder();
        Task<bool> CreateSalesOrder([FromBody] Dictionary<string, object> data);

        Task<string> GenerateSalesOrderNo();
    }
}
