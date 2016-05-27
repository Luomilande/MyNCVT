using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    /// <summary>
    /// CourseProperty: 课程性质，数据实体类
    /// </summary>
    [Serializable]
    public class CourseProperty
    {
        /// <summary>
        /// CoursePropertyId: 课程性质编号
        /// </summary>
        public Int32 CoursePropertyId { get; set; }

        /// <summary>
        /// CoursePropertyName: 课程性质名称
        /// </summary>
        public String CoursePropertyName { get; set; }

        /// <summary>
        /// CoursePropertyDescription: 课程性质描述
        /// </summary>
        public String CoursePropertyDescription { get; set; }
    }

}
