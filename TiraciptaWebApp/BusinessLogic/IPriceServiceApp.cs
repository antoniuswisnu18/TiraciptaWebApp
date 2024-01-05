namespace TiraciptaWebApp.BusinessLogic
{
    public interface IPriceServiceApp
    {
        Task<decimal> GetPriceForProduct(string productId, DateTime currentDate);
    }
}
