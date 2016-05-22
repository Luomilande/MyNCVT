namespace MyNCVT.UI
{
    partial class FrmSpecialty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSpecialtyManager = new System.Windows.Forms.Button();
            this.txtSpecialtyDescription = new System.Windows.Forms.TextBox();
            this.txtSpecialtyShoftName = new System.Windows.Forms.TextBox();
            this.txtSpecialtyFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvwSpecialty = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "部门";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(90, 25);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(233, 20);
            this.cmbDepartment.TabIndex = 1;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSpecialtyManager);
            this.groupBox1.Controls.Add(this.txtSpecialtyDescription);
            this.groupBox1.Controls.Add(this.txtSpecialtyShoftName);
            this.groupBox1.Controls.Add(this.txtSpecialtyFullName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 382);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "专业信息";
            // 
            // btnSpecialtyManager
            // 
            this.btnSpecialtyManager.Location = new System.Drawing.Point(209, 348);
            this.btnSpecialtyManager.Name = "btnSpecialtyManager";
            this.btnSpecialtyManager.Size = new System.Drawing.Size(75, 23);
            this.btnSpecialtyManager.TabIndex = 6;
            this.btnSpecialtyManager.Text = "增加专业";
            this.btnSpecialtyManager.UseVisualStyleBackColor = true;
            // 
            // txtSpecialtyDescription
            // 
            this.txtSpecialtyDescription.Location = new System.Drawing.Point(73, 106);
            this.txtSpecialtyDescription.Multiline = true;
            this.txtSpecialtyDescription.Name = "txtSpecialtyDescription";
            this.txtSpecialtyDescription.Size = new System.Drawing.Size(211, 225);
            this.txtSpecialtyDescription.TabIndex = 5;
            // 
            // txtSpecialtyShoftName
            // 
            this.txtSpecialtyShoftName.Location = new System.Drawing.Point(73, 68);
            this.txtSpecialtyShoftName.Name = "txtSpecialtyShoftName";
            this.txtSpecialtyShoftName.Size = new System.Drawing.Size(211, 21);
            this.txtSpecialtyShoftName.TabIndex = 4;
            // 
            // txtSpecialtyFullName
            // 
            this.txtSpecialtyFullName.Location = new System.Drawing.Point(73, 29);
            this.txtSpecialtyFullName.Name = "txtSpecialtyFullName";
            this.txtSpecialtyFullName.Size = new System.Drawing.Size(211, 21);
            this.txtSpecialtyFullName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "专业描述";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "专业简称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "专业名称";
            // 
            // lvwSpecialty
            // 
            this.lvwSpecialty.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwSpecialty.GridLines = true;
            this.lvwSpecialty.Location = new System.Drawing.Point(343, 25);
            this.lvwSpecialty.Name = "lvwSpecialty";
            this.lvwSpecialty.Size = new System.Drawing.Size(319, 373);
            this.lvwSpecialty.TabIndex = 3;
            this.lvwSpecialty.UseCompatibleStateImageBehavior = false;
            this.lvwSpecialty.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "专业名称";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "部门";
            this.columnHeader2.Width = 80;
            // 
            // FrmSpecialty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 461);
            this.Controls.Add(this.lvwSpecialty);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label1);
            this.Name = "FrmSpecialty";
            this.Text = "专业管理";
            this.Load += new System.EventHandler(this.FrmSpecialty_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSpecialtyManager;
        private System.Windows.Forms.TextBox txtSpecialtyDescription;
        private System.Windows.Forms.TextBox txtSpecialtyShoftName;
        private System.Windows.Forms.TextBox txtSpecialtyFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvwSpecialty;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}