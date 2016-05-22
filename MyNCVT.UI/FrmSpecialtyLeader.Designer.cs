namespace MyNCVT.UI
{
    partial class FrmSpecialtyLeader
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
            this.tvwDepartmentSpecialty = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tvwDepartmentSpecialty
            // 
            this.tvwDepartmentSpecialty.Location = new System.Drawing.Point(12, 12);
            this.tvwDepartmentSpecialty.Name = "tvwDepartmentSpecialty";
            this.tvwDepartmentSpecialty.Size = new System.Drawing.Size(240, 482);
            this.tvwDepartmentSpecialty.TabIndex = 0;
            // 
            // FrmSpecialtyLeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 506);
            this.Controls.Add(this.tvwDepartmentSpecialty);
            this.Name = "FrmSpecialtyLeader";
            this.Text = "专业负责人设置";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwDepartmentSpecialty;
    }
}