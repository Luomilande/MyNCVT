using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    /// <summary>
    /// Specialty: 专业，数据实体类
    /// </summary>
    [Serializable]
    public class Specialty
    {
        /// <summary>
        /// SpecialtyId: 专业编号
        /// </summary>
        public Int32 SpecialtyId { get; set; }

        /// <summary>
        /// DepartmentId: 部门编号
        /// </summary>
        public Int32 DepartmentId { get; set; }

        /// <summary>
        /// SpecialtyFullName: 专业全名
        /// </summary>
        public String SpecialtyFullName { get; set; }

        /// <summary>
        /// SpecialtyShortName: 专业简称
        /// </summary>
        public String SpecialtyShortName { get; set; }

        /// <summary>
        /// SpecialtyDescription: 专业描述
        /// </summary>
        public String SpecialtyDescription { get; set; }
    }

}
