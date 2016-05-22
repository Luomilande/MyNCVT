using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyNCVT.Model;
using System.Data;
using System.Data.SqlClient;

namespace MyNCVT.DAL
{
    public class DALSpecialty
    {
        public IList<Specialty> GetAllSpecialty()
        {
            IList<Specialty> listSpecialty = new List<Specialty>();
            string sql = "select * from Specialty";
            using (SqlDataReader reader = DBHelper.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    Specialty specialty = new Specialty();
                    specialty.SpecialtyId = Convert.ToInt32(reader["SpecialtyId"].ToString());
                    specialty.DepartmentId = Convert.ToInt32(reader["DepartmentId"].ToString());
                    specialty.SpecialtyFullName = reader["SpecialtyFullName"].ToString();
                    specialty.SpecialtyShortName = reader["SpecialtyShortName"].ToString();
                    specialty.SpecialtyDescription = reader["SpecialtyDescription"].ToString();
                    listSpecialty.Add(specialty);
                }
            }
            return listSpecialty;
        }

        public IList<SpecialtyBusiness> GetSpecialtyByDepartmentId(int departmentId)
        {
            IList<SpecialtyBusiness> listSpecialty = new List<SpecialtyBusiness>();
            string sql = "select * from Specialty where DepartmentId = @DepartmentId";
            SqlParameter parameter = new SqlParameter("@DepartmentId", SqlDbType.Int);
            parameter.Value = departmentId;
            using (SqlDataReader reader = DBHelper.ExecuteReader(sql, parameter))
            {
                while (reader.Read())
                {
                    SpecialtyBusiness specialty = new SpecialtyBusiness();
                    specialty.SpecialtyId = Convert.ToInt32(reader["SpecialtyId"].ToString());
                    specialty.DepartmentId = Convert.ToInt32(reader["DepartmentId"].ToString());
                    specialty.SpecialtyFullName = reader["SpecialtyFullName"].ToString();
                    specialty.SpecialtyShortName = reader["SpecialtyShortName"].ToString();
                    specialty.SpecialtyDescription = reader["SpecialtyDescription"].ToString();
                    listSpecialty.Add(specialty);
                }
            }
            return listSpecialty;
        }
    }
}
