using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyNCVT.Model;
using MyNCVT.BLL;
using System.Data.OleDb;

namespace MyNCVT.UI
{
    public partial class FrmTeacher : Form
    {
        #region Private Members
        private BLLDepartment bllDepartment = new BLLDepartment();
        private BLLSpecialty bllSpecialty = new BLLSpecialty();
        private BLLTeacherTitle bllTeacherTitle = new BLLTeacherTitle();
        private BLLTeacherPosition bllTeacherPosition = new BLLTeacherPosition();
        private BLLTeacher bllTeacher = new BLLTeacher();

        #endregion

        public FrmTeacher()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 描述：窗体载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            InitDepartmnet();        //初始化部门下拉框
            InitTeacherTitle();      //初始化职称下拉框
            InitTeacherPosition();   //初始化岗位下拉框
            InitDgvTeacher();        //初始化教师数据表格
        }

        /// <summary>
        /// 描述：初始化教师数据表格
        /// </summary>
        private void InitDgvTeacher()
        {
            dgvTeacher.AutoGenerateColumns = false;
            dgvTeacher.MultiSelect = false;
            dgvTeacher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeacher.DataSource = bllTeacher.GetAllTeacherBusiness();
        }

        /// <summary>
        /// 描述：初始化岗位下拉框
        /// </summary>
        private void InitTeacherPosition()
        {
            cmbTeacherPosition.DisplayMember = "TeacherPositionName";
            cmbTeacherPosition.ValueMember = "TeacherPositionId";
            cmbTeacherPosition.DataSource = bllTeacherPosition.GetAllTeacherPositon();
        }

        /// <summary>
        /// 描述：初始化职称下拉框
        /// </summary>
        private void InitTeacherTitle()
        {
            cmbTeacherTitle.DisplayMember = "TeacherTitleName";
            cmbTeacherTitle.ValueMember = "TeacherTitleId";
            cmbTeacherTitle.DataSource = bllTeacherTitle.GetAllTeacherTitle();
        }

        /// <summary>
        /// 描述：初始化部门下拉框
        /// </summary>
        private void InitDepartmnet()
        {
            /*
            DataGridViewCheckBoxColumn dtCheck = new DataGridViewCheckBoxColumn();
            dtCheck.DataPropertyName = "select";
            dtCheck.HeaderText = "选择";
            dgvTeacher.Columns.Add(dtCheck);
            */
            IList<Department> listDepartment = bllDepartment.GetAllDepartment();
            listDepartment.Insert(0, new Department { DepartmentId = -1, DepartmentFullName = "--请选择部门--" });
            cmbDepartment.DisplayMember = "DepartmentFullName";
            cmbDepartment.ValueMember = "DepartmentId";
            cmbDepartment.DataSource = listDepartment;
        }

        private void cmbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(cmbDepartment.SelectedValue.ToString());
            if (n != -1)
            {
                cmbSpecialty.DataSource = null;
                cmbSpecialty.Items.Clear();
                cmbSpecialty.DisplayMember = "SpecialtyFullName";
                cmbSpecialty.ValueMember = "SpecialtyId";
                cmbSpecialty.DataSource = bllSpecialty.GetSpecialtyByDepartmentId(n);
                cmbSpecialty.Enabled = true;

                IList<TeacherBusiness> listTeacherBusiness = bllTeacher.GetAllTeacherBusiness(n);
                if (listTeacherBusiness.Count == 0)
                {
                    listTeacherBusiness.Add(new TeacherBusiness { DepartmentFullName = "--无教师信息--" });
                }
                dgvTeacher.DataSource = listTeacherBusiness;
            }
            else
            {
                cmbSpecialty.DataSource = null;
                cmbSpecialty.Items.Clear();
                cmbSpecialty.Enabled = false;
                InitDgvTeacher();
            }
        }

        /// <summary>
        /// 描述：添加教师按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            int n = int.Parse(cmbDepartment.SelectedValue.ToString());
            string name = txtTeacherName.Text.Trim();
            string no = txtTeacherNo.Text.Trim();
            if (n != -1 && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(no))
            {
                Teacher teacher = new Teacher();
                teacher.DepartmentId = n;
                teacher.SpecialtyId = Convert.ToInt32(cmbSpecialty.SelectedValue);
                teacher.TeacherTitleId = Convert.ToInt32(cmbTeacherTitle.SelectedValue);
                teacher.TeacherPositionId = Convert.ToInt32(cmbTeacherPosition.SelectedValue);
                teacher.TeacherLoginId = string.Empty;
                teacher.TeacherLoginPwd = string.Empty;
                teacher.TeacherNo = no;
                teacher.TeacherName = name;
                teacher.TeacherGender = "男";
                if (rdoFemale.Checked)
                    teacher.TeacherGender = "女";
                teacher.TeacherEnabled = chkEnabled.Checked;

                if (bllTeacher.AddTeacher(teacher))
                {
                    txtTeacherName.Text = string.Empty;
                    txtTeacherNo.Text = string.Empty;
                    dgvTeacher.DataSource = bllTeacher.GetAllTeacherBusiness(n);
                }
                else
                {
                    MessageBox.Show("添加教师失败");
                }
            }
            else
            {
                MessageBox.Show("部门、教工编号、教师姓名不能为空");
            }
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ExcelToDataSet(filePath); 
            }
        }

        private DataSet ExcelToDataSet(string filePath)
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

            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string strExcel = "select * from [sheet1$]";
            OleDbDataAdapter myCommand = null;
            DataSet ds = null;
            myCommand = new OleDbDataAdapter(strExcel, strConn);
            ds = new DataSet();
            myCommand.Fill(ds, "table1");
            return ds;
        }

        /// <summary>
        /// 单击"选择"单元格时修改值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        /*
        private void dgvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;
            if (dgvTeacher.Columns[e.ColumnIndex].Name != "select") return;
            DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvTeacher.SelectedCells[0];
            if (cell.Value != null && (bool)cell.Value)
            {
                cell.Value = false;
            }
            else
            {
                cell.Value = true;
            }
        }
        
        */
    }
}
