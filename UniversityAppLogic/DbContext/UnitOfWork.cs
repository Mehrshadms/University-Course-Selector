using System;
using UniversityAppData.Model;
using UniversityAppData.Services;

namespace UniversityAppData.DbContext
{
    public class UnitOfWork : IDisposable
    {
        public void Save()
        {
            _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }

        private UniversityDB_AdvancedEntities _Context = new UniversityDB_AdvancedEntities();
        

        #region Dynamic Generic

        //private IGenericDataHandler _IGenericDataHandler;

        //private bool IsGenericDataNull()
        //{
        //    if (_IGenericDataHandler == null)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public IGenericDataHandler Term
        //{
        //    get
        //    {
        //        if (IsGenericDataNull() || typeof(GenericDataBaseClass<>) != typeof(GenericDataBaseClass<Term>))
        //        {
        //            _IGenericDataHandler = new GenericDataBaseClass<Term>(_Context);
        //        }
        //        return _IGenericDataHandler;
        //    }
        //}

        //public IGenericDataHandler GenericDataHandler
        //{
        //    get
        //    {
        //        if (_IGenericDataHandler == null)
        //        {
        //            //_IGenericDataHandler = new Services.GenericDataBaseClass<>(_Context);
        //        }
        //        return _IGenericDataHandler;
        //    }
        //}

        //public IGenericDataHandler Group
        //{
        //    get
        //    {
        //        if (IsGenericDataNull() || typeof(GenericDataBaseClass<>) != typeof(GenericDataBaseClass<Groups>))
        //        {
        //            _IGenericDataHandler = new GenericDataBaseClass<Groups>(_Context);
        //        }
        //        return _IGenericDataHandler;
        //    }
        //}

        //public IGenericDataHandler Level
        //{
        //    get
        //    {
        //        if (IsGenericDataNull() || typeof(GenericDataBaseClass<>) != typeof(GenericDataBaseClass<Levels>))
        //        {
        //            _IGenericDataHandler = new GenericDataBaseClass<Levels>(_Context);
        //        }
        //        return _IGenericDataHandler;
        //    }
        //}

        //public IGenericDataHandler Degree
        //{
        //    get
        //    {
        //        if (IsGenericDataNull() || typeof(GenericDataBaseClass<>) != typeof(GenericDataBaseClass<Teacher_Degree>))
        //        {
        //            _IGenericDataHandler = new GenericDataBaseClass<Teacher_Degree>(_Context);
        //        }
        //        return _IGenericDataHandler;
        //    }
        //}

        //public IGenericDataHandler Major
        //{
        //    get
        //    {
        //        if (IsGenericDataNull() || typeof(GenericDataBaseClass<>) != typeof(GenericDataBaseClass<Majors>))
        //        {
        //            _IGenericDataHandler = new GenericDataBaseClass<Majors>(_Context);
        //        }
        //        return _IGenericDataHandler;
        //    }
        //}

        //public IGenericDataHandler Courses
        //{
        //    get
        //    {
        //        if (IsGenericDataNull() || typeof(GenericDataBaseClass<>) != typeof(GenericDataBaseClass<Courses>))
        //        {
        //            _IGenericDataHandler = new Services.GenericDataBaseClass<Courses>(_Context);
        //        }
        //        return _IGenericDataHandler;
        //    }
        //}

        //public IGenericDataHandler CoursesTime
        //{
        //    get
        //    {
        //        if (IsGenericDataNull())
        //        {
        //            _IGenericDataHandler = new Services.GenericDataBaseClass<CoursesTime>(_Context);
        //        }
        //        return _IGenericDataHandler;
        //    }
        //}

        //public IGenericDataHandler Teacher
        //{
        //    get
        //    {
        //        if (IsGenericDataNull())
        //        {
        //            _IGenericDataHandler = new Services.GenericDataBaseClass<Teacher>(_Context);
        //        }
        //        return _IGenericDataHandler;
        //    }
        //}

        #endregion Dynamic Generic

        private TeacherClass _TeacherRep;

        public TeacherClass TeacherRep
        {
            get
            {
                if (_TeacherRep == null)
                {
                    _TeacherRep = new TeacherClass(_Context);
                }
                return _TeacherRep;
            }
        }

        private GenericDataBaseClass<Term> _TermRep;

        public GenericDataBaseClass<Term> TermRep
        {
            get
            {
                if (_TermRep == null)
                {
                    _TermRep = new GenericDataBaseClass<Term>(_Context);
                }
                return _TermRep;
            }
        }

        private GenericDataBaseClass<Groups> _GroupsRep;

        public GenericDataBaseClass<Groups> GroupsRep
        {
            get
            {
                if (_GroupsRep == null)
                {
                    _GroupsRep = new GenericDataBaseClass<Groups>(_Context);
                }
                return _GroupsRep;
            }
        }

        private GenericDataBaseClass<Levels> _LevelsRep;

        public GenericDataBaseClass<Levels> LevelsRep
        {
            get
            {
                if (_LevelsRep == null)
                {
                    _LevelsRep = new GenericDataBaseClass<Levels>(_Context);
                }
                return _LevelsRep;
            }
        }

        private GenericDataBaseClass<Majors> _MajorsRep;

        public GenericDataBaseClass<Majors> MajorsRep
        {
            get
            {
                if (_MajorsRep == null)
                {
                    _MajorsRep = new GenericDataBaseClass<Majors>(_Context);
                }
                return _MajorsRep;
            }
        }

        private GenericDataBaseClass<Courses> _CoursesRep;

        public GenericDataBaseClass<Courses> CoursesRep
        {
            get
            {
                if (_CoursesRep == null)
                {
                    _CoursesRep = new GenericDataBaseClass<Courses>(_Context);
                }
                return _CoursesRep;
            }
        }

        private GenericDataBaseClass<CoursesTime> _CoursesTimeRep;

        public GenericDataBaseClass<CoursesTime> CoursesTimeRep
        {
            get
            {
                if (_CoursesTimeRep == null)
                {
                    _CoursesTimeRep = new GenericDataBaseClass<CoursesTime>(_Context);
                }
                return _CoursesTimeRep;
            }
        }

        private GenericDataBaseClass<Teacher_Degree> _TeacherDegreeRep;

        public GenericDataBaseClass<Teacher_Degree> TeacherDegreeRep
        {
            get
            {
                if (_TeacherDegreeRep == null)
                {
                    _TeacherDegreeRep = new GenericDataBaseClass<Teacher_Degree>(_Context);
                }
                return _TeacherDegreeRep;
            }
        }
    }
}