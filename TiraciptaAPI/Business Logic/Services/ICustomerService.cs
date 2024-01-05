using TiraciptaAPI.Models;

namespace TiraciptaAPI.Business_Logic.Services
{
    public interface ICustomerService
    {
        public IEnumerable<Customer> GetCustomers();
        public Customer GetById(int id);
        public Customer Create(Customer customer);
        public Customer Update(Customer customer);
        public bool Delete(Customer customer);
    }
}
