using System.Collections.Generic;
using UniversityAppData.Model;

namespace UniversityAppData.IRepository
{
    public interface ICoursesTime
    {
        bool AddNewSelectedCourse(CoursesTime SelectedCourses);

        CoursesTime GetRecordById(int id);

        bool AddListOfNewSelectedCourses(List<CoursesTime> SelectedCourses);

        List<CoursesTime> GetAllSelectedCoursesRecords();

        bool UpdateThisCourses(CoursesTime SelectedCourse);

        bool DeleteThisSelectedCourse(int id);
    }
}