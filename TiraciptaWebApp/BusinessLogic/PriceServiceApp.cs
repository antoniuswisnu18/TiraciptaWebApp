namespace TiraciptaWebApp.BusinessLogic
{
    public class PriceServiceApp : IPriceServiceApp
    {
        private readonly HttpClient _httpClient;
        public PriceServiceApp(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient("TiraciptaAPI");
        }
        public async Task<decimal> GetPriceForProduct(string productId, DateTime currentDate)
        {
            throw new NotImplementedException();
        }
    }
}
