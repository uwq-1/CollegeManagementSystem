namespace CollegeManagementSystem
{
    partial class ManageStudentsRecords
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
            this.lblstudentsRecords = new System.Windows.Forms.Label();
            this.gvStudentsRecords = new System.Windows.Forms.DataGridView();
            this.btneditSRecords = new System.Windows.Forms.Button();
            this.btndeleteSRecords = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentsRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstudentsRecords
            // 
            this.lblstudentsRecords.AutoSize = true;
            this.lblstudentsRecords.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentsRecords.Location = new System.Drawing.Point(181, 18);
            this.lblstudentsRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentsRecords.Name = "lblstudentsRecords";
            this.lblstudentsRecords.Size = new System.Drawing.Size(383, 55);
            this.lblstudentsRecords.TabIndex = 2;
            this.lblstudentsRecords.Text = "Students Records ";
            // 
            // gvStudentsRecords
            // 
            this.gvStudentsRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudentsRecords.Location = new System.Drawing.Point(12, 116);
            this.gvStudentsRecords.Name = "gvStudentsRecords";
            this.gvStudentsRecords.Size = new System.Drawing.Size(524, 313);
            this.gvStudentsRecords.TabIndex = 3;
            // 
            // btneditSRecords
            // 
            this.btneditSRecords.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditSRecords.Location = new System.Drawing.Point(621, 116);
            this.btneditSRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btneditSRecords.Name = "btneditSRecords";
            this.btneditSRecords.Size = new System.Drawing.Size(205, 47);
            this.btneditSRecords.TabIndex = 13;
            this.btneditSRecords.Text = "Edit Records";
            this.btneditSRecords.UseVisualStyleBackColor = true;
            // 
            // btndeleteSRecords
            // 
            this.btndeleteSRecords.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteSRecords.Location = new System.Drawing.Point(621, 262);
            this.btndeleteSRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btndeleteSRecords.Name = "btndeleteSRecords";
            this.btndeleteSRecords.Size = new System.Drawing.Size(205, 47);
            this.btndeleteSRecords.TabIndex = 14;
            this.btndeleteSRecords.Text = "Delete Records";
            this.btndeleteSRecords.UseVisualStyleBackColor = true;
            // 
            // ManageStudentsRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 478);
            this.Controls.Add(this.btndeleteSRecords);
            this.Controls.Add(this.btneditSRecords);
            this.Controls.Add(this.gvStudentsRecords);
            this.Controls.Add(this.lblstudentsRecords);
            this.Name = "ManageStudentsRecords";
            this.Text = "Manage Students Records";
            this.Load += new System.EventHandler(this.ManageStudentsRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentsRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstudentsRecords;
        private System.Windows.Forms.DataGridView gvStudentsRecords;
        private System.Windows.Forms.Button btneditSRecords;
        private System.Windows.Forms.Button btndeleteSRecords;
    }
}