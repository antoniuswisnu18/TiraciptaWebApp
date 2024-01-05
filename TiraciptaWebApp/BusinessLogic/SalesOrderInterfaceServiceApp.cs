using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;
using TiraciptaWebApp.Models;

namespace TiraciptaWebApp.BusinessLogic
{
    public class SalesOrderInterfaceServiceApp : ISalesOrderInterfaceServiceApp
    {
        private readonly HttpClient _httpClient;
        public SalesOrderInterfaceServiceApp(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient("TiraciptaAPI");
        }

        public async Task<bool> CreateSoInterface(JsonRequestModel jsonObj)
        {
            try
            {
                var orderDetail = new Dictionary<string, object>
                {
                    {"productCode", jsonObj.orderDetail.productCode.ToString() },
                    {"qty", jsonObj.orderDetail.qty.ToString() }
                };

                var Payload = new Dictionary<string, object>
                {
                    { "salesOrderNo", jsonObj.salesOrderNo.ToString()},
                    {"custId", jsonObj.custId.ToString() },
                    {"orderDetail",  JsonConvert.SerializeObject(orderDetail)}
                };

                var data = new Dictionary<string, object>
                {
                    {"salesOrderNo",jsonObj.salesOrderNo.ToString() },
                    {"payload", JsonConvert.SerializeObject(Payload) }  
                };

                var requestBody = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync($"api/SalesOrderInterface/CreateSoInterface", requestBody);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
