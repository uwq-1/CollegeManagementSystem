namespace CollegeManagementSystem
{
    partial class AddEditStudentsRecords
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
            this.btncancelStudentRecordsChanges = new System.Windows.Forms.Button();
            this.btnsaveStudentRecordsChanges = new System.Windows.Forms.Button();
            this.tlStudentRecordsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtstudentRecordsName = new System.Windows.Forms.TextBox();
            this.lblstudentRecordsName = new System.Windows.Forms.Label();
            this.lblstudentRecordsIdNo = new System.Windows.Forms.Label();
            this.lblstudentRecordsPhone = new System.Windows.Forms.Label();
            this.txtstudentRecordsPhone = new System.Windows.Forms.TextBox();
            this.lblstudentRecordsEmail = new System.Windows.Forms.Label();
            this.txtstudentRecordsEmail = new System.Windows.Forms.TextBox();
            this.lblstudentsRecordsDegree = new System.Windows.Forms.Label();
            this.lblstudentsRecordsDOB = new System.Windows.Forms.Label();
            this.dtpstudentRecordsDOB = new System.Windows.Forms.DateTimePicker();
            this.lblstudentRTitle = new System.Windows.Forms.Label();
            this.lblSRId = new System.Windows.Forms.Label();
            this.lblstudentSRRandomNumber = new System.Windows.Forms.Label();
            this.cbstudentSRProgramme = new System.Windows.Forms.ComboBox();
            this.lblstudentSRTutionfee = new System.Windows.Forms.Label();
            this.txtstudentSRTutionFee = new System.Windows.Forms.TextBox();
            this.tlStudentRecordsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncancelStudentRecordsChanges
            // 
            this.btncancelStudentRecordsChanges.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelStudentRecordsChanges.Location = new System.Drawing.Point(441, 381);
            this.btncancelStudentRecordsChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btncancelStudentRecordsChanges.Name = "btncancelStudentRecordsChanges";
            this.btncancelStudentRecordsChanges.Size = new System.Drawing.Size(205, 47);
            this.btncancelStudentRecordsChanges.TabIndex = 19;
            this.btncancelStudentRecordsChanges.Text = "Cancel  Changes";
            this.btncancelStudentRecordsChanges.UseVisualStyleBackColor = true;
            this.btncancelStudentRecordsChanges.Click += new System.EventHandler(this.btncancelStudentRecordsChanges_Click);
            // 
            // btnsaveStudentRecordsChanges
            // 
            this.btnsaveStudentRecordsChanges.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveStudentRecordsChanges.Location = new System.Drawing.Point(115, 381);
            this.btnsaveStudentRecordsChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btnsaveStudentRecordsChanges.Name = "btnsaveStudentRecordsChanges";
            this.btnsaveStudentRecordsChanges.Size = new System.Drawing.Size(205, 47);
            this.btnsaveStudentRecordsChanges.TabIndex = 18;
            this.btnsaveStudentRecordsChanges.Text = "Save Changes";
            this.btnsaveStudentRecordsChanges.UseVisualStyleBackColor = true;
            this.btnsaveStudentRecordsChanges.Click += new System.EventHandler(this.btnsaveStudentRecordsChanges_Click);
            // 
            // tlStudentRecordsPanel
            // 
            this.tlStudentRecordsPanel.ColumnCount = 2;
            this.tlStudentRecordsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlStudentRecordsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlStudentRecordsPanel.Controls.Add(this.lblstudentSRTutionfee, 0, 6);
            this.tlStudentRecordsPanel.Controls.Add(this.lblstudentsRecordsDOB, 0, 5);
            this.tlStudentRecordsPanel.Controls.Add(this.txtstudentRecordsName, 1, 0);
            this.tlStudentRecordsPanel.Controls.Add(this.lblstudentRecordsName, 0, 0);
            this.tlStudentRecordsPanel.Controls.Add(this.lblstudentRecordsIdNo, 0, 1);
            this.tlStudentRecordsPanel.Controls.Add(this.lblstudentRecordsPhone, 0, 2);
            this.tlStudentRecordsPanel.Controls.Add(this.txtstudentRecordsPhone, 1, 2);
            this.tlStudentRecordsPanel.Controls.Add(this.lblstudentRecordsEmail, 0, 3);
            this.tlStudentRecordsPanel.Controls.Add(this.txtstudentRecordsEmail, 1, 3);
            this.tlStudentRecordsPanel.Controls.Add(this.lblstudentsRecordsDegree, 0, 4);
            this.tlStudentRecordsPanel.Controls.Add(this.dtpstudentRecordsDOB, 1, 5);
            this.tlStudentRecordsPanel.Controls.Add(this.lblstudentSRRandomNumber, 1, 1);
            this.tlStudentRecordsPanel.Controls.Add(this.cbstudentSRProgramme, 1, 4);
            this.tlStudentRecordsPanel.Controls.Add(this.txtstudentSRTutionFee, 1, 6);
            this.tlStudentRecordsPanel.Location = new System.Drawing.Point(55, 95);
            this.tlStudentRecordsPanel.Name = "tlStudentRecordsPanel";
            this.tlStudentRecordsPanel.RowCount = 7;
            this.tlStudentRecordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlStudentRecordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlStudentRecordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlStudentRecordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlStudentRecordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlStudentRecordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlStudentRecordsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlStudentRecordsPanel.Size = new System.Drawing.Size(690, 260);
            this.tlStudentRecordsPanel.TabIndex = 20;
            // 
            // txtstudentRecordsName
            // 
            this.txtstudentRecordsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentRecordsName.Location = new System.Drawing.Point(349, 4);
            this.txtstudentRecordsName.Margin = new System.Windows.Forms.Padding(4);
            this.txtstudentRecordsName.Name = "txtstudentRecordsName";
            this.txtstudentRecordsName.Size = new System.Drawing.Size(329, 23);
            this.txtstudentRecordsName.TabIndex = 5;
            // 
            // lblstudentRecordsName
            // 
            this.lblstudentRecordsName.AutoSize = true;
            this.lblstudentRecordsName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentRecordsName.Location = new System.Drawing.Point(4, 0);
            this.lblstudentRecordsName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentRecordsName.Name = "lblstudentRecordsName";
            this.lblstudentRecordsName.Size = new System.Drawing.Size(52, 18);
            this.lblstudentRecordsName.TabIndex = 4;
            this.lblstudentRecordsName.Text = "Name";
            // 
            // lblstudentRecordsIdNo
            // 
            this.lblstudentRecordsIdNo.AutoSize = true;
            this.lblstudentRecordsIdNo.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentRecordsIdNo.Location = new System.Drawing.Point(4, 37);
            this.lblstudentRecordsIdNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentRecordsIdNo.Name = "lblstudentRecordsIdNo";
            this.lblstudentRecordsIdNo.Size = new System.Drawing.Size(52, 18);
            this.lblstudentRecordsIdNo.TabIndex = 6;
            this.lblstudentRecordsIdNo.Text = "Id No";
            // 
            // lblstudentRecordsPhone
            // 
            this.lblstudentRecordsPhone.AutoSize = true;
            this.lblstudentRecordsPhone.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentRecordsPhone.Location = new System.Drawing.Point(4, 74);
            this.lblstudentRecordsPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentRecordsPhone.Name = "lblstudentRecordsPhone";
            this.lblstudentRecordsPhone.Size = new System.Drawing.Size(54, 18);
            this.lblstudentRecordsPhone.TabIndex = 8;
            this.lblstudentRecordsPhone.Text = "Phone";
            // 
            // txtstudentRecordsPhone
            // 
            this.txtstudentRecordsPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentRecordsPhone.Location = new System.Drawing.Point(349, 78);
            this.txtstudentRecordsPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtstudentRecordsPhone.Name = "txtstudentRecordsPhone";
            this.txtstudentRecordsPhone.Size = new System.Drawing.Size(329, 23);
            this.txtstudentRecordsPhone.TabIndex = 9;
            // 
            // lblstudentRecordsEmail
            // 
            this.lblstudentRecordsEmail.AutoSize = true;
            this.lblstudentRecordsEmail.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentRecordsEmail.Location = new System.Drawing.Point(4, 111);
            this.lblstudentRecordsEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentRecordsEmail.Name = "lblstudentRecordsEmail";
            this.lblstudentRecordsEmail.Size = new System.Drawing.Size(49, 18);
            this.lblstudentRecordsEmail.TabIndex = 10;
            this.lblstudentRecordsEmail.Text = "Email";
            // 
            // txtstudentRecordsEmail
            // 
            this.txtstudentRecordsEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentRecordsEmail.Location = new System.Drawing.Point(349, 115);
            this.txtstudentRecordsEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtstudentRecordsEmail.Name = "txtstudentRecordsEmail";
            this.txtstudentRecordsEmail.Size = new System.Drawing.Size(329, 23);
            this.txtstudentRecordsEmail.TabIndex = 11;
            // 
            // lblstudentsRecordsDegree
            // 
            this.lblstudentsRecordsDegree.AutoSize = true;
            this.lblstudentsRecordsDegree.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentsRecordsDegree.Location = new System.Drawing.Point(4, 148);
            this.lblstudentsRecordsDegree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentsRecordsDegree.Name = "lblstudentsRecordsDegree";
            this.lblstudentsRecordsDegree.Size = new System.Drawing.Size(150, 18);
            this.lblstudentsRecordsDegree.TabIndex = 12;
            this.lblstudentsRecordsDegree.Text = "Degree Programme";
            // 
            // lblstudentsRecordsDOB
            // 
            this.lblstudentsRecordsDOB.AutoSize = true;
            this.lblstudentsRecordsDOB.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentsRecordsDOB.Location = new System.Drawing.Point(4, 185);
            this.lblstudentsRecordsDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentsRecordsDOB.Name = "lblstudentsRecordsDOB";
            this.lblstudentsRecordsDOB.Size = new System.Drawing.Size(102, 18);
            this.lblstudentsRecordsDOB.TabIndex = 14;
            this.lblstudentsRecordsDOB.Text = "Date of Birth";
            // 
            // dtpstudentRecordsDOB
            // 
            this.dtpstudentRecordsDOB.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpstudentRecordsDOB.Location = new System.Drawing.Point(348, 188);
            this.dtpstudentRecordsDOB.Name = "dtpstudentRecordsDOB";
            this.dtpstudentRecordsDOB.Size = new System.Drawing.Size(330, 26);
            this.dtpstudentRecordsDOB.TabIndex = 15;
            // 
            // lblstudentRTitle
            // 
            this.lblstudentRTitle.AutoSize = true;
            this.lblstudentRTitle.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentRTitle.Location = new System.Drawing.Point(183, 20);
            this.lblstudentRTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentRTitle.Name = "lblstudentRTitle";
            this.lblstudentRTitle.Size = new System.Drawing.Size(0, 55);
            this.lblstudentRTitle.TabIndex = 21;
            // 
            // lblSRId
            // 
            this.lblSRId.AutoSize = true;
            this.lblSRId.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSRId.Location = new System.Drawing.Point(468, 20);
            this.lblSRId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSRId.Name = "lblSRId";
            this.lblSRId.Size = new System.Drawing.Size(0, 55);
            this.lblSRId.TabIndex = 22;
            this.lblSRId.Visible = false;
            // 
            // lblstudentSRRandomNumber
            // 
            this.lblstudentSRRandomNumber.AutoSize = true;
            this.lblstudentSRRandomNumber.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentSRRandomNumber.Location = new System.Drawing.Point(349, 37);
            this.lblstudentSRRandomNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentSRRandomNumber.Name = "lblstudentSRRandomNumber";
            this.lblstudentSRRandomNumber.Size = new System.Drawing.Size(0, 18);
            this.lblstudentSRRandomNumber.TabIndex = 23;
            // 
            // cbstudentSRProgramme
            // 
            this.cbstudentSRProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstudentSRProgramme.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbstudentSRProgramme.FormattingEnabled = true;
            this.cbstudentSRProgramme.Location = new System.Drawing.Point(349, 152);
            this.cbstudentSRProgramme.Margin = new System.Windows.Forms.Padding(4);
            this.cbstudentSRProgramme.Name = "cbstudentSRProgramme";
            this.cbstudentSRProgramme.Size = new System.Drawing.Size(329, 23);
            this.cbstudentSRProgramme.TabIndex = 24;
            // 
            // lblstudentSRTutionfee
            // 
            this.lblstudentSRTutionfee.AutoSize = true;
            this.lblstudentSRTutionfee.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentSRTutionfee.Location = new System.Drawing.Point(4, 222);
            this.lblstudentSRTutionfee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentSRTutionfee.Name = "lblstudentSRTutionfee";
            this.lblstudentSRTutionfee.Size = new System.Drawing.Size(92, 18);
            this.lblstudentSRTutionfee.TabIndex = 25;
            this.lblstudentSRTutionfee.Text = "Tution  Fee";
            // 
            // txtstudentSRTutionFee
            // 
            this.txtstudentSRTutionFee.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentSRTutionFee.Location = new System.Drawing.Point(349, 226);
            this.txtstudentSRTutionFee.Margin = new System.Windows.Forms.Padding(4);
            this.txtstudentSRTutionFee.Name = "txtstudentSRTutionFee";
            this.txtstudentSRTutionFee.ReadOnly = true;
            this.txtstudentSRTutionFee.Size = new System.Drawing.Size(329, 23);
            this.txtstudentSRTutionFee.TabIndex = 26;
            // 
            // AddEditStudentsRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSRId);
            this.Controls.Add(this.lblstudentRTitle);
            this.Controls.Add(this.tlStudentRecordsPanel);
            this.Controls.Add(this.btncancelStudentRecordsChanges);
            this.Controls.Add(this.btnsaveStudentRecordsChanges);
            this.Name = "AddEditStudentsRecords";
            this.Text = "AddEditStudentsRecords";
            this.Load += new System.EventHandler(this.AddEditStudentsRecords_Load);
            this.tlStudentRecordsPanel.ResumeLayout(false);
            this.tlStudentRecordsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelStudentRecordsChanges;
        private System.Windows.Forms.Button btnsaveStudentRecordsChanges;
        private System.Windows.Forms.TableLayoutPanel tlStudentRecordsPanel;
        private System.Windows.Forms.TextBox txtstudentRecordsName;
        private System.Windows.Forms.Label lblstudentRecordsName;
        private System.Windows.Forms.Label lblstudentRecordsIdNo;
        private System.Windows.Forms.Label lblstudentRecordsPhone;
        private System.Windows.Forms.Label lblstudentsRecordsDOB;
        private System.Windows.Forms.TextBox txtstudentRecordsPhone;
        private System.Windows.Forms.Label lblstudentRecordsEmail;
        private System.Windows.Forms.TextBox txtstudentRecordsEmail;
        private System.Windows.Forms.Label lblstudentsRecordsDegree;
        private System.Windows.Forms.DateTimePicker dtpstudentRecordsDOB;
        private System.Windows.Forms.Label lblstudentRTitle;
        private System.Windows.Forms.Label lblSRId;
        private System.Windows.Forms.Label lblstudentSRRandomNumber;
        private System.Windows.Forms.ComboBox cbstudentSRProgramme;
        private System.Windows.Forms.Label lblstudentSRTutionfee;
        private System.Windows.Forms.TextBox txtstudentSRTutionFee;
    }
}