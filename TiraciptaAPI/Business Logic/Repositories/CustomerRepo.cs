using TiraciptaAPI.Models;

namespace TiraciptaAPI.Business_Logic.Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly DbTesWisnuContext _db;
        public CustomerRepo(DbTesWisnuContext db)
        {

            _db = db;

        }
        public void Create(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            List<Customer> output = _db.Set<Customer>().ToList();
            return output;
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
