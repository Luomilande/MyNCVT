using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyNCVT.DAL;
using MyNCVT.Model;
using System.Data;

namespace MyNCVT.BLL
{
    public class BLLAdmin
    {
        private DALAdmin dalAdmin = new DALAdmin();
        public DataSet GetAllAdmin()
        {
            return dalAdmin.GetAllAdmin();
        }
    }
}
