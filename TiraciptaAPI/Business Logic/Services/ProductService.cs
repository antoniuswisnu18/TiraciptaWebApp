using TiraciptaAPI.Business_Logic.Repositories;
using TiraciptaAPI.Models;

namespace TiraciptaAPI.Business_Logic.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _repo;
        public ProductService(IProductRepo repo)
        {
            _repo = repo;
        }
        public Product Create(Product product)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = _repo.GetAll();
            return products;
        }

        public Product Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
