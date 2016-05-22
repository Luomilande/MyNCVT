using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyNCVT.DAL;
using MyNCVT.Model;

namespace MyNCVT.BLL
{
    public class BLLTeacherTitle
    {
        private DALTeacherTitle dalTeacherTitle = new DALTeacherTitle();

        public IList<TeacherTitle> GetAllTeacherTitle()
        {
            return dalTeacherTitle.GetAllTeahcerTitle();
        }
    }
}
