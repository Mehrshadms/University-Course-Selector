using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UniversityAppData.Model;

namespace UniversityAppData.Services
{
    internal class GroupsClass : IRepository.IGroup
    {
        private UniversityDB_AdvancedEntities _Context;

        public GroupsClass(UniversityDB_AdvancedEntities Context)
        {
            _Context = Context;
        }

        public bool AddNewGroup(Model.Groups group)
        {
            try
            {
                _Context.Groups.Add(group);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteThisGroup(int id)
        {
            _Context.Groups.Remove(GetRecordById(id));
            return true;
        }

        public List<Model.Groups> GetAllGroupRecords()
        {
            return _Context.Groups.ToList();
        }

        public Model.Groups GetRecordById(int id)
        {
            return _Context.Groups.First(m => m.Group_ID == id);
        }

        public bool UpdateThisGroup(Model.Groups group)
        {
            try
            {
                _Context.Entry(group).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}