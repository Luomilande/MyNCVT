using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    /// <summary>
    /// TeacherBusiness: 教师,业务实体类
    /// </summary>
    public class TeacherBusiness:Teacher
    {
        /// <summary>
        /// DepartmentFullName: 部门全名
        /// </summary>
        public string DepartmentFullName { get; set; }

        /// <summary>
        /// SpecialtyFullName: 专业全名
        /// </summary>
        public string SpecialtyFullName { get; set; }

        /// <summary>
        /// TeacherTitleName: 教师职称名字
        /// </summary>
        public string TeacherTitleName { get; set; }

        /// <summary>
        /// TeacherPositionName: 教师岗位名称
        /// </summary>
        public string TeacherPositionName { get; set; }
    }
}
