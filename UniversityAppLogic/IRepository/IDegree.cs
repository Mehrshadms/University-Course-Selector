using System.Collections.Generic;
using UniversityAppData.Model;

namespace UniversityAppData.IRepository
{
    public interface IDegree
    {
        bool AddNewDegree(Teacher_Degree degree);

        Teacher_Degree GetRecordById(int id);

        List<Teacher_Degree> GetAllDegreeRecords();

        bool UpdateThisDegree(Teacher_Degree degree);

        bool DeleteThisDegree(int id);
    }
}