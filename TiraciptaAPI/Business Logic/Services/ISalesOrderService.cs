using TiraciptaAPI.Models;

namespace TiraciptaAPI.Business_Logic.Services
{
    public interface ISalesOrderService
    {
        public bool CreateSalesOrder(SalesOrder salesOrder);
        public string GenerateNextSalesOrderNo();
    }
}
