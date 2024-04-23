namespace CollegeManagementSystem
{
    partial class ManageCourseRecords
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
            this.btnaddCRecords = new System.Windows.Forms.Button();
            this.btndeleteCRecords = new System.Windows.Forms.Button();
            this.btneditCRecords = new System.Windows.Forms.Button();
            this.gvCourseRecords = new System.Windows.Forms.DataGridView();
            this.lblstudentsCourseRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourseRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaddCRecords
            // 
            this.btnaddCRecords.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddCRecords.Location = new System.Drawing.Point(29, 427);
            this.btnaddCRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btnaddCRecords.Name = "btnaddCRecords";
            this.btnaddCRecords.Size = new System.Drawing.Size(205, 47);
            this.btnaddCRecords.TabIndex = 19;
            this.btnaddCRecords.Text = "Add Records";
            this.btnaddCRecords.UseVisualStyleBackColor = true;
            this.btnaddCRecords.Click += new System.EventHandler(this.btnaddCRecords_Click);
            // 
            // btndeleteCRecords
            // 
            this.btndeleteCRecords.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteCRecords.Location = new System.Drawing.Point(665, 427);
            this.btndeleteCRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btndeleteCRecords.Name = "btndeleteCRecords";
            this.btndeleteCRecords.Size = new System.Drawing.Size(205, 47);
            this.btndeleteCRecords.TabIndex = 18;
            this.btndeleteCRecords.Text = "Delete Records";
            this.btndeleteCRecords.UseVisualStyleBackColor = true;
            this.btndeleteCRecords.Click += new System.EventHandler(this.btndeleteCRecords_Click);
            // 
            // btneditCRecords
            // 
            this.btneditCRecords.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditCRecords.Location = new System.Drawing.Point(346, 427);
            this.btneditCRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btneditCRecords.Name = "btneditCRecords";
            this.btneditCRecords.Size = new System.Drawing.Size(205, 47);
            this.btneditCRecords.TabIndex = 17;
            this.btneditCRecords.Text = "Edit Records";
            this.btneditCRecords.UseVisualStyleBackColor = true;
            this.btneditCRecords.Click += new System.EventHandler(this.btneditCRecords_Click);
            // 
            // gvCourseRecords
            // 
            this.gvCourseRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCourseRecords.Location = new System.Drawing.Point(29, 96);
            this.gvCourseRecords.Name = "gvCourseRecords";
            this.gvCourseRecords.Size = new System.Drawing.Size(841, 313);
            this.gvCourseRecords.TabIndex = 16;
            // 
            // lblstudentsCourseRecords
            // 
            this.lblstudentsCourseRecords.AutoSize = true;
            this.lblstudentsCourseRecords.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentsCourseRecords.Location = new System.Drawing.Point(285, 9);
            this.lblstudentsCourseRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentsCourseRecords.Name = "lblstudentsCourseRecords";
            this.lblstudentsCourseRecords.Size = new System.Drawing.Size(337, 55);
            this.lblstudentsCourseRecords.TabIndex = 20;
            this.lblstudentsCourseRecords.Text = "Course Records ";
            // 
            // ManageCourseRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 503);
            this.Controls.Add(this.lblstudentsCourseRecords);
            this.Controls.Add(this.btnaddCRecords);
            this.Controls.Add(this.btndeleteCRecords);
            this.Controls.Add(this.btneditCRecords);
            this.Controls.Add(this.gvCourseRecords);
            this.Name = "ManageCourseRecords";
            this.Text = "Manage Course Records";
            this.Load += new System.EventHandler(this.ManageCourseRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCourseRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddCRecords;
        private System.Windows.Forms.Button btndeleteCRecords;
        private System.Windows.Forms.Button btneditCRecords;
        private System.Windows.Forms.DataGridView gvCourseRecords;
        private System.Windows.Forms.Label lblstudentsCourseRecords;
    }
}