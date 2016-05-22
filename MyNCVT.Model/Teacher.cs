using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    /// <summary>
    /// Teacher：实体类，教师
    /// </summary>
    public class Teacher
    {
        public int TeacherId { get; set; }
        public int DepartmentId { get; set; }
        public int SpecialtyId { get; set; }
        public int TeacherTitleId { get; set; }
        public int TeacherPositionId { get; set; }
        public string TeacherLoginId { get; set; }
        public string TeacherLoginPwd { get; set; }
        public string TeacherNo { get; set; }
        public string TeacherName { get; set; }
        public string TeacherGender { get; set; }
        public bool TeacherEnabled { get; set; }
    }
}
