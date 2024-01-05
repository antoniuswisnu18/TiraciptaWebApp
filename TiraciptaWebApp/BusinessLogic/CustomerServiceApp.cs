using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using TiraciptaWebApp.Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace TiraciptaWebApp.BusinessLogic
{
    public class CustomerServiceApp : ICustomerServiceApp
    {
        private readonly HttpClient _httpClient;
        public CustomerServiceApp(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient("TiraciptaAPI");
        }
        public Task<bool> CreateCustomer([FromBody] Dictionary<string, object> data)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerModel> GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CustomerModel>> GetCustomers()
        {
            var response = await _httpClient.GetAsync($"api/Customer/GetAllCustomers");
            if (response.IsSuccessStatusCode)
            {
                var stringJson = await response.Content.ReadAsStringAsync();
                var deserializeJson = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<JsonElement>>(stringJson);
                var customers = new List<CustomerModel>();
                foreach(var item in deserializeJson)
                {
                    CustomerModel model = new CustomerModel()
                    {
                        CustId = item.GetProperty("custId").ToString(),
                        CustName = item.GetProperty("custName").ToString()
                    };
                    customers.Add(model);
                }
                return customers;
            }
            return new List<CustomerModel>();
        }

        public Task<CustomerModel> UpdateCustomer(int id, [FromBody] Dictionary<string, object> fields)
        {
            throw new NotImplementedException();
        }
    }
}
