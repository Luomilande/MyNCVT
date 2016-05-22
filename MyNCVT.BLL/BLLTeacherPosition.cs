using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyNCVT.DAL;
using MyNCVT.Model;

namespace MyNCVT.BLL
{
    public class BLLTeacherPosition
    {
        private DALTeacherPosition dalTeacherPosition = new DALTeacherPosition();

        public IList<TeacherPosition> GetAllTeacherPositon()
        {
            return dalTeacherPosition.GetAllTeacherPosition();
        }

    }
}
