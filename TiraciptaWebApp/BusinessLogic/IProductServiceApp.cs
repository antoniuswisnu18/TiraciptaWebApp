using TiraciptaWebApp.Models;

namespace TiraciptaWebApp.BusinessLogic
{
    public interface IProductServiceApp
    {
        Task<IEnumerable<ProductModel>> GetAllProducts();
    }
}
