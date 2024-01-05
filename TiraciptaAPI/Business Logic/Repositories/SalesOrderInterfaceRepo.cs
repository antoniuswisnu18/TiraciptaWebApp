using TiraciptaAPI.Models;

namespace TiraciptaAPI.Business_Logic.Repositories
{
    public class SalesOrderInterfaceRepo : ISalesOrderInterfaceRepo
    {
        private readonly DbTesWisnuContext _db;
        public SalesOrderInterfaceRepo(DbTesWisnuContext db)
        {
            _db = db;
        }

        public void CreateSoInterface(SalesOrderInterface SoInterface)
        {
            _db.Set<SalesOrderInterface>().Add(SoInterface);
            _db.SaveChanges();
        }
    }
}
