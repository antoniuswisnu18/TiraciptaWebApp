using TiraciptaAPI.Models;

namespace TiraciptaAPI.Business_Logic.Repositories
{
    public class ProductRepo : IProductRepo
    {
        private readonly DbTesWisnuContext _db;
        public ProductRepo(DbTesWisnuContext db)
        {

            _db = db;

        }
        public void Create(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            var products = _db.Set<Product>().ToList();
            return products;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
