using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    public class StudentClass
    {
        public int StudentClassId { get; set; }
        public int StudentGradeId { get; set; }
        public int TeacherId { get; set; }
        public int DepartmentId { get; set; }
        public int SpecialtyId { get; set; }
        public string StudentClassFullName { get; set; }
        public string StudentClassShortName { get; set; }
        public int StudentQuantity { get; set; }
    }
}
