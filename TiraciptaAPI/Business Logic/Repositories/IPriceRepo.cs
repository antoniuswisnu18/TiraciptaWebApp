using TiraciptaAPI.Models;

namespace TiraciptaAPI.Business_Logic.Repositories
{
    public interface IPriceRepo
    {
        IEnumerable<Price> GetAll();
        Price GetByProductId(string productId, DateTime currentDate);
        void Create(Price price);
        void Update(Price price);
        void Delete(Price price);
    }
}
