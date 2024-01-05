using TiraciptaAPI.Business_Logic.Services;
using TiraciptaAPI.Models;

namespace TiraciptaAPI.Business_Logic.Repositories
{
    public class PriceRepo : IPriceRepo
    {
        private readonly DbTesWisnuContext _db;
        public PriceRepo(DbTesWisnuContext db)
        {

            _db = db;

        }
        public void Create(Price price)
        {
            throw new NotImplementedException();
        }

        public void Delete(Price price)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Price> GetAll()
        {
            var prices = _db.Set<Price>().ToList();
            return prices;
        }

        public Price GetByProductId(string productId, DateTime currentDate)
        {
            var price = _db.Set<Price>()
                .Where(p => p.ProductCode == productId && p.PriceValidateFrom <= currentDate && currentDate <= p.PriceValidateTo)
                .FirstOrDefault();

            return price;

        }

        public void Update(Price price)
        {
            throw new NotImplementedException();
        }
    }
}
