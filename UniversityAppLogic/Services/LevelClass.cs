using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UniversityAppData.Model;

namespace UniversityAppData.Services
{
    internal class LevelClass : IRepository.ILevel
    {
        private UniversityDB_AdvancedEntities _Context;

        public LevelClass(UniversityDB_AdvancedEntities Context)
        {
            _Context = Context;
        }

        public bool AddNewLevel(Levels level)
        {
            try
            {
                _Context.Levels.Add(level);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteThisLevel(int id)
        {
            _Context.Levels.Remove(GetRecordById(id));
            return true;
        }

        public List<Levels> GetAllLevelRecords()
        {
            return _Context.Levels.ToList();
        }

        public Levels GetRecordById(int id)
        {
            return _Context.Levels.First(m => m.Level_ID == id);
        }

        public bool UpdateThisLevel(Levels level)
        {
            try
            {
                _Context.Entry(level).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}