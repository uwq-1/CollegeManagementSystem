namespace CollegeManagementSystem
{
    partial class ResetPassword
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
            this.lblresetPassword = new System.Windows.Forms.Label();
            this.txtresetPassword = new System.Windows.Forms.TextBox();
            this.lblresetConfirmPassword = new System.Windows.Forms.Label();
            this.txtresetConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblresetPassword
            // 
            this.lblresetPassword.AutoSize = true;
            this.lblresetPassword.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresetPassword.Location = new System.Drawing.Point(27, 105);
            this.lblresetPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresetPassword.Name = "lblresetPassword";
            this.lblresetPassword.Size = new System.Drawing.Size(122, 18);
            this.lblresetPassword.TabIndex = 4;
            this.lblresetPassword.Text = "New password";
            // 
            // txtresetPassword
            // 
            this.txtresetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresetPassword.Location = new System.Drawing.Point(204, 100);
            this.txtresetPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtresetPassword.Name = "txtresetPassword";
            this.txtresetPassword.PasswordChar = '*';
            this.txtresetPassword.Size = new System.Drawing.Size(329, 23);
            this.txtresetPassword.TabIndex = 5;
            // 
            // lblresetConfirmPassword
            // 
            this.lblresetConfirmPassword.AutoSize = true;
            this.lblresetConfirmPassword.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresetConfirmPassword.Location = new System.Drawing.Point(27, 195);
            this.lblresetConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresetConfirmPassword.Name = "lblresetConfirmPassword";
            this.lblresetConfirmPassword.Size = new System.Drawing.Size(144, 18);
            this.lblresetConfirmPassword.TabIndex = 6;
            this.lblresetConfirmPassword.Text = "Confirm Password";
            // 
            // txtresetConfirmPassword
            // 
            this.txtresetConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresetConfirmPassword.Location = new System.Drawing.Point(204, 190);
            this.txtresetConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtresetConfirmPassword.Name = "txtresetConfirmPassword";
            this.txtresetConfirmPassword.PasswordChar = '*';
            this.txtresetConfirmPassword.Size = new System.Drawing.Size(329, 23);
            this.txtresetConfirmPassword.TabIndex = 7;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.Location = new System.Drawing.Point(149, 308);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(223, 47);
            this.btnResetPassword.TabIndex = 13;
            this.btnResetPassword.Text = "Reset  Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 435);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.txtresetConfirmPassword);
            this.Controls.Add(this.lblresetConfirmPassword);
            this.Controls.Add(this.txtresetPassword);
            this.Controls.Add(this.lblresetPassword);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblresetPassword;
        private System.Windows.Forms.TextBox txtresetPassword;
        private System.Windows.Forms.Label lblresetConfirmPassword;
        private System.Windows.Forms.TextBox txtresetConfirmPassword;
        private System.Windows.Forms.Button btnResetPassword;
    }
}