using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    /// <summary>
    /// SpecialtyLeader: 专业负责人， 数据实体类
    /// </summary>
    [Serializable]
    public class SpecialtyLeader
    {

        /// <summary>
        /// SpecialtyLeaderId: 专业负责人编号
        /// </summary>
        public Int32 SpecialtyLeaderId { get; set; }

        /// <summary>
        /// TeacherId: 教师编号
        /// </summary>
        public Int32 TeacherId { get; set; }

        /// <summary>
        /// SpecialtyId: 专业编号
        /// </summary>
        public Int32 SpecialtyId { get; set; }

        /// <summary>
        /// Description: 描述
        /// </summary>
        public String Description { get; set; }
    } 

}
