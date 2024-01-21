using System.Collections;
using System.Collections.Generic;
using UniversityAppData.Model;

namespace UniversityAppData.IRepository
{
    public interface ICourses
    {
        bool AddNewCourses(Courses Course);

        Courses GetRecordById(int id);

        List<Courses> GetAllCoursesName();

        IEnumerable GetAllCoursesRecords();

        bool UpdateThisCourses(Courses Course);

        bool DeleteThisCourses(int id);
    }
}