namespace CollegeManagementSystem
{
    partial class AddUser
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
            this.lbladdUserSystem = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbladdUserRoles = new System.Windows.Forms.Label();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.lbladdUserName = new System.Windows.Forms.Label();
            this.txtaddUserName = new System.Windows.Forms.TextBox();
            this.btnaddUserCancel = new System.Windows.Forms.Button();
            this.btnaddUserSubmit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbladdUserSystem
            // 
            this.lbladdUserSystem.AutoSize = true;
            this.lbladdUserSystem.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdUserSystem.Location = new System.Drawing.Point(364, 24);
            this.lbladdUserSystem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladdUserSystem.Name = "lbladdUserSystem";
            this.lbladdUserSystem.Size = new System.Drawing.Size(224, 55);
            this.lbladdUserSystem.TabIndex = 2;
            this.lbladdUserSystem.Text = "Add User ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbladdUserRoles, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbRoles, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbladdUserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtaddUserName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(98, 120);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(815, 328);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lbladdUserRoles
            // 
            this.lbladdUserRoles.AutoSize = true;
            this.lbladdUserRoles.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdUserRoles.Location = new System.Drawing.Point(4, 164);
            this.lbladdUserRoles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladdUserRoles.Name = "lbladdUserRoles";
            this.lbladdUserRoles.Size = new System.Drawing.Size(51, 18);
            this.lbladdUserRoles.TabIndex = 32;
            this.lbladdUserRoles.Text = "Roles";
            // 
            // cbRoles
            // 
            this.cbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoles.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(411, 169);
            this.cbRoles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(383, 26);
            this.cbRoles.TabIndex = 33;
            // 
            // lbladdUserName
            // 
            this.lbladdUserName.AutoSize = true;
            this.lbladdUserName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdUserName.Location = new System.Drawing.Point(4, 0);
            this.lbladdUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladdUserName.Name = "lbladdUserName";
            this.lbladdUserName.Size = new System.Drawing.Size(82, 18);
            this.lbladdUserName.TabIndex = 23;
            this.lbladdUserName.Text = "Username";
            // 
            // txtaddUserName
            // 
            this.txtaddUserName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddUserName.Location = new System.Drawing.Point(411, 5);
            this.txtaddUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtaddUserName.Name = "txtaddUserName";
            this.txtaddUserName.Size = new System.Drawing.Size(383, 26);
            this.txtaddUserName.TabIndex = 24;
            // 
            // btnaddUserCancel
            // 
            this.btnaddUserCancel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddUserCancel.Location = new System.Drawing.Point(610, 463);
            this.btnaddUserCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnaddUserCancel.Name = "btnaddUserCancel";
            this.btnaddUserCancel.Size = new System.Drawing.Size(155, 54);
            this.btnaddUserCancel.TabIndex = 25;
            this.btnaddUserCancel.Text = "Cancel";
            this.btnaddUserCancel.UseVisualStyleBackColor = true;
            this.btnaddUserCancel.Click += new System.EventHandler(this.btnaddUserCancel_Click);
            // 
            // btnaddUserSubmit
            // 
            this.btnaddUserSubmit.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddUserSubmit.Location = new System.Drawing.Point(286, 463);
            this.btnaddUserSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnaddUserSubmit.Name = "btnaddUserSubmit";
            this.btnaddUserSubmit.Size = new System.Drawing.Size(155, 54);
            this.btnaddUserSubmit.TabIndex = 24;
            this.btnaddUserSubmit.Text = "Submit";
            this.btnaddUserSubmit.UseVisualStyleBackColor = true;
            this.btnaddUserSubmit.Click += new System.EventHandler(this.btnaddUserSubmit_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 532);
            this.Controls.Add(this.btnaddUserCancel);
            this.Controls.Add(this.btnaddUserSubmit);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbladdUserSystem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladdUserSystem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbladdUserName;
        private System.Windows.Forms.TextBox txtaddUserName;
        private System.Windows.Forms.Label lbladdUserRoles;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.Button btnaddUserCancel;
        private System.Windows.Forms.Button btnaddUserSubmit;
    }
}