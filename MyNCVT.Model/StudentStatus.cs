using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{    
    /// <summary>
    /// StudentStatus: 学生学籍状态，数据实体类
    /// </summary>
    [Serializable]
    public class StudentStatus
    {
        /// <summary>
        /// StudentStatusId: 学籍状态编号
        /// </summary>
        public Int32 StudentStatusId { get; set; }

        /// <summary>
        /// StudentStatusName: 学籍状态名字
        /// </summary>
        public String StudentStatusName { get; set; }

        /// <summary>
        /// StudentStatusDescription: 学籍状态描述
        /// </summary>
        public String StudentStatusDescription { get; set; }
    } 

}
