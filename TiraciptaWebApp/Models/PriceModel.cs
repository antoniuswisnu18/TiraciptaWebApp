namespace TiraciptaWebApp.Models
{
    public class PriceModel
    {
        public string? ProductCode { get; set; }

        public decimal? Price { get; set; }

        public DateTime? PriceValidateFrom { get; set; }

        public DateTime? PriceValidateTo { get; set; }
    }
}
