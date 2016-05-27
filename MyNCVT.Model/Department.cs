using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    /// <summary>
    /// Department: 部门，数据实体类
    /// </summary>
    [Serializable]
    public class Department
    {
        /// <summary>
        /// DepartmentId: 部门编号
        /// </summary>
        public Int32 DepartmentId { get; set; }

        /// <summary>
        /// DepartmentFullName: 部门全名
        /// </summary>
        public String DepartmentFullName { get; set; }

        /// <summary>
        /// DepartmentShortName: 部门简称
        /// </summary>
        public String DepartmentShortName { get; set; }

        /// <summary>
        /// DepartmentDescription: 部门描述
        /// </summary>
        public String DepartmentDescription { get; set; }
    }

}
