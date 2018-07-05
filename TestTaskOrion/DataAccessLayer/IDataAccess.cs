using System.Collections.Generic;
using TestTaskOrion.Model;

namespace TestTaskOrion.DataAccessLayer
{
    public interface IDataAccess
    {
        List<Service> GetServices();
        bool SaveAppeal(Appeal appeal);
        bool SaveApplication(Application application);
    }
}
