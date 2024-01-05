using TiraciptaAPI.Models;

namespace TiraciptaAPI.Business_Logic.Repositories
{
    public interface ISalesOrderRepo
    {
        void CreateSalesOrder(SalesOrder salesOrder);

        string GenerateNextSalesOrder();
    }
}
