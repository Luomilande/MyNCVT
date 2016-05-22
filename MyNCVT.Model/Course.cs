using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    public class Course
    {
        public int CourseId { get; set; }
        public int CoursePropertyId { get; set; }
        public int SpecialtyId { get; set; }
        public string CourseCode { get; set; }
        public string CourseFullName { get; set; }
        public string CourseShortName { get; set; }
        public string CourseDescription { get; set; }
    }
}
