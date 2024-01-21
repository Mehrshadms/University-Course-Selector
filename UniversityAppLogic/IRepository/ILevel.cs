using System.Collections.Generic;
using UniversityAppData.Model;

namespace UniversityAppData.IRepository
{
    public interface ILevel
    {
        bool AddNewLevel(Levels level);

        Levels GetRecordById(int id);

        List<Levels> GetAllLevelRecords();

        bool UpdateThisLevel(Levels level);

        bool DeleteThisLevel(int id);
    }
}