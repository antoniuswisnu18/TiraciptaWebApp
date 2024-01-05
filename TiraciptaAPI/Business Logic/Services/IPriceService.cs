using TiraciptaAPI.Models;

namespace TiraciptaAPI.Business_Logic.Services
{
    public interface IPriceService
    {
        public IEnumerable<Price> GetPrices();
        public Price GetByProductId(string productId);
        public Price Create(Price price);
        public Price Update(Price price);
        public bool Delete(Price price);
    }
}
