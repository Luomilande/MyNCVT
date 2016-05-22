using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    /// <summary>
    /// TeacherBusiness: 业务实体类,教师
    /// </summary>
    public class TeacherBusiness:Teacher
    {
        public string DepartmentFullName { get; set; }
        public string SpecialtyFullName { get; set; }
        public string TeacherTitleName { get; set; }
        public string TeacherPositionName { get; set; }
    }
}
