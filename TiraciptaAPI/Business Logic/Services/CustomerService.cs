using TiraciptaAPI.Business_Logic.Repositories;
using TiraciptaAPI.Models;

namespace TiraciptaAPI.Business_Logic.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _customerRepo;
        public CustomerService(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }
        public Customer Create(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            var output = _customerRepo.GetAll();
            return output;
        }

        public Customer Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
