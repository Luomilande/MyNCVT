using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MyNCVT.Model;

namespace MyNCVT.DAL
{
    public class DALAdmin
    {

        public DataSet GetAllAdmin()
        {
            string sql = "select * from Admin";
            DataSet dsAdmin = DBHelper.Query(sql);            
            return dsAdmin;
        }
    }
}
