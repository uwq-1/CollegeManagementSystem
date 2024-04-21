namespace CollegeManagementSystem
{
    partial class ManageTeacherRecords
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
            this.btnaddTRecords = new System.Windows.Forms.Button();
            this.btndeleteTRecords = new System.Windows.Forms.Button();
            this.btneditTRecords = new System.Windows.Forms.Button();
            this.gvTeacherRecords = new System.Windows.Forms.DataGridView();
            this.lblteacherTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvTeacherRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaddTRecords
            // 
            this.btnaddTRecords.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddTRecords.Location = new System.Drawing.Point(32, 440);
            this.btnaddTRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btnaddTRecords.Name = "btnaddTRecords";
            this.btnaddTRecords.Size = new System.Drawing.Size(205, 47);
            this.btnaddTRecords.TabIndex = 20;
            this.btnaddTRecords.Text = "Add Records";
            this.btnaddTRecords.UseVisualStyleBackColor = true;
            this.btnaddTRecords.Click += new System.EventHandler(this.btnaddTRecords_Click);
            // 
            // btndeleteTRecords
            // 
            this.btndeleteTRecords.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteTRecords.Location = new System.Drawing.Point(668, 440);
            this.btndeleteTRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btndeleteTRecords.Name = "btndeleteTRecords";
            this.btndeleteTRecords.Size = new System.Drawing.Size(205, 47);
            this.btndeleteTRecords.TabIndex = 19;
            this.btndeleteTRecords.Text = "Delete Records";
            this.btndeleteTRecords.UseVisualStyleBackColor = true;
            this.btndeleteTRecords.Click += new System.EventHandler(this.btndeleteTRecords_Click);
            // 
            // btneditTRecords
            // 
            this.btneditTRecords.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditTRecords.Location = new System.Drawing.Point(359, 440);
            this.btneditTRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btneditTRecords.Name = "btneditTRecords";
            this.btneditTRecords.Size = new System.Drawing.Size(205, 47);
            this.btneditTRecords.TabIndex = 18;
            this.btneditTRecords.Text = "Edit Records";
            this.btneditTRecords.UseVisualStyleBackColor = true;
            this.btneditTRecords.Click += new System.EventHandler(this.btneditTRecords_Click);
            // 
            // gvTeacherRecords
            // 
            this.gvTeacherRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTeacherRecords.Location = new System.Drawing.Point(32, 109);
            this.gvTeacherRecords.Name = "gvTeacherRecords";
            this.gvTeacherRecords.Size = new System.Drawing.Size(841, 313);
            this.gvTeacherRecords.TabIndex = 17;
            // 
            // lblteacherTitle
            // 
            this.lblteacherTitle.AutoSize = true;
            this.lblteacherTitle.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteacherTitle.Location = new System.Drawing.Point(276, 15);
            this.lblteacherTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblteacherTitle.Name = "lblteacherTitle";
            this.lblteacherTitle.Size = new System.Drawing.Size(367, 55);
            this.lblteacherTitle.TabIndex = 16;
            this.lblteacherTitle.Text = "Teacher Records ";
            // 
            // ManageTeacherRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 503);
            this.Controls.Add(this.btnaddTRecords);
            this.Controls.Add(this.btndeleteTRecords);
            this.Controls.Add(this.btneditTRecords);
            this.Controls.Add(this.gvTeacherRecords);
            this.Controls.Add(this.lblteacherTitle);
            this.Name = "ManageTeacherRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Teacher Records";
            this.Load += new System.EventHandler(this.ManageTeacherRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTeacherRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddTRecords;
        private System.Windows.Forms.Button btndeleteTRecords;
        private System.Windows.Forms.Button btneditTRecords;
        private System.Windows.Forms.DataGridView gvTeacherRecords;
        private System.Windows.Forms.Label lblteacherTitle;
    }
}