using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MyNCVT.Model;

namespace MyNCVT.DAL
{
    /// <summary>
    /// DBHelper:数据库访问帮助类
    /// 修改时间：2016-5-23 13:30
    /// 最后修改人：Hujy
    /// </summary>
    public class DBHelper
    {
        #region 连接字符串
        private static readonly string connString = @"Data Source=.;Initial Catalog=MyNCVT;Integrated Security=True";

        #endregion

        #region Public Methods

        /// <summary>
        /// 执行SQL语句（增删改）并返回受影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteCommand(string sql)
        {
            int rows = -1;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    try
                    {
                        rows = cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        conn.Close();
                        throw;
                    }
                }
            }
            return rows;
        }

        /// <summary>
        /// 执行SQL语句（增删改）并返回受影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int ExecuteCommand(string sql, params SqlParameter[] values)
        {
            int rows = -1;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    try
                    {
                        cmd.Parameters.AddRange(values);
                        rows = cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        conn.Close();
                        throw;
                    }
                }
            }
            return rows;
        }
        /// <summary>
        /// 执行查询语句，返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql)
        {
            SqlDataReader reader = null;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
            return reader;
        }

        /// <summary>
        /// 执行查询语句，返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] values)
        {
            SqlDataReader reader = null;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddRange(values);
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
            return reader;
        }

        /// <summary>
        /// 执行查询并返回DataSet
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet Query(string sql)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlDataAdapter ada = new SqlDataAdapter(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        ada.Fill(ds);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return ds;
        }

        /// <summary>
        /// 执行查询并返回DataSet
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static DataSet Query(string sql, params SqlParameter[] values)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlDataAdapter ada = new SqlDataAdapter(sql, conn))
                {
                    conn.Open();
                    ada.SelectCommand.Parameters.AddRange(values);
                    ada.Fill(ds);
                }
            }
            return ds;
        }

        #endregion
    }
}
