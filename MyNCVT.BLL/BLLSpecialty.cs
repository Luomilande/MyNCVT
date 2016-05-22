using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyNCVT.DAL;
using MyNCVT.Model;

namespace MyNCVT.BLL
{
    public class BLLSpecialty
    {
        #region Private Members
        private DALSpecialty dalSpecitlty = new DALSpecialty();


        #endregion

        #region Public Methods
        public IList<Specialty> GetAllSpecialty()
        {
            return dalSpecitlty.GetAllSpecialty();
        }

        public IList<SpecialtyBusiness> GetSpecialtyByDepartmentId(int departmentId)
        {
            return dalSpecitlty.GetSpecialtyByDepartmentId(departmentId);
        }
        #endregion
    }
}
