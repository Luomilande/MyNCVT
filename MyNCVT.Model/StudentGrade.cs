using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    /// <summary>
    /// StudentGrade：实体类，学生年级
    /// </summary>
    public class StudentGrade
    {
        public int StudentGradeId { get; set; }
        public string StudentGradeFullName { get; set; }
        public string StudentGradeShortName { get; set; }
        public string EnrollmentYear { get; set; }
        public string YearShortName { get; set; }
    }
}
