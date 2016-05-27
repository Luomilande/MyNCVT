using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    /// <summary>
    /// StudentClass: 学生班级，数据实体类
    /// </summary>
    [Serializable]
    public class StudentClass
    {
        /// <summary>
        /// StudentClassId: 学生班级编号
        /// </summary>
        public Int32 StudentClassId { get; set; }

        /// <summary>
        /// StudentGradeId: 学生年级编号
        /// </summary>
        public Int32 StudentGradeId { get; set; }

        /// <summary>
        /// TeacherId: 教师编号（班主任/辅导员）
        /// </summary>
        public Int32 TeacherId { get; set; }

        /// <summary>
        /// DepartmentId: 部门编号
        /// </summary>
        public Int32 DepartmentId { get; set; }

        /// <summary>
        /// SpecialtyId: 专业编号
        /// </summary>
        public Int32 SpecialtyId { get; set; }

        /// <summary>
        /// StudentClassFullName: 班级全名
        /// </summary>
        public String StudentClassFullName { get; set; }

        /// <summary>
        /// SutdentClassShortName: 班级简称
        /// </summary>
        public String SutdentClassShortName { get; set; }

        /// <summary>
        /// StudentQuantity: 学生人数
        /// </summary>
        public Int32 StudentQuantity { get; set; }
    } 

}
