using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UniversityAppData.Model;

namespace UniversityAppData.Services
{
    internal class TermClass : IRepository.ITerm, IComparer<Term>
    {
        private UniversityDB_AdvancedEntities _Context;

        public TermClass(UniversityDB_AdvancedEntities Context)
        {
            _Context = Context;
        }

        public bool AddNewTerm(Model.Term term)
        {
            try
            {
                _Context.Term.Add(term);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int Compare(Term x, Term y)
        {
            return x.Term_Name.CompareTo(y.Term_Name);
        }

        public bool DeleteThisTerm(int id)
        {
            _Context.Term.Remove(GetRecordById(id));
            return true;
        }

        public List<Model.Term> GetAllTermRecords()
        {
            List<Term> ListToReturn = _Context.Term.ToList();
            ListToReturn.Sort(Compare);
            return ListToReturn;
        }

        public Term GetRecordById(int id)
        {
            return _Context.Term.First(m => m.Term_ID == id);
        }

        public bool UpdateThisTerm(Term term)
        {
            try
            {
                _Context.Entry(term).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}