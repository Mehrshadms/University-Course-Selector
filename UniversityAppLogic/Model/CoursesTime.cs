//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniversityAppData.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CoursesTime
    {
        public int CourseTime_ID { get; set; }
        public int FK_Course_ID { get; set; }
        public int CourseDay { get; set; }
        public int Start_Hour { get; set; }
        public int End_Hour { get; set; }
        public int FK_Term_ID { get; set; }
        public int FK_Teacher_ID { get; set; }
        public int FK_Major_ID { get; set; }
    
        public virtual Courses Courses { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Term Term { get; set; }
        public virtual Majors Majors { get; set; }
    }
}
