namespace TiraciptaWebApp.Models
{
    public class SalesOrderViewModel
    {
        public DateTime OrderDate { get; set; } = DateTime.Now.Date;
        public IEnumerable<CustomerModel> Customers { get; set; }
        public IEnumerable<ProductModel> Products { get; set; }
        public string SalesOrderNo { get; set; }
        public int Qty { get; set; }

        public decimal Price { get; set; }
    }
}
