using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UniversityAppData.Model;

namespace UniversityAppData.Services
{
    internal class MajorsClass : IRepository.IMajors, IComparer<Majors>
    {
        private UniversityDB_AdvancedEntities _Context;

        public MajorsClass(UniversityDB_AdvancedEntities Context)
        {
            _Context = Context;
        }

        public bool AddNewMajors(Model.Majors major)
        {
            try
            {
                _Context.Majors.Add(major);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int Compare(Majors x, Majors y)
        {
            return x.Major_Name.CompareTo(y.Major_Name);
        }

        public bool DeleteThisMajors(int id)
        {
            _Context.Majors.Remove(GetRecordById(id));
            return true;
        }

        public List<Majors> GetAllMajorsName()
        {
            return _Context.Majors.ToList();
        }

        public IEnumerable GetAllMajorsRecords()
        {
            return _Context.Majors.Select(Q => new
            {
                Q.Major_ID,
                Q.Major_Name,
                Q.Groups.Group_Name,
                Q.Levels.Level_Name
            }).ToList();
        }

        public Model.Majors GetRecordById(int id)
        {
            return _Context.Majors.First(m => m.Major_ID == id);
        }

        public bool UpdateThisMajors(Model.Majors major)
        {
            try
            {
                _Context.Entry(major).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}