using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    /// <summary>
    /// Admin:管理员 数据实体类
    /// </summary>
    [Serializable]
    public class Admin
    {
        /// <summary>
        /// AdminId：管理员编号
        /// </summary>
        public Int32 AdminId { get; set; }

        /// <summary>
        /// LoginId:管理员登录名
        /// </summary>
        public String LoginId { get; set; }

        /// <summary>
        /// LoginPwd:管理员登录密码
        /// </summary>
        public String LoginPwd { get; set; }

        /// <summary>
        /// AdminName：管理员名字
        /// </summary>
        public String AdminName { get; set; }

        /// <summary>
        /// Enabled:账号的状态，可用: true， 不可用: false
        /// </summary>
        public Boolean Enabled { get; set; }

        /// <summary>
        /// CreateOn: 账号创建时间
        /// </summary>
        public DateTime CreateOn { get; set; }
    } 
}
