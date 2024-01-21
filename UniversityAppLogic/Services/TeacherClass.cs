using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UniversityAppData.Model;

namespace UniversityAppData.Services
{
    public class TeacherClass : GenericDataBaseClass<Teacher>
    {
        private UniversityDB_AdvancedEntities _Context;

        public TeacherClass(UniversityDB_AdvancedEntities ContextModel) : base(ContextModel)
        {
            _Context = ContextModel;
        }

        public override IEnumerable GetAllRecords()
        {
            return _Dbset.Include(model => model.Groups).Include(model => model.Teacher_Degree).ToList();
        }

        public int Compare(Teacher x, Teacher y)
        {
            return x.Teacher_LastName.CompareTo(y.Teacher_LastName);
        }

        public bool DeleteThisTeacher(int id)
        {
            _Context.Teacher.Remove(GetRecordById(id));
            return true;
        }

        public List<Courses> GetAllCoursesByID(int id)
        {
            Teacher T = new Teacher();
            T = _Context.Teacher.Single(n => n.Teacher_Id == id);
            List<Courses> temp = new List<Courses>();
            return temp;
        }

        public Teacher GetRecordById(int id)
        {
            return _Context.Teacher.First(m => m.Teacher_Id == id);
        }
    }
}