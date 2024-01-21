using System;
using System.Collections;
using System.Data.Entity;
using System.Linq;
using UniversityAppData.Model;

namespace UniversityAppData.Services
{
    public class GenericDataBaseClass<TEntity> where TEntity : class
    {
        public int MyProperty { get; set; }
        private UniversityDB_AdvancedEntities _Context;
        protected DbSet<TEntity> _Dbset;

        public GenericDataBaseClass(UniversityDB_AdvancedEntities Context)
        {
            _Context = Context;
            _Dbset = _Context.Set<TEntity>();
        }

        public bool AddNewEntity(object model)
        {
            try
            {
                _Dbset.Add((TEntity)model);
                return true;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public virtual IEnumerable GetAllRecordsBy(int Id)
        {
            return _Dbset.ToList();
        }

        public bool DeleteThisModelBy(TEntity Model)
        {
            if (_Context.Entry(Model).State == EntityState.Detached && Model != null)
            {
                _Dbset.Attach(Model);
            }
            try
            {
                _Dbset.Remove(Model);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool DeleteEntity(TEntity Model)
        {
            if (_Context.Entry(Model).State == EntityState.Detached)
            {
                _Dbset.Attach(Model);
            }
            try
            {
                _Dbset.Remove(Model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteThisModelBy(int id)
        {
            TEntity model = GetRecordBy(id);
            if (_Context.Entry(model).State == EntityState.Detached)
            {
                _Dbset.Attach(model);
            }
            try
            {
                _Dbset.Remove(model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public virtual IEnumerable GetAllRecords()
        {
            return _Dbset.ToList();
        }

        public virtual TEntity GetRecordBy(int Id)
        {
            return _Dbset.Find(Id);
        }

        public bool UpdateThisModel(TEntity model)
        {
            try
            {
                _Dbset.Attach(model);
                _Context.Entry(model).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}