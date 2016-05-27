using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    /// <summary>
    /// TeacherTitle: 教师职称，数据实体类
    /// </summary>
    [Serializable]
    public class TeacherTitle
    {
        /// <summary>
        /// TeacherTitleId: 教师职称编号
        /// </summary>
        public Int32 TeacherTitleId { get; set; }

        /// <summary>
        /// TeacherTitleName: 教师职称名字
        /// </summary>
        public String TeacherTitleName { get; set; }

        /// <summary>
        /// TeacherTitleDescription: 教师职称描述
        /// </summary>
        public String TeacherTitleDescription { get; set; }
    } 

}
