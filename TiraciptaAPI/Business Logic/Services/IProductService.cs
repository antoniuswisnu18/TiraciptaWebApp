using TiraciptaAPI.Models;

namespace TiraciptaAPI.Business_Logic.Services
{
    public interface IProductService
    {
        public IEnumerable<Product> GetProducts();
        public Product GetById(int id);
        public Product Create(Product product);
        public Product Update(Product product);
        public bool Delete(Product product);
    }
}
