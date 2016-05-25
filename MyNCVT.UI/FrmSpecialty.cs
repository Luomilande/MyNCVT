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
    public partial class FrmSpecialty : Form
    {
        private BLLSpecialty bllSpecialty = new BLLSpecialty();
        private BLLDepartment bllDepartment = new BLLDepartment();
        public FrmSpecialty()
        {
            InitializeComponent();
        }

        private void FrmSpecialty_Load(object sender, EventArgs e)
        {
            InitDepartment();
            lvwSpecialty.Items.Clear();
            lvwSpecialty.FullRowSelect = true;  //整行选中
            IList<SpecialtyBusiness> listSpecialty = bllSpecialty.GetAllSpecialtyBusiness();
            DisplaySpecialty(listSpecialty);
        }

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
            lvwSpecialty.Items.Clear();
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
