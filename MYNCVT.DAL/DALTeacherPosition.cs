using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyNCVT.Model;
using System.Data;
using System.Data.SqlClient;

namespace MyNCVT.DAL
{
    public class DALTeacherPosition
    {
        /// <summary>
        /// GetAllTeacherPosition():获取所有的教师职位
        /// </summary>
        /// <returns></returns>
        public IList<TeacherPosition> GetAllTeacherPosition()
        {
            IList<TeacherPosition> listTeacherPosition = new List<TeacherPosition>();
            string sql = "select * from TeacherPosition";
            using (SqlDataReader reader = DBHelper.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    TeacherPosition teacherPosition = new TeacherPosition();
                    teacherPosition.TeacherPositionId = int.Parse(reader["TeacherPositionId"].ToString());
                    teacherPosition.TeacherPositionName = reader["TeacherPositionName"].ToString();
                    teacherPosition.TeacherPositionDescription = reader["TeacherPositionDescription"].ToString();
                    listTeacherPosition.Add(teacherPosition);
                }
            }
            return listTeacherPosition;
        }

        /// <summary>
        /// AddTeacherPosition(TeacherPosition teacherPosition)：添加一个教师职位记录
        /// </summary>
        /// <param name="teacherPosition"></param>
        /// <returns></returns>
        public bool AddTeacherPosition(TeacherPosition teacherPosition)
        {
            string sql = "insert into TeacherPosition(TeacherPositionName, TeacherPositionDescription) values(@TeacherPositionName, @TeacherPositionDescription)";
            SqlParameter[] parameters = {
                                            new SqlParameter("@TeacherPositionName", SqlDbType.VarChar, 50),
                                            new SqlParameter("@TeacherPositionDescription", SqlDbType.VarChar, 200)
                                        };
            parameters[0].Value = teacherPosition.TeacherPositionName;
            parameters[1].Value = teacherPosition.TeacherPositionDescription;
            int n = DBHelper.ExecuteCommand(sql, parameters);
            return n == 1;
        }



    }
}
