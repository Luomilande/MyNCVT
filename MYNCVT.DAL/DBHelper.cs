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
        // 注意在不同的机器上要检查是否修改 Data Source=
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

        public static void SqlBulkCopyByDatatable(string TableName, DataTable Dt)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlBulkCopy sqlbulkcopy = new SqlBulkCopy(connString, SqlBulkCopyOptions.UseInternalTransaction))
                {
                    try
                    {
                        sqlbulkcopy.BulkCopyTimeout = 5000;//指定超时时间 以秒为单位 默认超时时间是30秒,设置为0即不限时间
                        sqlbulkcopy.DestinationTableName = TableName;//目标数据库表名

                        for (int i = 0; i < Dt.Columns.Count; i++)
                        {
                            //映射字段名 DataTable列名 ,数据库对应列名  
                            sqlbulkcopy.ColumnMappings.Add(Dt.Columns[i].ColumnName, Dt.Columns[i].ColumnName);
                        }
                        /*                
                        //额外,可不写：设置一次性处理的行数。这个行数处理完后，会激发SqlRowsCopied()方法。默认为1 
                        //这个可以用来提示用户S，qlBulkCopy的进度 
                        sqlbulkcopy.NotifyAfter = 1;
                        //设置激发的SqlRowsCopied()方法，这里为sqlbulkcopy_SqlRowsCopied  
                        sqlbulkcopy.SqlRowsCopied += new SqlRowsCopiedEventHandler(bulkCopy_SqlRowsCopied);
                        */
                        sqlbulkcopy.WriteToServer(Dt);//将数据源拷备到目标数据库
                    }
                    catch (System.Exception e)
                    {
                        // throw e;
                        string eMessage = e.Message.ToString();
                        int indexLeft = eMessage.IndexOf("重复键值为 (") + 7;
                        int indexRight = eMessage.IndexOf(")。");
                        int strLength = indexRight - indexLeft;
                        if (indexLeft != -1)
                        {
                            throw new Exception("批量导入失败，存在重复记录：" + eMessage.Substring(indexLeft, strLength));
                        }
                        else
                        {
                            throw e;
                        }

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }


        #endregion
    }
}
