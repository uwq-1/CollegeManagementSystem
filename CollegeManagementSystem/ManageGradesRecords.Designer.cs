namespace CollegeManagementSystem
{
    partial class ManageGradesRecords
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
            this.lblstudentsGradesRecords = new System.Windows.Forms.Label();
            this.gvGradesRecords = new System.Windows.Forms.DataGridView();
            this.btneditSRecords = new System.Windows.Forms.Button();
            this.btndeleteSRecords = new System.Windows.Forms.Button();
            this.btnaddSRecords = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvGradesRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstudentsGradesRecords
            // 
            this.lblstudentsGradesRecords.AutoSize = true;
            this.lblstudentsGradesRecords.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentsGradesRecords.Location = new System.Drawing.Point(257, 18);
            this.lblstudentsGradesRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentsGradesRecords.Name = "lblstudentsGradesRecords";
            this.lblstudentsGradesRecords.Size = new System.Drawing.Size(343, 55);
            this.lblstudentsGradesRecords.TabIndex = 2;
            this.lblstudentsGradesRecords.Text = "Grades Records ";
            // 
            // gvGradesRecords
            // 
            this.gvGradesRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGradesRecords.Location = new System.Drawing.Point(13, 112);
            this.gvGradesRecords.Name = "gvGradesRecords";
            this.gvGradesRecords.Size = new System.Drawing.Size(841, 313);
            this.gvGradesRecords.TabIndex = 3;
            // 
            // btneditSRecords
            // 
            this.btneditSRecords.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditSRecords.Location = new System.Drawing.Point(330, 443);
            this.btneditSRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btneditSRecords.Name = "btneditSRecords";
            this.btneditSRecords.Size = new System.Drawing.Size(205, 47);
            this.btneditSRecords.TabIndex = 13;
            this.btneditSRecords.Text = "Edit Records";
            this.btneditSRecords.UseVisualStyleBackColor = true;
            this.btneditSRecords.Click += new System.EventHandler(this.btneditSRecords_Click);
            // 
            // btndeleteSRecords
            // 
            this.btndeleteSRecords.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteSRecords.Location = new System.Drawing.Point(649, 443);
            this.btndeleteSRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btndeleteSRecords.Name = "btndeleteSRecords";
            this.btndeleteSRecords.Size = new System.Drawing.Size(205, 47);
            this.btndeleteSRecords.TabIndex = 14;
            this.btndeleteSRecords.Text = "Delete Records";
            this.btndeleteSRecords.UseVisualStyleBackColor = true;
            this.btndeleteSRecords.Click += new System.EventHandler(this.btndeleteSRecords_Click);
            // 
            // btnaddSRecords
            // 
            this.btnaddSRecords.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddSRecords.Location = new System.Drawing.Point(13, 443);
            this.btnaddSRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btnaddSRecords.Name = "btnaddSRecords";
            this.btnaddSRecords.Size = new System.Drawing.Size(205, 47);
            this.btnaddSRecords.TabIndex = 15;
            this.btnaddSRecords.Text = "Add Records";
            this.btnaddSRecords.UseVisualStyleBackColor = true;
            this.btnaddSRecords.Click += new System.EventHandler(this.btnaddSRecords_Click);
            // 
            // ManageGradesRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 503);
            this.Controls.Add(this.btnaddSRecords);
            this.Controls.Add(this.btndeleteSRecords);
            this.Controls.Add(this.btneditSRecords);
            this.Controls.Add(this.gvGradesRecords);
            this.Controls.Add(this.lblstudentsGradesRecords);
            this.Name = "ManageGradesRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Grades Records";
            this.Load += new System.EventHandler(this.ManageStudentsRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvGradesRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstudentsGradesRecords;
        private System.Windows.Forms.DataGridView gvGradesRecords;
        private System.Windows.Forms.Button btneditSRecords;
        private System.Windows.Forms.Button btndeleteSRecords;
        private System.Windows.Forms.Button btnaddSRecords;
    }
}