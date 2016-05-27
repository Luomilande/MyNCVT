using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    /// <summary>
    /// Teacher: 教师，数据实体类
    /// </summary>
    [Serializable]
    public class Teacher
    {
        /// <summary>
        /// TeacherId: 教师编号
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
        /// TeacherTitleId: 教师职称编号
        /// </summary>
        public Int32 TeacherTitleId { get; set; }

        /// <summary>
        /// TeacherPositionId: 教师岗位/职位编号
        /// </summary>
        public Int32 TeacherPositionId { get; set; }

        /// <summary>
        /// TeacherLoginId: 教师登录名
        /// </summary>
        public String TeacherLoginId { get; set; }

        /// <summary>
        /// TeacherLoginPwd: 教师登录密码
        /// </summary>
        public String TeacherLoginPwd { get; set; }

        /// <summary>
        /// TeacherNo: 教师职工号
        /// </summary>
        public String TeacherNo { get; set; }

        /// <summary>
        /// TeacherName: 教师名字
        /// </summary>
        public String TeacherName { get; set; }

        /// <summary>
        /// TeacherGender: 教师性别
        /// </summary>
        public String TeacherGender { get; set; }

        /// <summary>
        /// TeacherEnabled: 教师账号状态，可用：true，不可用：false
        /// </summary>
        public Boolean TeacherEnabled { get; set; }
    } 

}
