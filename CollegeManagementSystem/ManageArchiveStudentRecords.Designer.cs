namespace CollegeManagementSystem
{
    partial class ManageArchiveStudentRecords
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
            this.btnstudentASRecordsRefresh = new System.Windows.Forms.Button();
            this.btnaddASRecords = new System.Windows.Forms.Button();
            this.btndeleteASRecords = new System.Windows.Forms.Button();
            this.btneditASRecords = new System.Windows.Forms.Button();
            this.gvArchiveStudentsRecords = new System.Windows.Forms.DataGridView();
            this.lblstudentsASRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvArchiveStudentsRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // btnstudentASRecordsRefresh
            // 
            this.btnstudentASRecordsRefresh.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudentASRecordsRefresh.Location = new System.Drawing.Point(13, 80);
            this.btnstudentASRecordsRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnstudentASRecordsRefresh.Name = "btnstudentASRecordsRefresh";
            this.btnstudentASRecordsRefresh.Size = new System.Drawing.Size(205, 47);
            this.btnstudentASRecordsRefresh.TabIndex = 22;
            this.btnstudentASRecordsRefresh.Text = "Refresh ";
            this.btnstudentASRecordsRefresh.UseVisualStyleBackColor = true;
            // 
            // btnaddASRecords
            // 
            this.btnaddASRecords.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddASRecords.Location = new System.Drawing.Point(640, 134);
            this.btnaddASRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btnaddASRecords.Name = "btnaddASRecords";
            this.btnaddASRecords.Size = new System.Drawing.Size(205, 47);
            this.btnaddASRecords.TabIndex = 21;
            this.btnaddASRecords.Text = "Add Records";
            this.btnaddASRecords.UseVisualStyleBackColor = true;
            this.btnaddASRecords.Click += new System.EventHandler(this.btnaddASRecords_Click);
            // 
            // btndeleteASRecords
            // 
            this.btndeleteASRecords.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteASRecords.Location = new System.Drawing.Point(640, 400);
            this.btndeleteASRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btndeleteASRecords.Name = "btndeleteASRecords";
            this.btndeleteASRecords.Size = new System.Drawing.Size(205, 47);
            this.btndeleteASRecords.TabIndex = 20;
            this.btndeleteASRecords.Text = "Delete Records";
            this.btndeleteASRecords.UseVisualStyleBackColor = true;
            this.btndeleteASRecords.Click += new System.EventHandler(this.btndeleteASRecords_Click);
            // 
            // btneditASRecords
            // 
            this.btneditASRecords.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditASRecords.Location = new System.Drawing.Point(640, 265);
            this.btneditASRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btneditASRecords.Name = "btneditASRecords";
            this.btneditASRecords.Size = new System.Drawing.Size(205, 47);
            this.btneditASRecords.TabIndex = 19;
            this.btneditASRecords.Text = "Edit Records";
            this.btneditASRecords.UseVisualStyleBackColor = true;
            this.btneditASRecords.Click += new System.EventHandler(this.btneditASRecords_Click);
            // 
            // gvArchiveStudentsRecords
            // 
            this.gvArchiveStudentsRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvArchiveStudentsRecords.Location = new System.Drawing.Point(12, 134);
            this.gvArchiveStudentsRecords.Name = "gvArchiveStudentsRecords";
            this.gvArchiveStudentsRecords.Size = new System.Drawing.Size(581, 313);
            this.gvArchiveStudentsRecords.TabIndex = 18;
            // 
            // lblstudentsASRecords
            // 
            this.lblstudentsASRecords.AutoSize = true;
            this.lblstudentsASRecords.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentsASRecords.Location = new System.Drawing.Point(196, 9);
            this.lblstudentsASRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentsASRecords.Name = "lblstudentsASRecords";
            this.lblstudentsASRecords.Size = new System.Drawing.Size(524, 55);
            this.lblstudentsASRecords.TabIndex = 17;
            this.lblstudentsASRecords.Text = "Manage  Student Records";
            // 
            // ManageArchiveStudentRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 488);
            this.Controls.Add(this.btnstudentASRecordsRefresh);
            this.Controls.Add(this.btnaddASRecords);
            this.Controls.Add(this.btndeleteASRecords);
            this.Controls.Add(this.btneditASRecords);
            this.Controls.Add(this.gvArchiveStudentsRecords);
            this.Controls.Add(this.lblstudentsASRecords);
            this.Name = "ManageArchiveStudentRecords";
            this.Text = "Manage Archive Student Records";
            this.Load += new System.EventHandler(this.ManageArchiveStudentRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvArchiveStudentsRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstudentASRecordsRefresh;
        private System.Windows.Forms.Button btnaddASRecords;
        private System.Windows.Forms.Button btndeleteASRecords;
        private System.Windows.Forms.Button btneditASRecords;
        private System.Windows.Forms.DataGridView gvArchiveStudentsRecords;
        private System.Windows.Forms.Label lblstudentsASRecords;
    }
}