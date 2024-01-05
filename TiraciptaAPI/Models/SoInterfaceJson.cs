namespace TiraciptaAPI.Models
{
    public class SoInterfaceJson
    {
        public class OrderDetail
        {
            public string productCode { get; set; }
            public int qty { get; set; }
        }
        public string salesOrderNo { get; set; }
        public string custId { get; set; }
        public OrderDetail orderDetail { get; set; }
    }
}
