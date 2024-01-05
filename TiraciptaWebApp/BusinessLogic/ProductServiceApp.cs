using System.Text.Json;
using TiraciptaWebApp.Models;

namespace TiraciptaWebApp.BusinessLogic
{
    public class ProductServiceApp : IProductServiceApp
    {
        private readonly HttpClient _httpClient;
        public ProductServiceApp(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient("TiraciptaAPI");
        }
        public async Task<IEnumerable<ProductModel>> GetAllProducts()
        {
            var response = await _httpClient.GetAsync($"api/Product/GetAllProducts");
            if (response.IsSuccessStatusCode)
            {
                var stringJson = await response.Content.ReadAsStringAsync();
                var deserializeJson = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<JsonElement>>(stringJson);
                var products = new List<ProductModel>();
                foreach (var item in deserializeJson)
                {
                    ProductModel model = new ProductModel()
                    {
                        ProductCode = item.GetProperty("productCode").ToString(),
                        ProductName = item.GetProperty("productName").ToString()
                    };
                    products.Add(model);
                }
                return products;
            }
            return new List<ProductModel>();
        }
    }
}
