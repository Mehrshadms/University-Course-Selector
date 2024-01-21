using System.Collections.Generic;
using UniversityAppData.Model;

namespace UniversityAppData.IRepository
{
    public interface ITerm
    {
        bool AddNewTerm(Term term);

        Term GetRecordById(int id);

        List<Term> GetAllTermRecords();

        bool UpdateThisTerm(Term term);

        bool DeleteThisTerm(int id);
    }
}