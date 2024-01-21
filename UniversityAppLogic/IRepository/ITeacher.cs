using System.Collections;
using System.Collections.Generic;
using UniversityAppData.Model;

namespace UniversityAppData.IRepository
{
    public interface ITeacher
    {
        bool AddNewTeacher(Teacher teacher);

        List<Courses> GetAllCoursesByID(int id);

        Teacher GetRecordById(int id);

        List<Teacher> GetAllTeachersName();

        IEnumerable GetAllTeacherRecords();

        bool UpdateThisTeacher(Teacher teacher);

        bool DeleteThisTeacher(int id);
    }
}