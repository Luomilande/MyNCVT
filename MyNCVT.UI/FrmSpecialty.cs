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
            IList<Specialty> listSpecialty = bllSpecialty.GetAllSpecialty();
            if (listSpecialty != null && listSpecialty.Count > 0)
            {
                foreach (Specialty specialty in listSpecialty)
                {
                    ListViewItem lvi = new ListViewItem(specialty.SpecialtyFullName);
                    lvi.SubItems.Add(specialty.DepartmentId.ToString());
                    lvwSpecialty.Items.Add(lvi);
                }
            }
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
            int n = Convert.ToInt32(cmbDepartment.SelectedValue.ToString());
            lvwSpecialty.Items.Clear();
            IList<SpecialtyBusiness> listSpecialty = bllSpecialty.GetSpecialtyByDepartmentId(n);
            if (listSpecialty!=null && listSpecialty.Count>0)
            {
                foreach (Specialty specialty in listSpecialty)
                {
                    ListViewItem lvi = new ListViewItem(specialty.SpecialtyFullName);
                    lvi.SubItems.Add(specialty.DepartmentId.ToString());
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
    }
}
