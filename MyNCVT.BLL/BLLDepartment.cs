using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyNCVT.DAL;
using MyNCVT.Model;

namespace MyNCVT.BLL
{
    public class BLLDepartment
    {
        #region Private Members
        private DALDepartment dalDepartment = new DALDepartment();
        #endregion

        #region Public Methods
        public IList<Department> GetAllDepartment()
        {
            return dalDepartment.GetAllDepartment();
        }

        public bool AddDepartment(Department department)
        {
            return dalDepartment.AddDepartment(department);
        }

        public Department GetDepartmentByDepartmentId(int departmentId)
        {
            return dalDepartment.GetDepartmentByDepartmentId(departmentId);
        }

        public bool ModifyDepartment(Department department)
        {
            return dalDepartment.ModifyDepartment(department);
        }

        public bool DeleteDepartmentByDepartmentId(int departmentId)
        {
            return dalDepartment.DeleteDepartmentByDepartmentId(departmentId);
        }

        #endregion
    }
}
