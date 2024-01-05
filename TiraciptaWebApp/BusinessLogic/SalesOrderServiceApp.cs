using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using TiraciptaWebApp.Models;

namespace TiraciptaWebApp.BusinessLogic
{
    public class SalesOrderServiceApp : ISalesOrderServiceApp
    {
        private readonly HttpClient _httpClient;
        public SalesOrderServiceApp(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient("TiraciptaAPI");
        }

        public async Task<bool> CreateSalesOrder([FromBody] Dictionary<string, object> data)
        {
            try
            {
                var requestBody = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync($"api/SalesOrder/CreateSalesOrder", requestBody);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<string> GenerateSalesOrderNo()
        {
            var response = await _httpClient.GetAsync("/api/SalesOrder/GenerateSoNumber");
            if (response.IsSuccessStatusCode)
            {
                var stringJson = await response.Content.ReadAsStringAsync();
                return stringJson;
            }
            else
            {
                return null;
            }
        }

        public Task<IEnumerable<SalesOrderModel>> GetAllSalesOrder()
        {
            throw new NotImplementedException();
        }
    }
}
