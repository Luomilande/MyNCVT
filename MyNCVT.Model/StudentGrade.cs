using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    /// <summary>
    /// StudentGrade: 学生年级，数据实体类
    /// </summary>
    [Serializable]
    public class StudentGrade
    {
        /// <summary>
        /// StudentGradeId: 年级编号
        /// </summary>
        public Int32 StudentGradeId { get; set; }

        /// <summary>
        /// StudentGradeFullName: 年级全名，例如：2015级
        /// </summary>
        public String StudentGradeFullName { get; set; }

        /// <summary>
        /// StudentGradeShortName: 年级简称，例如：15级
        /// </summary>
        public String StudentGradeShortName { get; set; }

        /// <summary>
        /// EnrollmentYear: 四位数字入学年份，例如：2015
        /// </summary>
        public String EnrollmentYear { get; set; }

        /// <summary>
        /// YearShortName: 两位数字入学年份：例如：15
        /// </summary>
        public String YearShortName { get; set; }
    } 

}
