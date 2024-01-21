using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UniversityAppData.Model;

namespace UniversityAppData.Services
{
    internal class DegreeClass : IRepository.IDegree
    {
        private UniversityDB_AdvancedEntities _Context;

        public DegreeClass(UniversityDB_AdvancedEntities Context)
        {
            _Context = Context;
        }

        public bool AddNewDegree(Teacher_Degree degree)
        {
            try
            {
                _Context.Teacher_Degree.Add(degree);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteThisDegree(int id)
        {
            _Context.Teacher_Degree.Remove(GetRecordById(id));
            return true;
        }

        public List<Teacher_Degree> GetAllDegreeRecords()
        {
            return _Context.Teacher_Degree.ToList();
        }

        public Teacher_Degree GetRecordById(int id)
        {
            return _Context.Teacher_Degree.First(m => m.Degree_ID == id);
        }

        public bool UpdateThisDegree(Teacher_Degree degree)
        {
            try
            {
                _Context.Entry(degree).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}