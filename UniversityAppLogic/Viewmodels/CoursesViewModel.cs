namespace UniversityAppData.Viewmodels
{
    public class CoursesViewModel
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int? PracticalHours { get; set; }
        public int? TheoryHours { get; set; }
        public int? PracticalUnits { get; set; }
        public int? TheoryUnits { get; set; }
        public int TotalHours { get; set; }
        public int TotalUnits { get; set; }

        public int MajorId { get; set; }
        public string MajorsName { get; set; }

        public int? PrerequisiteId { get; set; }
        public string PrerequisiteName { get; set; }
    }
}