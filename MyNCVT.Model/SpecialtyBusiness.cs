using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    /// <summary>
    /// SpecialtyBusiness: 继承自Specialty的专业业务实体类
    /// </summary>
    public class SpecialtyBusiness : Specialty
    {
        /// <summary>
        /// DepartmentFullName: 部门全名
        /// </summary>
        public string DepartmentFullName { get; set; }

        /// <summary>
        /// DepartmentShortName: 部门简称
        /// </summary>
        public string DepartmentShortName { get; set; }

        /// <summary>
        /// SpecialtyLeaderName: 专业负责人
        /// </summary>
        public string SpecialtyLeaderName { get; set; }
    }
}
