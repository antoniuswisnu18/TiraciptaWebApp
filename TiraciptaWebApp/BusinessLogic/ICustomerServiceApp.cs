using Microsoft.AspNetCore.Mvc;
using TiraciptaWebApp.Models;

namespace TiraciptaWebApp.BusinessLogic
{
    public interface ICustomerServiceApp
    {
        Task<bool> CreateCustomer([FromBody] Dictionary<string, object> data);
        Task<IEnumerable<CustomerModel>> GetCustomers();
        Task<CustomerModel> GetCustomerById(int id);
        Task<CustomerModel> UpdateCustomer(int id, [FromBody] Dictionary<string, object> fields);
        Task<bool> DeleteCustomer(int id);

        
    }
}
