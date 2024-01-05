using TiraciptaAPI.Business_Logic.Repositories;
using TiraciptaAPI.Models;

namespace TiraciptaAPI.Business_Logic.Services
{
    public class PriceService : IPriceService
    {
        private readonly IPriceRepo _repo;
        public PriceService(IPriceRepo repo)
        {
            _repo = repo;
        }
        public Price Create(Price price)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Price price)
        {
            throw new NotImplementedException();
        }

        public Price GetByProductId(string productId)
        {
            var currentDate = DateTime.Now;
            var price = _repo.GetByProductId(productId, currentDate);
            return price;
        }

        public IEnumerable<Price> GetPrices()
        {
            var prices = _repo.GetAll();
            return prices;
        }

        public Price Update(Price price)
        {
            throw new NotImplementedException();
        }
    }
}
