using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    public class SpecialtyBusiness:Specialty
    {
        public string DepartmentFullName { get; set; }
        public string DepartmentShortName { get; set; }
        public string SpecialtyLeaderName { get; set; }
    }
}
