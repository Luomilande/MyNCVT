using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyNCVT.BLL;
using MyNCVT.Model;

namespace MyNCVT.UI
{
    public partial class FrmDepartment : Form
    {
        #region Private Members
        private BLLDepartment bllDepartment = new BLLDepartment();
        private Department department = new Department();
        #endregion
        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            InitDepartment();
        }

        private void InitDepartment()
        {
            lstbDepartment.SelectionMode = SelectionMode.One;
            lstbDepartment.DisplayMember = "DepartmentFullName";
            lstbDepartment.ValueMember = "DepartmentId";
            lstbDepartment.DataSource = bllDepartment.GetAllDepartment();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(btnAdd.Text=="保存修改")
            {
                department.DepartmentFullName = txtFullName.Text.Trim();
                department.DepartmentShortName = txtShortName.Text.Trim();
                department.DepartmentDescription = txtDescription.Text;
                if (bllDepartment.ModifyDepartment(department))
                {
                    btnAdd.Text = "添加";
                    txtDescription.Text = string.Empty;
                    txtFullName.Text = string.Empty;
                    txtShortName.Text = string.Empty;
                    InitDepartment();
                    btnModify.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Visible = false;
                }
                else
                {
                    MessageBox.Show(string.Format("无法修改部门:{0}", department.DepartmentFullName), "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AddDepartmnet();
            }          
        }

        private void AddDepartmnet()
        {
            department = new Department();
            department.DepartmentFullName = txtFullName.Text.Trim();
            department.DepartmentShortName = txtShortName.Text.Trim();
            department.DepartmentDescription = txtDescription.Text;
            if (bllDepartment.AddDepartment(department))
            {
                txtDescription.Text = string.Empty;
                txtFullName.Text = string.Empty;
                txtShortName.Text = string.Empty;
                InitDepartment();                
            }
            else
            {
                MessageBox.Show(string.Format("无法添加部门:{0}", department.DepartmentFullName), "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int n =Convert.ToInt32(lstbDepartment.SelectedValue.ToString());
            if (bllDepartment.DeleteDepartmentByDepartmentId(n))
            {
                InitDepartment();
            }
            else
            {
                MessageBox.Show("无法删除部门", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(lstbDepartment.SelectedValue.ToString());
            department = bllDepartment.GetDepartmentByDepartmentId(n);
            txtFullName.Text = department.DepartmentFullName;
            txtShortName.Text = department.DepartmentShortName;
            txtDescription.Text = department.DepartmentDescription;
            btnAdd.Text = "保存修改";
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnModify.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Visible = false;
            txtDescription.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtShortName.Text = string.Empty;
        }
    }
}
