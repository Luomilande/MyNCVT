namespace MyNCVT.UI
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.tsmiSystemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTermSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdminInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDepartmentInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpecialtyInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTeacherInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTeacherManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStudentInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCourseInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMain
            // 
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSystemInfo,
            this.tsmiDepartment,
            this.tsmiTeacherInfo,
            this.tsmiStudentInfo,
            this.tsmiCourseInfo});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(1084, 25);
            this.mnsMain.TabIndex = 0;
            this.mnsMain.Text = "menuStrip1";
            // 
            // tsmiSystemInfo
            // 
            this.tsmiSystemInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTermSetup,
            this.tsmiAdminInfo});
            this.tsmiSystemInfo.Name = "tsmiSystemInfo";
            this.tsmiSystemInfo.Size = new System.Drawing.Size(68, 21);
            this.tsmiSystemInfo.Text = "系统设置";
            // 
            // tsmiTermSetup
            // 
            this.tsmiTermSetup.Name = "tsmiTermSetup";
            this.tsmiTermSetup.Size = new System.Drawing.Size(152, 22);
            this.tsmiTermSetup.Text = "学年学期设置";
            // 
            // tsmiAdminInfo
            // 
            this.tsmiAdminInfo.Name = "tsmiAdminInfo";
            this.tsmiAdminInfo.Size = new System.Drawing.Size(152, 22);
            this.tsmiAdminInfo.Text = "管理员信息";
            this.tsmiAdminInfo.Click += new System.EventHandler(this.tsmiAdminInfo_Click);
            // 
            // tsmiDepartment
            // 
            this.tsmiDepartment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDepartmentInfo,
            this.tsmiSpecialtyInfo});
            this.tsmiDepartment.Name = "tsmiDepartment";
            this.tsmiDepartment.Size = new System.Drawing.Size(68, 21);
            this.tsmiDepartment.Text = "部门管理";
            // 
            // tsmiDepartmentInfo
            // 
            this.tsmiDepartmentInfo.Name = "tsmiDepartmentInfo";
            this.tsmiDepartmentInfo.Size = new System.Drawing.Size(124, 22);
            this.tsmiDepartmentInfo.Text = "部门设置";
            this.tsmiDepartmentInfo.Click += new System.EventHandler(this.tsmiDepartmentSpecialty_Click);
            // 
            // tsmiSpecialtyInfo
            // 
            this.tsmiSpecialtyInfo.Name = "tsmiSpecialtyInfo";
            this.tsmiSpecialtyInfo.Size = new System.Drawing.Size(124, 22);
            this.tsmiSpecialtyInfo.Text = "专业设置";
            this.tsmiSpecialtyInfo.Click += new System.EventHandler(this.tsmiSpecialtyInfo_Click);
            // 
            // tsmiTeacherInfo
            // 
            this.tsmiTeacherInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTeacherManager});
            this.tsmiTeacherInfo.Name = "tsmiTeacherInfo";
            this.tsmiTeacherInfo.Size = new System.Drawing.Size(68, 21);
            this.tsmiTeacherInfo.Text = "教师管理";
            // 
            // tsmiTeacherManager
            // 
            this.tsmiTeacherManager.Name = "tsmiTeacherManager";
            this.tsmiTeacherManager.Size = new System.Drawing.Size(124, 22);
            this.tsmiTeacherManager.Text = "教师设置";
            this.tsmiTeacherManager.Click += new System.EventHandler(this.tsmiTeacherManager_Click);
            // 
            // tsmiStudentInfo
            // 
            this.tsmiStudentInfo.Name = "tsmiStudentInfo";
            this.tsmiStudentInfo.Size = new System.Drawing.Size(68, 21);
            this.tsmiStudentInfo.Text = "学生管理";
            // 
            // tsmiCourseInfo
            // 
            this.tsmiCourseInfo.Name = "tsmiCourseInfo";
            this.tsmiCourseInfo.Size = new System.Drawing.Size(68, 21);
            this.tsmiCourseInfo.Text = "课程管理";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 641);
            this.Controls.Add(this.mnsMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMain;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "南宁职业技术学院数字化校园系统 V0.1";
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystemInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiTermSetup;
        private System.Windows.Forms.ToolStripMenuItem tsmiTeacherInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiStudentInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdminInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiCourseInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiTeacherManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiDepartment;
        private System.Windows.Forms.ToolStripMenuItem tsmiDepartmentInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpecialtyInfo;
    }
}

