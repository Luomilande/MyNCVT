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
        #region Public Methods
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

        public IList<SpecialtyBusiness> GetAllSpecialtyBusiness()
        {
            IList<SpecialtyBusiness> listSpecialty = new List<SpecialtyBusiness>();
            string sql = "SELECT   Specialty.*, Department.DepartmentFullName, Department.DepartmentShortName FROM Specialty INNER JOIN Department ON Specialty.DepartmentId = Department.DepartmentId";
            using (SqlDataReader reader = DBHelper.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    SpecialtyBusiness specialty = new SpecialtyBusiness();
                    specialty.SpecialtyId = Convert.ToInt32(reader["SpecialtyId"].ToString());
                    specialty.DepartmentId = Convert.ToInt32(reader["DepartmentId"].ToString());
                    specialty.SpecialtyFullName = reader["SpecialtyFullName"].ToString();
                    specialty.SpecialtyShortName = reader["SpecialtyShortName"].ToString();
                    specialty.SpecialtyDescription = reader["SpecialtyDescription"].ToString();
                    specialty.DepartmentFullName = reader["DepartmentFullName"].ToString();
                    specialty.DepartmentShortName = reader["DepartmentShortName"].ToString();
                    listSpecialty.Add(specialty);
                }
            }
            return listSpecialty;
        }



        public IList<SpecialtyBusiness> GetSpecialtyByDepartmentId(int departmentId)
        {
            IList<SpecialtyBusiness> listSpecialty = new List<SpecialtyBusiness>();
            string sql = "SELECT   Specialty.*, Department.DepartmentFullName, Department.DepartmentShortName FROM Specialty INNER JOIN Department ON Specialty.DepartmentId = Department.DepartmentId where Department.DepartmentId = @DepartmentId";
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
                    specialty.DepartmentFullName = reader["DepartmentFullName"].ToString();
                    specialty.DepartmentShortName = reader["DepartmentShortName"].ToString();
                    listSpecialty.Add(specialty);
                }
            }
            return listSpecialty;
        }

        public bool AddSpecialty(Specialty specialty)
        {
            string sql = "insert into Specialty(DepartmentId, SpecialtyFullName, SpecialtyShortName, SpecialtyDescription) values(@DepartmentId, @SpecialtyFullName, @SpecialtyShortName, @SpecialtyDescription)";
            SqlParameter[] parameters = {
                                            new SqlParameter("@DepartmentId", SqlDbType.Int),
                                            new SqlParameter("@SpecialtyFullName", SqlDbType.VarChar, 50),
                                            new SqlParameter("@SpecialtyShortName", SqlDbType.VarChar, 50),
                                            new SqlParameter("@SpecialtyDescription", SqlDbType.VarChar, 200)
                                        };
            parameters[0].Value = specialty.DepartmentId;
            parameters[1].Value = specialty.SpecialtyFullName;
            parameters[2].Value = specialty.SpecialtyShortName;
            parameters[3].Value = specialty.SpecialtyDescription;
            int n = DBHelper.ExecuteCommand(sql, parameters);
            return n == 1;            
        }

        #endregion
    }
}
