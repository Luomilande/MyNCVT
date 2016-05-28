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
        /// 窗体载入事件
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
        /// 初始化教师数据表格
        /// </summary>
        private void InitDgvTeacher()
        {
            dgvTeacher.AutoGenerateColumns = false;
            dgvTeacher.MultiSelect = false;
            dgvTeacher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeacher.DataSource = bllTeacher.GetAllTeacherBusiness();
        }

        /// <summary>
        /// 初始化岗位下拉框
        /// </summary>
        private void InitTeacherPosition()
        {
            cmbTeacherPosition.DisplayMember = "TeacherPositionName";
            cmbTeacherPosition.ValueMember = "TeacherPositionId";
            cmbTeacherPosition.DataSource = bllTeacherPosition.GetAllTeacherPositon();
        }

        /// <summary>
        /// 初始化职称下拉框
        /// </summary>
        private void InitTeacherTitle()
        {
            cmbTeacherTitle.DisplayMember = "TeacherTitleName";
            cmbTeacherTitle.ValueMember = "TeacherTitleId";
            cmbTeacherTitle.DataSource = bllTeacherTitle.GetAllTeacherTitle();
        }

        /// <summary>
        /// 初始化部门下拉框
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
        /// 添加教师按钮
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
                teacher.SpecialtyId = int.Parse(cmbSpecialty.SelectedValue.ToString());
                teacher.TeacherTitleId = int.Parse(cmbTeacherTitle.SelectedValue.ToString());
                teacher.TeacherPositionId = int.Parse(cmbTeacherPosition.SelectedValue.ToString());
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
