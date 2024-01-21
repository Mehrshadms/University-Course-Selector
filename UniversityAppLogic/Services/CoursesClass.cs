using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UniversityAppData.Model;

namespace UniversityAppData.Services
{
    internal class CoursesClass : GenericDataBaseClass<Courses>, IComparer<Courses>
    {
        private UniversityDB_AdvancedEntities _Context;
        public CoursesClass(UniversityDB_AdvancedEntities Context) : base(Context)
        {
            _Context = Context;
        }

        public bool AddNewCourses(Courses Course)
        {
            try
            {
                _Context.Courses.Add(Course);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteThisCourses(int id)
        {
            _Context.Courses.Remove(GetRecordById(id));
            return true;
        }

        public List<Courses> GetAllCoursesName()
        {
            return _Context.Courses.ToList();
        }

        public override IEnumerable GetAllRecords()
        {
            return _Dbset.Include(M => M.Majors).Include(M => M.Courses2).Include(M => M.Courses1).ToList();
        }

        public Courses GetRecordById(int id)
        {
            return _Context.Courses.First(m => m.Course_ID == id);
        }

        public bool UpdateThisCourses(Courses Course)
        {
            try
            {
                _Context.Entry(Course).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int Compare(Courses x, Courses y)
        {
            return x.Course_Name.CompareTo(y.Course_Name);
        }
    }
}