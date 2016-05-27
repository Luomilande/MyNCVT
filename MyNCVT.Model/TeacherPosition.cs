using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    /// <summary>
    /// TeacherPosition: 教师岗位，数据实体类
    /// </summary>
    [Serializable]
    public class TeacherPosition
    {
        /// <summary>
        /// TeacherPositionId: 教师岗位编号
        /// </summary>
        public Int32 TeacherPositionId { get; set; }

        /// <summary>
        /// TeacherPositionName: 教师岗位名称
        /// </summary>
        public String TeacherPositionName { get; set; }

        /// <summary>
        /// TeacherPositionDescription: 教师岗位描述
        /// </summary>
        public String TeacherPositionDescription { get; set; }
    } 

}
