namespace CollegeManagementSystem
{
    partial class ManageUser
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
            this.btnaddUser = new System.Windows.Forms.Button();
            this.btndeativateUser = new System.Windows.Forms.Button();
            this.btnresetPassword = new System.Windows.Forms.Button();
            this.gvUserSettingsRecords = new System.Windows.Forms.DataGridView();
            this.lbluserCRTitle = new System.Windows.Forms.Label();
            this.btndeleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserSettingsRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaddUser
            // 
            this.btnaddUser.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddUser.Location = new System.Drawing.Point(32, 440);
            this.btnaddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnaddUser.Name = "btnaddUser";
            this.btnaddUser.Size = new System.Drawing.Size(205, 47);
            this.btnaddUser.TabIndex = 25;
            this.btnaddUser.Text = "Add New User";
            this.btnaddUser.UseVisualStyleBackColor = true;
            this.btnaddUser.Click += new System.EventHandler(this.btnaddUser_Click);
            // 
            // btndeativateUser
            // 
            this.btndeativateUser.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeativateUser.Location = new System.Drawing.Point(596, 440);
            this.btndeativateUser.Margin = new System.Windows.Forms.Padding(4);
            this.btndeativateUser.Name = "btndeativateUser";
            this.btndeativateUser.Size = new System.Drawing.Size(277, 47);
            this.btndeativateUser.TabIndex = 24;
            this.btndeativateUser.Text = "Deactivate/Activate User";
            this.btndeativateUser.UseVisualStyleBackColor = true;
            this.btndeativateUser.Click += new System.EventHandler(this.btndeativateUser_Click);
            // 
            // btnresetPassword
            // 
            this.btnresetPassword.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetPassword.Location = new System.Drawing.Point(317, 440);
            this.btnresetPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnresetPassword.Name = "btnresetPassword";
            this.btnresetPassword.Size = new System.Drawing.Size(205, 47);
            this.btnresetPassword.TabIndex = 23;
            this.btnresetPassword.Text = "Reset Password";
            this.btnresetPassword.UseVisualStyleBackColor = true;
            this.btnresetPassword.Click += new System.EventHandler(this.btnresetPassword_Click);
            // 
            // gvUserSettingsRecords
            // 
            this.gvUserSettingsRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserSettingsRecords.Location = new System.Drawing.Point(32, 109);
            this.gvUserSettingsRecords.Name = "gvUserSettingsRecords";
            this.gvUserSettingsRecords.Size = new System.Drawing.Size(841, 313);
            this.gvUserSettingsRecords.TabIndex = 22;
            // 
            // lbluserCRTitle
            // 
            this.lbluserCRTitle.AutoSize = true;
            this.lbluserCRTitle.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserCRTitle.Location = new System.Drawing.Point(276, 15);
            this.lbluserCRTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluserCRTitle.Name = "lbluserCRTitle";
            this.lbluserCRTitle.Size = new System.Drawing.Size(286, 55);
            this.lbluserCRTitle.TabIndex = 21;
            this.lbluserCRTitle.Text = "Users Control";
            // 
            // btndeleteUser
            // 
            this.btndeleteUser.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteUser.Location = new System.Drawing.Point(32, 44);
            this.btndeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.btndeleteUser.Name = "btndeleteUser";
            this.btndeleteUser.Size = new System.Drawing.Size(205, 47);
            this.btndeleteUser.TabIndex = 26;
            this.btndeleteUser.Text = "Delete User";
            this.btndeleteUser.UseVisualStyleBackColor = true;
            this.btndeleteUser.Click += new System.EventHandler(this.btndeleteUser_Click);
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 503);
            this.Controls.Add(this.btndeleteUser);
            this.Controls.Add(this.btnaddUser);
            this.Controls.Add(this.btndeativateUser);
            this.Controls.Add(this.btnresetPassword);
            this.Controls.Add(this.gvUserSettingsRecords);
            this.Controls.Add(this.lbluserCRTitle);
            this.Name = "ManageUser";
            this.Text = "Manage User";
            this.Load += new System.EventHandler(this.ManageUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUserSettingsRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddUser;
        private System.Windows.Forms.Button btndeativateUser;
        private System.Windows.Forms.Button btnresetPassword;
        private System.Windows.Forms.DataGridView gvUserSettingsRecords;
        private System.Windows.Forms.Label lbluserCRTitle;
        private System.Windows.Forms.Button btndeleteUser;
    }
}