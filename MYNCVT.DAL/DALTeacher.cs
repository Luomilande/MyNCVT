using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyNCVT.Model;
using System.Data;
using System.Data.SqlClient;

namespace MyNCVT.DAL
{
    public class DALTeacher
    {
        /// <summary>
        /// 获取所有教师
        /// </summary>
        /// <returns></returns>
        public IList<TeacherBusiness> GetAllTeacherBusiness()
        {
            IList<TeacherBusiness> listTeacherBusiness = new List<TeacherBusiness>();
            string sql = @"SELECT   Teacher.*, TeacherPosition.TeacherPositionName, TeacherTitle.TeacherTitleName, Specialty.SpecialtyFullName, Department.DepartmentFullName FROM  Department INNER JOIN Specialty ON Department.DepartmentId = Specialty.DepartmentId INNER JOIN Teacher ON Department.DepartmentId = Teacher.DepartmentId AND  Specialty.SpecialtyId = Teacher.SpecialtyId INNER JOIN TeacherPosition ON Teacher.TeacherPositionId = TeacherPosition.TeacherPositionId INNER JOIN TeacherTitle ON Teacher.TeacherTitleId = TeacherTitle.TeacherTitleId";
            using (SqlDataReader reader = DBHelper.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    TeacherBusiness teacherBusiness = new TeacherBusiness();
                    teacherBusiness.TeacherId = int.Parse(reader["TeacherId"].ToString());
                    teacherBusiness.DepartmentId = int.Parse(reader["DepartmentId"].ToString());
                    teacherBusiness.DepartmentFullName = reader["DepartmentFullName"].ToString();
                    teacherBusiness.SpecialtyId = int.Parse(reader["SpecialtyId"].ToString());
                    teacherBusiness.SpecialtyFullName = reader["SpecialtyFullName"].ToString();
                    teacherBusiness.TeacherTitleId = int.Parse(reader["TeacherTitleId"].ToString());
                    teacherBusiness.TeacherTitleName = reader["TeacherTitleName"].ToString();
                    teacherBusiness.TeacherPositionId = int.Parse(reader["TeacherPositionId"].ToString());
                    teacherBusiness.TeacherPositionName = reader["TeacherPositionName"].ToString();
                    teacherBusiness.TeacherLoginId = reader["TeacherLoginId"].ToString();
                    teacherBusiness.TeacherLoginPwd = reader["TeacherLoginPwd"].ToString();
                    teacherBusiness.TeacherNo = reader["TeacherNo"].ToString();
                    teacherBusiness.TeacherName = reader["TeacherName"].ToString();
                    teacherBusiness.TeacherGender = reader["TeacherGender"].ToString();
                    teacherBusiness.TeacherEnabled = bool.Parse(reader["TeacherEnabled"].ToString());
                    listTeacherBusiness.Add(teacherBusiness);
                }
            }
            return listTeacherBusiness;
        }

        /// <summary>
        /// 按部门编号获取教师
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        public IList<TeacherBusiness> GetAllTeacherBusiness(int departmentId)
        {
            IList<TeacherBusiness> listTeacherBusiness = new List<TeacherBusiness>();
            string sql = @"SELECT   Teacher.*, TeacherPosition.TeacherPositionName, TeacherTitle.TeacherTitleName, Specialty.SpecialtyFullName, Department.DepartmentFullName FROM  Department INNER JOIN Specialty ON Department.DepartmentId = Specialty.DepartmentId INNER JOIN Teacher ON Department.DepartmentId = Teacher.DepartmentId AND  Specialty.SpecialtyId = Teacher.SpecialtyId INNER JOIN TeacherPosition ON Teacher.TeacherPositionId = TeacherPosition.TeacherPositionId INNER JOIN TeacherTitle ON Teacher.TeacherTitleId = TeacherTitle.TeacherTitleId where Teacher.DepartmentId = @DepartmentId";
            SqlParameter parameter = new SqlParameter("@DepartmentId", SqlDbType.Int);
            parameter.Value = departmentId;
            using (SqlDataReader reader = DBHelper.ExecuteReader(sql, parameter))
            {
                while (reader.Read())
                {
                    TeacherBusiness teacherBusiness = new TeacherBusiness();
                    teacherBusiness.TeacherId = int.Parse(reader["TeacherId"].ToString());
                    teacherBusiness.DepartmentId = int.Parse(reader["DepartmentId"].ToString());
                    teacherBusiness.DepartmentFullName = reader["DepartmentFullName"].ToString();
                    teacherBusiness.SpecialtyId = int.Parse(reader["SpecialtyId"].ToString());
                    teacherBusiness.SpecialtyFullName = reader["SpecialtyFullName"].ToString();
                    teacherBusiness.TeacherTitleId = int.Parse(reader["TeacherTitleId"].ToString());
                    teacherBusiness.TeacherTitleName = reader["TeacherTitleName"].ToString();
                    teacherBusiness.TeacherPositionId = int.Parse(reader["TeacherPositionId"].ToString());
                    teacherBusiness.TeacherPositionName = reader["TeacherPositionName"].ToString();
                    teacherBusiness.TeacherLoginId = reader["TeacherLoginId"].ToString();
                    teacherBusiness.TeacherLoginPwd = reader["TeacherLoginPwd"].ToString();
                    teacherBusiness.TeacherNo = reader["TeacherNo"].ToString();
                    teacherBusiness.TeacherName = reader["TeacherName"].ToString();
                    teacherBusiness.TeacherGender = reader["TeacherGender"].ToString();
                    teacherBusiness.TeacherEnabled = bool.Parse(reader["TeacherEnabled"].ToString());
                    listTeacherBusiness.Add(teacherBusiness);
                }
            }
            return listTeacherBusiness;
        }

        public bool AddTeacher(Teacher teacher)
        {
            string sql = "insert into Teacher(DepartmentId, SpecialtyId, TeacherTitleId, TeacherPositionId, TeacherLoginId, TeacherLoginPwd, TeacherNo, TeacherName, TeacherGender, TeacherEnabled) values(@DepartmentId, @SpecialtyId, @TeacherTitleId, @TeacherPositionId, @TeacherLoginId, @TeacherLoginPwd, @TeacherNo, @TeacherName, @TeacherGender, @TeacherEnabled)";
            SqlParameter[] parameters ={
                                           new SqlParameter("@DepartmentId", SqlDbType.Int),
                                           new SqlParameter("@SpecialtyId", SqlDbType.Int),
                                           new SqlParameter("@TeacherTitleId", SqlDbType.Int),
                                           new SqlParameter("@TeacherPositionId", SqlDbType.Int),
                                           new SqlParameter("@TeacherLoginId", SqlDbType.VarChar, 50),
                                           new SqlParameter("@TeacherLoginPwd", SqlDbType.VarChar, 50),
                                           new SqlParameter("@TeacherNo", SqlDbType.Char, 5),
                                           new SqlParameter("@TeacherName", SqlDbType.VarChar, 50),
                                           new SqlParameter("@TeacherGender", SqlDbType.VarChar, 10),
                                           new SqlParameter("@TeacherEnabled", SqlDbType.Bit, 1)
                                       };
            parameters[0].Value = teacher.DepartmentId;
            parameters[1].Value = teacher.SpecialtyId;
            parameters[2].Value = teacher.TeacherTitleId;
            parameters[3].Value = teacher.TeacherPositionId;
            parameters[4].Value = teacher.TeacherLoginId;
            parameters[5].Value = teacher.TeacherLoginPwd;
            parameters[6].Value = teacher.TeacherNo;
            parameters[7].Value = teacher.TeacherName;
            parameters[8].Value = teacher.TeacherGender;
            parameters[9].Value = teacher.TeacherEnabled;

            int n = DBHelper.ExecuteCommand(sql, parameters);            
            return n == 1;
        }
    }
}
