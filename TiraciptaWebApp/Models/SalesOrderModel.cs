namespace TiraciptaWebApp.Models
{
    public class SalesOrderModel
    {
        public DateTime OrderDate { get; set; }

        public string SalesOrderNo { get; set; } = null!;

        public string CustCode { get; set; } = null!;

        public string ProductCode { get; set; } = null!;

        public int Qty { get; set; }

        public decimal Price { get; set; }
    }
}
