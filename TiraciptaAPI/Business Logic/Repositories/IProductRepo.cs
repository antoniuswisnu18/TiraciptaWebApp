using TiraciptaAPI.Models;

namespace TiraciptaAPI.Business_Logic.Repositories
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Create(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
