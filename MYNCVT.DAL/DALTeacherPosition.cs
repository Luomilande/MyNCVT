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


    }
}
