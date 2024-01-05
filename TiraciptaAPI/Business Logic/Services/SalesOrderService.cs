using TiraciptaAPI.Business_Logic.Repositories;
using TiraciptaAPI.Models;

namespace TiraciptaAPI.Business_Logic.Services
{
    public class SalesOrderService : ISalesOrderService
    {
        private readonly ISalesOrderRepo _repo;
        public SalesOrderService(ISalesOrderRepo repo)
        {
            _repo = repo;
        }
        public bool CreateSalesOrder(SalesOrder salesOrder)
        {
            try
            {
                _repo.CreateSalesOrder(salesOrder);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string GenerateNextSalesOrderNo()
        {
            int nextSalesOrderCounter = 1;
            var latestSalesOrder = _repo.GenerateNextSalesOrder();
            if (!string.IsNullOrEmpty(latestSalesOrder) && latestSalesOrder.Length >= 5)
            {
                string lastThreeDigits = latestSalesOrder.Substring(latestSalesOrder.Length - 3);
                if (int.TryParse(lastThreeDigits, out int lastNumber))
                {
                    nextSalesOrderCounter = lastNumber + 1;
                }
            }
            string nextSalesOrderNo = $"SO{nextSalesOrderCounter:D3}";
            return nextSalesOrderNo;
        }
    }
}
