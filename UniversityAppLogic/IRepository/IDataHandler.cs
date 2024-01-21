using System.Collections;
using System.Collections.Generic;

namespace UniversityAppData.IRepository
{
    public interface IGenericDataHandler
    {
        bool AddNewEntity(object model);

        object GetRecordBy(int id);

        IEnumerable<object> GetAllModelName();

        IEnumerable GetAllRecords();

        bool UpdateThisModel<T>(object model);

        bool DeleteThisModelBy(object model);

        bool DeleteThisModelBy(int id);
    }
}