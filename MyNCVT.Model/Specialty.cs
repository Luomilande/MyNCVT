using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    public class Specialty
    {
        public int SpecialtyId { get; set; }
        public int DepartmentId { get; set; }
        public string SpecialtyFullName { get; set; }
        public string SpecialtyShortName { get; set; }
        public string SpecialtyDescription { get; set; }
    }
}
