namespace CollegeManagementSystem
{
    partial class LoginWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblloginPassword = new System.Windows.Forms.Label();
            this.lblloginName = new System.Windows.Forms.Label();
            this.txtloginPassword = new System.Windows.Forms.TextBox();
            this.txtloginUsername = new System.Windows.Forms.TextBox();
            this.lblloginTitle = new System.Windows.Forms.Label();
            this.btnloginSubmit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblloginPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblloginName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtloginPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtloginUsername, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(155, 97);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 357);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblloginPassword
            // 
            this.lblloginPassword.AutoSize = true;
            this.lblloginPassword.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloginPassword.Location = new System.Drawing.Point(6, 178);
            this.lblloginPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblloginPassword.Name = "lblloginPassword";
            this.lblloginPassword.Size = new System.Drawing.Size(81, 18);
            this.lblloginPassword.TabIndex = 5;
            this.lblloginPassword.Text = "Password";
            // 
            // lblloginName
            // 
            this.lblloginName.AutoSize = true;
            this.lblloginName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloginName.Location = new System.Drawing.Point(6, 0);
            this.lblloginName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblloginName.Name = "lblloginName";
            this.lblloginName.Size = new System.Drawing.Size(117, 18);
            this.lblloginName.TabIndex = 4;
            this.lblloginName.Text = "Username / ID";
            // 
            // txtloginPassword
            // 
            this.txtloginPassword.Font = new System.Drawing.Font("Marlett", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtloginPassword.Location = new System.Drawing.Point(382, 183);
            this.txtloginPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtloginPassword.Name = "txtloginPassword";
            this.txtloginPassword.PasswordChar = '*';
            this.txtloginPassword.Size = new System.Drawing.Size(365, 23);
            this.txtloginPassword.TabIndex = 6;
            // 
            // txtloginUsername
            // 
            this.txtloginUsername.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloginUsername.Location = new System.Drawing.Point(382, 5);
            this.txtloginUsername.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtloginUsername.Name = "txtloginUsername";
            this.txtloginUsername.Size = new System.Drawing.Size(365, 26);
            this.txtloginUsername.TabIndex = 7;
            // 
            // lblloginTitle
            // 
            this.lblloginTitle.AutoSize = true;
            this.lblloginTitle.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloginTitle.Location = new System.Drawing.Point(442, 10);
            this.lblloginTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblloginTitle.Name = "lblloginTitle";
            this.lblloginTitle.Size = new System.Drawing.Size(120, 55);
            this.lblloginTitle.TabIndex = 2;
            this.lblloginTitle.Text = "Login";
            // 
            // btnloginSubmit
            // 
            this.btnloginSubmit.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloginSubmit.Location = new System.Drawing.Point(454, 487);
            this.btnloginSubmit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnloginSubmit.Name = "btnloginSubmit";
            this.btnloginSubmit.Size = new System.Drawing.Size(177, 54);
            this.btnloginSubmit.TabIndex = 13;
            this.btnloginSubmit.Text = "Submit";
            this.btnloginSubmit.UseVisualStyleBackColor = true;
            this.btnloginSubmit.Click += new System.EventHandler(this.btnloginSubmit_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 564);
            this.Controls.Add(this.btnloginSubmit);
            this.Controls.Add(this.lblloginTitle);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "LoginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblloginPassword;
        private System.Windows.Forms.Label lblloginName;
        private System.Windows.Forms.Label lblloginTitle;
        private System.Windows.Forms.Button btnloginSubmit;
        public System.Windows.Forms.TextBox txtloginPassword;
        public System.Windows.Forms.TextBox txtloginUsername;
    }
}