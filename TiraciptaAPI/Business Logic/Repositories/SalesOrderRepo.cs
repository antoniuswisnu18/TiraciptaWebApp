using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TiraciptaAPI.Models;

namespace TiraciptaAPI.Business_Logic.Repositories
{
    public class SalesOrderRepo : ISalesOrderRepo
    {
        private readonly DbTesWisnuContext _db;
        public SalesOrderRepo(DbTesWisnuContext db)
        {
            _db = db;
        }
        public void CreateSalesOrder(SalesOrder salesOrder)
        {
            _db.Database.ExecuteSqlRaw("EXEC CreateSalesOrder @OrderDate, @SalesOrderNo, @CustCode, @ProductCode, @Qty, @Price",
            new SqlParameter("@OrderDate", salesOrder.OrderDate),
            new SqlParameter("@SalesOrderNo", salesOrder.SalesOrderNo),
            new SqlParameter("@CustCode", salesOrder.CustCode),
            new SqlParameter("@ProductCode", salesOrder.ProductCode),
            new SqlParameter("@Qty", salesOrder.Qty),
            new SqlParameter("@Price", salesOrder.Price));
            _db.SaveChanges();
        }

        public string GenerateNextSalesOrder()
        {
            string latestSalesOrder = _db.SalesOrders
                                        .OrderByDescending(so => so.SalesOrderNo)
                                        .Select(so => so.SalesOrderNo)
                                        .FirstOrDefault();

            return latestSalesOrder;
        }
    }
}
