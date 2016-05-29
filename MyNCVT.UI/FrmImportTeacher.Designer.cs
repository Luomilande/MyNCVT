namespace MyNCVT.UI
{
    partial class FrmImportTeacher
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
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.btnImportTeacher = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AllowUserToAddRows = false;
            this.dgvTeacher.AllowUserToDeleteRows = false;
            this.dgvTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Location = new System.Drawing.Point(12, 85);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.ReadOnly = true;
            this.dgvTeacher.RowTemplate.Height = 23;
            this.dgvTeacher.Size = new System.Drawing.Size(959, 390);
            this.dgvTeacher.TabIndex = 0;
            // 
            // btnImportTeacher
            // 
            this.btnImportTeacher.Location = new System.Drawing.Point(714, 45);
            this.btnImportTeacher.Name = "btnImportTeacher";
            this.btnImportTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnImportTeacher.TabIndex = 1;
            this.btnImportTeacher.Text = "打开文件";
            this.btnImportTeacher.UseVisualStyleBackColor = true;
            this.btnImportTeacher.Click += new System.EventHandler(this.btnImportTeacher_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(821, 46);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "确认导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 57);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 12);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "label1";
            // 
            // FrmImportTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 487);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnImportTeacher);
            this.Controls.Add(this.dgvTeacher);
            this.Name = "FrmImportTeacher";
            this.Text = "FrmImportTeacher";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.Button btnImportTeacher;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblTotal;
    }
}