using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MyNCVT.BLL;
using MyNCVT.Model;
using System.Data.SqlClient;

namespace MyNCVT.UI
{
    public partial class FrmImportTeacher : Form
    {
        private DataTable dtImport = new DataTable();
        private BLLTeacher bllTeacher = new BLLTeacher();
        public FrmImportTeacher()
        {
            InitializeComponent();
        }

        private void btnImportTeacher_Click(object sender, EventArgs e)
        {

            /*
OpenFileDialog控件有以下基本属性
             * 
InitialDirectory 对话框的初始目录
Filter 要在对话框中显示的文件筛选器，例如，"文本文件(*.txt)|*.txt|所有文件(*.*)||*.*"
FilterIndex 在对话框中选择的文件筛选器的索引，如果选第一项就设为1
RestoreDirectory 控制对话框在关闭之前是否恢复当前目录
FileName 第一个在对话框中显示的文件或最后一个选取的文件
Title 将显示在对话框标题栏中的字符
AddExtension 是否自动添加默认扩展名
CheckPathExists
在对话框返回之前，检查指定路径是否存在
DefaultExt 默认扩展名
DereferenceLinks 在从对话框返回前是否取消引用快捷方式
ShowHelp
启用"帮助"按钮
ValiDateNames 控制对话框检查文件名中是否不含有无效的字符或序列             * 
             */

            OpenFileDialog openFileDialog = new OpenFileDialog();
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);  //当前系统桌面路径
            openFileDialog.InitialDirectory = dir; //设置打开文件的初始位置为桌面
            openFileDialog.Filter = "Excel工作簿|*.xlsx|Excel 97-2003工作簿|*.xls";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            string[] srcColumn ={"部门", "专业", "教工号", "姓名", "性别", "职称", "岗位", "账号启用"};
            string[] dscColumn = {"TPDepartmentName", "TPSpecialtyName", "TPTeacherNo", "TPTeacherName", "TPTeacherGender", "TPTeacherTitle", "TPTeacherPosition", "TPTeacherEnable"};
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                dtImport = ExcelToDataSet(filePath).Tables[0];
                dgvTeacher.DataSource = dtImport;
                lblTotal.Text =string.Format("此次将要导入 {0} 条教师数据。", dtImport.Rows.Count);
                bllTeacher.DeleteAllTempTeacher();
                SqlBulkCopy sbc = new SqlBulkCopy("Data Source=.;Initial Catalog=MyNCVT;Integrated Security=True", SqlBulkCopyOptions.UseInternalTransaction);
                sbc.BulkCopyTimeout = 5000;
                try
                {
                    sbc.DestinationTableName = "TempTeacher";
                    for (int i = 0; i < srcColumn.Length; i++)
                    {
                        sbc.ColumnMappings.Add(srcColumn[i], dscColumn[i]);
                    }
                        /*
                        sbc.ColumnMappings.Add("部门", "TPDepartmentName");
                        sbc.ColumnMappings.Add("专业", "TPSpecialtyName");
                        sbc.ColumnMappings.Add("教工号", "TPTeacherNo");
                        sbc.ColumnMappings.Add("姓名", "TPTeacherName");
                        sbc.ColumnMappings.Add("性别", "TPTeacherGender");
                        sbc.ColumnMappings.Add("职称", "TPTeacherTitle");
                        sbc.ColumnMappings.Add("岗位", "TPTeacherPosition");
                        sbc.ColumnMappings.Add("账号启用", "TPTeacherEnable");
                        */
                        sbc.WriteToServer(dtImport);
                }
                catch (Exception ex)
                {
                    //处理异常
                }
                finally
                {
                    //sqlcmd.Clone();
                    //srcConnection.Close();
                    //desConnection.Close();
                }



            }

        }

        private static DataSet ExcelToDataSet(string filePath)
        {
            string fileName = System.IO.Path.GetFileName(filePath);//文件名
            string extension = System.IO.Path.GetExtension(filePath);//扩展名 “.xlsx”
            string strConn = string.Empty;
            if (extension == "xls")
            {
                strConn = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0}; Extended Properties=Excel 8.0;", filePath);
            }
            else
            {
                strConn = string.Format("Provider=Microsoft.Ace.OleDb.12.0; Data source={0}; Extended Properties='Excel 12.0; IMEX=1'", filePath);
            }
            OleDbDataAdapter myCommand = null;
            DataSet ds = null;

            using (OleDbConnection conn = new OleDbConnection(strConn))
            {
                conn.Open();
                string strExcel = "select * from [sheet1$]";
                using (myCommand = new OleDbDataAdapter(strExcel, strConn))
                {
                    ds = new DataSet();
                    myCommand.Fill(ds, "table1");
                }
            }
            return ds;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }
    }
}
