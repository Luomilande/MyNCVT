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
    /// <summary>
    /// 专业设置窗体
    /// </summary>
    public partial class FrmSpecialty : Form
    {
        #region Private Members
        private BLLSpecialty bllSpecialty = new BLLSpecialty();
        private BLLDepartment bllDepartment = new BLLDepartment();
        private Specialty specialty = new Specialty();

        #endregion
        public FrmSpecialty()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSpecialty_Load(object sender, EventArgs e)
        {
            InitDepartment();
            lvwSpecialty.FullRowSelect = true;  //整行选中
            IList<SpecialtyBusiness> listSpecialty = bllSpecialty.GetAllSpecialtyBusiness();
            DisplaySpecialty(listSpecialty);
        }

        /// <summary>
        /// 初始化部门下拉框
        /// </summary>
        private void InitDepartment()
        {
            IList<Department> listDepartment = bllDepartment.GetAllDepartment();
            listDepartment.Insert(0, new Department { DepartmentId = -1, DepartmentFullName = "----请选择部门----" });
            cmbDepartment.DisplayMember = "DepartmentFullName";
            cmbDepartment.ValueMember = "DepartmentId";
            cmbDepartment.DataSource = listDepartment;
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            IList<SpecialtyBusiness> listSpecialty = null;
            int n = Convert.ToInt32(cmbDepartment.SelectedValue.ToString());
            if (n == -1)
            {
                listSpecialty = bllSpecialty.GetAllSpecialtyBusiness();
            }
            else
            {
                listSpecialty = bllSpecialty.GetSpecialtyByDepartmentId(n);
            }
            DisplaySpecialty(listSpecialty);
        }

        private void DisplaySpecialty(IList<SpecialtyBusiness> listSpecialty)
        {
            lvwSpecialty.Items.Clear();
            if (listSpecialty != null && listSpecialty.Count > 0)
            {
                foreach (SpecialtyBusiness specialty in listSpecialty)
                {
                    ListViewItem lvi = new ListViewItem(specialty.SpecialtyFullName);
                    lvi.SubItems.Add(specialty.DepartmentShortName.ToString());
                    lvi.Tag = specialty.SpecialtyId;
                    lvwSpecialty.Items.Add(lvi);
                }
            }
            else
            {
                ListViewItem lvi = new ListViewItem("无专业信息");
                lvi.ForeColor = Color.Red;
                lvwSpecialty.Items.Add(lvi);
                //MessageBox.Show("该部门无专业信息，请添加！");
            }
        }

        private void btnSpecialtyManager_Click(object sender, EventArgs e)
        {
            specialty = new Specialty();
            specialty.DepartmentId = Convert.ToInt32(cmbDepartment.SelectedValue);
            specialty.SpecialtyFullName = txtSpecialtyFullName.Text.Trim();
            specialty.SpecialtyShortName = txtSpecialtyShoftName.Text.Trim();
            specialty.SpecialtyDescription = txtSpecialtyDescription.Text;
            if (bllSpecialty.AddSpecialty(specialty))
            {
                IList<SpecialtyBusiness> listSpecialty = bllSpecialty.GetSpecialtyByDepartmentId(specialty.DepartmentId);
                DisplaySpecialty(listSpecialty);
                txtSpecialtyDescription.Text = string.Empty;
                txtSpecialtyDescription.Text = string.Empty;
                txtSpecialtyShoftName.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("无法添加该专业", "添加失败");
            }

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lvwSpecialty.SelectedItems.Count > 0)
            {
                int n =Convert.ToInt32(lvwSpecialty.SelectedItems[0].Tag);
                foreach (ListViewItem item in lvwSpecialty.SelectedItems)
                    for (int i = 0; i < item.SubItems.Count; i++)
                        MessageBox.Show(item.SubItems[i].Text);

            }
        }
    }
}
