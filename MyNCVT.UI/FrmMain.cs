using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyNCVT.UI
{
    public partial class FrmMain : Form
    {
        #region Private Members

        #endregion

        public FrmMain()
        {
            InitializeComponent();
        }

        private void tsmiDepartmentSpecialty_Click(object sender, EventArgs e)
        {
            FrmDepartment frmDepartment = new FrmDepartment();
            frmDepartment.MdiParent = this;
            frmDepartment.Show();
        }

        private void tsmiSpecialtyInfo_Click(object sender, EventArgs e)
        {
            FrmSpecialty frmSpecialty = new FrmSpecialty();
            frmSpecialty.MdiParent = this;
            frmSpecialty.Show();
        }

        private void tsmiTeacherManager_Click(object sender, EventArgs e)
        {
            FrmTeacher frmTeacher = new FrmTeacher();
            frmTeacher.MdiParent = this;
            frmTeacher.Show();
        }

        private void tsmiAdminInfo_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.MdiParent = this;
            frmAdmin.Show();
        }

        
    }
}
