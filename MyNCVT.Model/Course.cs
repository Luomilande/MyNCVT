using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    /// <summary>
    /// Course: 课程，数据实体类
    /// </summary>
    [Serializable]
    public class Course
    {
        /// <summary>
        /// CourseId: 课程编号
        /// </summary>
        public Int32 CourseId { get; set; }

        /// <summary>
        /// CoursePropertyId: 课程性质编号
        /// </summary>
        public Int32 CoursePropertyId { get; set; }

        /// <summary>
        /// SpecialtyId: 专业编号
        /// </summary>
        public Int32 SpecialtyId { get; set; }

        /// <summary>
        /// CourseCode: 课程代码
        /// </summary>
        public String CourseCode { get; set; }

        /// <summary>
        /// CourseFullName: 课程全名
        /// </summary>
        public String CourseFullName { get; set; }

        /// <summary>
        /// CourseShortName: 课程简称
        /// </summary>
        public String CourseShortName { get; set; }

        /// <summary>
        /// CourseDescription: 课程描述
        /// </summary>
        public String CourseDescription { get; set; }
    }


}
