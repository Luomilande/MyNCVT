using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    /// <summary>
    /// Student: 学生，数据实体类
    /// </summary>
    [Serializable]
    public class Student
    {
        /// <summary>
        /// StudentId: 学生编号
        /// </summary>
        public Int32 StudentId { get; set; }

        /// <summary>
        /// StudentClassId: 班级编号
        /// </summary>
        public Int32 StudentClassId { get; set; }

        /// <summary>
        /// StudentNo: 学生学号
        /// </summary>
        public String StudentNo { get; set; }

        /// <summary>
        /// StudentName: 学生名字
        /// </summary>
        public String StudentName { get; set; }

        /// <summary>
        /// StudentLogin: 学生登录名
        /// </summary>
        public String StudentLogin { get; set; }

        /// <summary>
        /// StudentPwd: 学生登录密码
        /// </summary>
        public String StudentPwd { get; set; }

        /// <summary>
        /// StudentEnabled: 学生账号状态，可用：true, 不可用: false
        /// </summary>
        public Boolean StudentEnabled { get; set; }

        /// <summary>
        /// StudentStatusId: 学生学籍状态编号
        /// </summary>
        public Int32 StudentStatusId { get; set; }
    }

}
