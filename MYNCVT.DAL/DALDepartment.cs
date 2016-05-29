using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MyNCVT.Model;

/************************************************
 * 类名：DALDepartment
 * 功能描述：Department（部门）数据访问层支持类
 * *********************************************/
namespace MyNCVT.DAL
{ 
    public class DALDepartment
    {
        #region Public Methods

        public DataSet GetAllDepartmentForDataSet()
        {
            DataSet dsDepartment = new DataSet();
            string strSQL = "select * from Department";
            dsDepartment = DBHelper.Query(strSQL);
            return dsDepartment;
        }


        /// <summary>
        /// 获取所有的部门
        /// </summary>
        /// <returns></returns>
        public IList<Department> GetAllDepartment()
        {
            IList<Department> listDepartment = new List<Department>();
            string strSQL = "select * from Department";
            using (SqlDataReader reader = DBHelper.ExecuteReader(strSQL))
            {
                while (reader.Read())
                {
                    Department department = new Department();
                    department.DepartmentId = int.Parse(reader["DepartmentId"].ToString());
                    department.DepartmentFullName = reader["DepartmentFullName"].ToString();
                    department.DepartmentShortName = reader["DepartmentShortName"].ToString();
                    department.DepartmentDescription = reader["DepartmentDescription"].ToString();
                    listDepartment.Add(department);
                }
            }
            return listDepartment;
        }

        /// <summary>
        /// 增加一个部门
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public bool AddDepartment(Department department)
        {
            string sql = "insert into Department(DepartmentFullName, DepartmentShortName, DepartmentDescription) values(@DepartmentFullName, @DepartmentShortName, @DepartmentDescription)";
            SqlParameter[] parameters = {
                                            new SqlParameter("@DepartmentFullName",SqlDbType.VarChar,50),
                                            new SqlParameter("@DepartmentShortName",SqlDbType.VarChar,50),
                                            new SqlParameter("@DepartmentDescription",SqlDbType.VarChar,500)
                                        };
            parameters[0].Value = department.DepartmentFullName;
            parameters[1].Value = department.DepartmentShortName;
            parameters[2].Value = department.DepartmentDescription;
            int n = DBHelper.ExecuteCommand(sql, parameters);
            return n == 1;
        }

        /// <summary>
        /// 按编号查询并返回一条部门记录
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>       
        public Department GetDepartmentByDepartmentId(int departmentId)
        {
            Department department = null;
            string strSQL = "select * from Department where DepartmentId = @DepartmentId";
            SqlParameter parameters = new SqlParameter("@DepartmentId", SqlDbType.Int);
            parameters.Value = departmentId;
            using (SqlDataReader reader = DBHelper.ExecuteReader(strSQL, parameters))
            {
                if (reader.Read())
                {
                    department = new Department();
                    department.DepartmentId = int.Parse(reader["DepartmentId"].ToString());
                    department.DepartmentFullName = reader["DepartmentFullName"].ToString();
                    department.DepartmentShortName = reader["DepartmentShortName"].ToString();
                    department.DepartmentDescription = reader["DepartmentDescription"].ToString();
                }
            }
            return department;
        }
        
        /// <summary>
        /// 修改部门记录
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public bool ModifyDepartment(Department department)
        {
            string sql = "update Department set DepartmentFullName = @DepartmentFullName, DepartmentShortName = @DepartmentShortName, DepartmentDescription = @DepartmentDescription where DepartmentId = @DepartmentId";
            SqlParameter[] parameters = {
                                            new SqlParameter("@DepartmentFullName",SqlDbType.VarChar,50),
                                            new SqlParameter("@DepartmentShortName",SqlDbType.VarChar,50),
                                            new SqlParameter("@DepartmentDescription",SqlDbType.VarChar,500),
                                            new SqlParameter("@DepartmentId", SqlDbType.Int)
                                        };
            parameters[0].Value = department.DepartmentFullName;
            parameters[1].Value = department.DepartmentShortName;
            parameters[2].Value = department.DepartmentDescription;
            parameters[3].Value = department.DepartmentId;

            int n = DBHelper.ExecuteCommand(sql, parameters);
            return n == 1;
        }

        /// <summary>
        /// 按部门编号删除一条记录
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        public bool DeleteDepartmentByDepartmentId(int departmentId)
        {
            string sql = "delete from Department where DepartmentId = @DepartmentId";
            SqlParameter parameters = new SqlParameter("@DepartmentId", SqlDbType.Int);
            parameters.Value = departmentId;
            int n = DBHelper.ExecuteCommand(sql, parameters);
            return n == 1;
        }

        #endregion
    }
}
