using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyNCVT.Model;
using System.Data;
using System.Data.SqlClient;

namespace MyNCVT.DAL
{
    public class DALTeacherTitle
    {
        public IList<TeacherTitle> GetAllTeahcerTitle()
        {
            IList<TeacherTitle> listTeacherTitle = new List<TeacherTitle>();
            string sql = "select * from TeacherTitle";
            using (SqlDataReader reader = DBHelper.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    TeacherTitle teacherTitle = new TeacherTitle();
                    teacherTitle.TeacherTitleId = int.Parse(reader["TeacherTitleId"].ToString());
                    teacherTitle.TeacherTitleName = reader["TeacherTitleName"].ToString();
                    teacherTitle.TeacherTitleDescription = reader["TeacherTitleDescription"].ToString();
                    listTeacherTitle.Add(teacherTitle);
                }
            }
            return listTeacherTitle;
        }

        public bool AddTeacherTitle(TeacherTitle teacherTitle)
        {
            bool addFlag = false;
            string sql = "insert into TeacherTitle(TeacherTitleName, TeacherTitleDescription) values(@TeacherTitleName, @TeacherTitleDescription)";

            SqlParameter[] parameters ={
                                         new SqlParameter("@TeacherTitleName", SqlDbType.VarChar, 50),
                                         new SqlParameter("@TeacherTitleDescription", SqlDbType.VarChar, 200)};

            parameters[0].Value = teacherTitle.TeacherTitleName;
            parameters[1].Value = teacherTitle.TeacherTitleDescription;

            int n = DBHelper.ExecuteCommand(sql, parameters);
            if (n == 1)
                addFlag = true;

            return addFlag;
        }
    }
}
