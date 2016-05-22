using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNCVT.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public int StudentClassId { get; set; }
        public string StudentNo { get; set; }
        public string StudentName { get; set; }
        public string StudentLogin { get; set; }
        public string StudentPwd { get; set; }
        public bool StudentEnabled { get; set; }
        public int StudentStatusId { get; set; }
    }
}
