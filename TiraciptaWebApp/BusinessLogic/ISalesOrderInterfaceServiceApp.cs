using Microsoft.AspNetCore.Mvc;
using TiraciptaWebApp.Models;

namespace TiraciptaWebApp.BusinessLogic
{
    public interface ISalesOrderInterfaceServiceApp
    {
        Task<bool> CreateSoInterface(JsonRequestModel data);
    }
}
