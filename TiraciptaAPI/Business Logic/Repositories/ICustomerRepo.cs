using TiraciptaAPI.Models;

namespace TiraciptaAPI.Business_Logic.Repositories
{
    public interface ICustomerRepo
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(int id);
        void Create(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
