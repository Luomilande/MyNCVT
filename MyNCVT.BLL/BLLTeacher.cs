﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyNCVT.DAL;
using MyNCVT.Model;

namespace MyNCVT.BLL
{
    public class BLLTeacher
    {
        private DALTeacher dalTeacher = new DALTeacher();

        public IList<TeacherBusiness> GetAllTeacherBusiness()
        {
            return dalTeacher.GetAllTeacherBusiness();
        }

        public IList<TeacherBusiness> GetAllTeacherBusiness(int n)
        {
            return dalTeacher.GetAllTeacherBusiness(n);
        }
        public bool AddTeacher(Teacher teacher)
        {
            return dalTeacher.AddTeacher(teacher);
        }
    }
}
