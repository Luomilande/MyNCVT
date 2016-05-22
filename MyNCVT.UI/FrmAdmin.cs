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
    public partial class FrmAdmin : Form
    {
        private BLLAdmin bllAdmin = new BLLAdmin();
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {            
            dataGridView1.DataSource = bllAdmin.GetAllAdmin().Tables[0];
        }
    }
}
