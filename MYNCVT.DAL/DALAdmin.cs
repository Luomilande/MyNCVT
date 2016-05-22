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
            DataSet dsAdmin = new DataSet();
            using (SqlConnection conn = new SqlConnection(DBHelper.connString))
            {
                conn.Open();
                string sql = "select * from Admin";
                using (SqlDataAdapter ada = new SqlDataAdapter(sql, conn))
                {
                    ada.Fill(dsAdmin);
                }
            }
            return dsAdmin;
        }
    }
}
