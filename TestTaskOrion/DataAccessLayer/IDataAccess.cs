using System.Collections.Generic;
using TestTaskOrion.Model;

namespace TestTaskOrion.DataAccessLayer
{
    public interface IDataAccess
    {
        List<Service> GetServices();
        List<Tariff> GetTariffs();
        bool SaveAppeal(Appeal appeal);
        bool SaveApplication(Application application);
    }
}
