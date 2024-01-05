using Newtonsoft.Json;
using TiraciptaAPI.Business_Logic.Repositories;
using TiraciptaAPI.Models;

namespace TiraciptaAPI.Business_Logic.Services
{
    public class SalesOrderInterfaceService : ISalesOrderInterfaceService
    {
        private readonly ISalesOrderInterfaceRepo _repo;

        public SalesOrderInterfaceService(ISalesOrderInterfaceRepo repo)
        {
            _repo = repo;
        }

        public bool CreateSoInterface(SalesOrderInterface SoInterface)
        {
            try
            {
                _repo.CreateSoInterface(SoInterface);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }


    }
}
