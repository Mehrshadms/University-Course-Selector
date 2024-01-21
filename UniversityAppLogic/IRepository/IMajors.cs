using System.Collections;
using System.Collections.Generic;
using UniversityAppData.Model;

namespace UniversityAppData.IRepository
{
    public interface IMajors
    {
        bool AddNewMajors(Majors major);

        Majors GetRecordById(int id);

        List<Majors> GetAllMajorsName();

        IEnumerable GetAllMajorsRecords();

        bool UpdateThisMajors(Majors major);

        bool DeleteThisMajors(int id);
    }
}