using System.Collections;
using System.Data.Entity;
using System.Linq;
using UniversityAppData.Model;

namespace UniversityAppData.Services
{
    public class CoursesTimeClass : GenericDataBaseClass<CoursesTime>
    {
        private UniversityDB_AdvancedEntities _Context;

        public CoursesTimeClass(UniversityDB_AdvancedEntities Context) : base(Context)
        {
            _Context = Context;
        }

        public override IEnumerable GetAllRecordsBy(int term)
        {
            return _Dbset.Where(x => x.FK_Term_ID == term).Include(m => m.Courses)
                            .Include(m => m.Majors)
                            .Include(m => m.Teacher)
                            .Include(m => m.Term).ToList();
        }

        public override IEnumerable GetAllRecords()
        {
            return _Dbset.Include(m => m.Courses)
                .Include(m => m.Majors)
                .Include(m => m.Teacher)
                .Include(m => m.Term).ToList();
        }
    }
}