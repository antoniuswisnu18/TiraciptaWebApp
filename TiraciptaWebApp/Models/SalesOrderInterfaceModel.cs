namespace TiraciptaWebApp.Models
{
    public class SalesOrderInterfaceModel
    {
        public string? salesOrderNo { get; set; }

        public string? payload { get; set; }
    }

    public class OrderDetail
    {
        public string productCode { get; set; }
        public int qty { get; set; }
    }

    public class JsonRequestModel
    {
        public string salesOrderNo { get; set; }
        public string custId { get; set; }
        public OrderDetail orderDetail { get; set; }
    }
}
