using System.Collections.Generic;
using UniversityAppData.Model;

namespace UniversityAppData.IRepository
{
    public interface IGroup
    {
        bool AddNewGroup(Groups group);

        Groups GetRecordById(int id);

        List<Groups> GetAllGroupRecords();

        bool UpdateThisGroup(Groups group);

        bool DeleteThisGroup(int id);
    }
}