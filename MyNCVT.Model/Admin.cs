using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string LoginId { get; set; }
        public string LoginPwd { get; set; }
        public string AdminName { get; set; }
        public bool Enabled { get; set; }
        public DateTime CreateOn { get; set; }
    }
}
