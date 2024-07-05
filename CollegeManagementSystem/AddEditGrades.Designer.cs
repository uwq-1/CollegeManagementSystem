namespace CollegeManagementSystem
{
    partial class AddEditGrades
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditGrades));
            this.lblstudentGRTitle = new System.Windows.Forms.Label();
            this.lblstudentGRCourseId = new System.Windows.Forms.Label();
            this.tlStudentGradesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblstudentGRGrades = new System.Windows.Forms.Label();
            this.cbstudentGRCourseId = new System.Windows.Forms.ComboBox();
            this.lblstudentGRCourseName = new System.Windows.Forms.Label();
            this.cbstudentGRCourseName = new System.Windows.Forms.ComboBox();
            this.lblstudentGRId = new System.Windows.Forms.Label();
            this.txtstudentGRGrades = new System.Windows.Forms.TextBox();
            this.cbstudentGRIdNo = new System.Windows.Forms.ComboBox();
            this.lblstudentGRName = new System.Windows.Forms.Label();
            this.cbstudentGRName = new System.Windows.Forms.ComboBox();
            this.lblstudentGRLecturer = new System.Windows.Forms.Label();
            this.cbstudentGRLecturer = new System.Windows.Forms.ComboBox();
            this.lblstudentGRComments = new System.Windows.Forms.Label();
            this.txtstudentGRComments = new System.Windows.Forms.TextBox();
            this.txtstudentGRNoOfGrades = new System.Windows.Forms.TextBox();
            this.lblNoOfGrades = new System.Windows.Forms.Label();
            this.btncancelGRGradesCancel = new System.Windows.Forms.Button();
            this.btnsaveGRGradesChanges = new System.Windows.Forms.Button();
            this.lblSRId = new System.Windows.Forms.Label();
            this.pbGrades = new System.Windows.Forms.PictureBox();
            this.pbHelpNoOfGrades = new System.Windows.Forms.PictureBox();
            this.toolTipNoOfGrades = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipGrades = new System.Windows.Forms.ToolTip(this.components);
            this.tlStudentGradesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelpNoOfGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstudentGRTitle
            // 
            this.lblstudentGRTitle.AutoSize = true;
            this.lblstudentGRTitle.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentGRTitle.Location = new System.Drawing.Point(398, 9);
            this.lblstudentGRTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentGRTitle.Name = "lblstudentGRTitle";
            this.lblstudentGRTitle.Size = new System.Drawing.Size(0, 55);
            this.lblstudentGRTitle.TabIndex = 25;
            // 
            // lblstudentGRCourseId
            // 
            this.lblstudentGRCourseId.AutoSize = true;
            this.lblstudentGRCourseId.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentGRCourseId.Location = new System.Drawing.Point(4, 0);
            this.lblstudentGRCourseId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentGRCourseId.Name = "lblstudentGRCourseId";
            this.lblstudentGRCourseId.Size = new System.Drawing.Size(87, 18);
            this.lblstudentGRCourseId.TabIndex = 4;
            this.lblstudentGRCourseId.Text = "Course ID ";
            // 
            // tlStudentGradesPanel
            // 
            this.tlStudentGradesPanel.ColumnCount = 2;
            this.tlStudentGradesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlStudentGradesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlStudentGradesPanel.Controls.Add(this.lblstudentGRCourseId, 0, 0);
            this.tlStudentGradesPanel.Controls.Add(this.lblstudentGRGrades, 0, 7);
            this.tlStudentGradesPanel.Controls.Add(this.cbstudentGRCourseId, 1, 0);
            this.tlStudentGradesPanel.Controls.Add(this.lblstudentGRCourseName, 0, 1);
            this.tlStudentGradesPanel.Controls.Add(this.cbstudentGRCourseName, 1, 1);
            this.tlStudentGradesPanel.Controls.Add(this.lblstudentGRId, 0, 2);
            this.tlStudentGradesPanel.Controls.Add(this.txtstudentGRGrades, 1, 7);
            this.tlStudentGradesPanel.Controls.Add(this.cbstudentGRIdNo, 1, 2);
            this.tlStudentGradesPanel.Controls.Add(this.lblstudentGRName, 0, 3);
            this.tlStudentGradesPanel.Controls.Add(this.cbstudentGRName, 1, 3);
            this.tlStudentGradesPanel.Controls.Add(this.lblstudentGRLecturer, 0, 4);
            this.tlStudentGradesPanel.Controls.Add(this.cbstudentGRLecturer, 1, 4);
            this.tlStudentGradesPanel.Controls.Add(this.lblstudentGRComments, 0, 5);
            this.tlStudentGradesPanel.Controls.Add(this.txtstudentGRComments, 1, 5);
            this.tlStudentGradesPanel.Controls.Add(this.txtstudentGRNoOfGrades, 1, 6);
            this.tlStudentGradesPanel.Controls.Add(this.lblNoOfGrades, 0, 6);
            this.tlStudentGradesPanel.Location = new System.Drawing.Point(35, 88);
            this.tlStudentGradesPanel.Name = "tlStudentGradesPanel";
            this.tlStudentGradesPanel.RowCount = 8;
            this.tlStudentGradesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlStudentGradesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlStudentGradesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlStudentGradesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlStudentGradesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlStudentGradesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlStudentGradesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlStudentGradesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlStudentGradesPanel.Size = new System.Drawing.Size(698, 284);
            this.tlStudentGradesPanel.TabIndex = 24;
            // 
            // lblstudentGRGrades
            // 
            this.lblstudentGRGrades.AutoSize = true;
            this.lblstudentGRGrades.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentGRGrades.Location = new System.Drawing.Point(4, 245);
            this.lblstudentGRGrades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentGRGrades.Name = "lblstudentGRGrades";
            this.lblstudentGRGrades.Size = new System.Drawing.Size(54, 18);
            this.lblstudentGRGrades.TabIndex = 48;
            this.lblstudentGRGrades.Text = "Grade";
            // 
            // cbstudentGRCourseId
            // 
            this.cbstudentGRCourseId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstudentGRCourseId.FormattingEnabled = true;
            this.cbstudentGRCourseId.Location = new System.Drawing.Point(353, 4);
            this.cbstudentGRCourseId.Margin = new System.Windows.Forms.Padding(4);
            this.cbstudentGRCourseId.Name = "cbstudentGRCourseId";
            this.cbstudentGRCourseId.Size = new System.Drawing.Size(329, 21);
            this.cbstudentGRCourseId.TabIndex = 37;
            // 
            // lblstudentGRCourseName
            // 
            this.lblstudentGRCourseName.AutoSize = true;
            this.lblstudentGRCourseName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentGRCourseName.Location = new System.Drawing.Point(4, 35);
            this.lblstudentGRCourseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentGRCourseName.Name = "lblstudentGRCourseName";
            this.lblstudentGRCourseName.Size = new System.Drawing.Size(109, 18);
            this.lblstudentGRCourseName.TabIndex = 38;
            this.lblstudentGRCourseName.Text = "Course Name";
            // 
            // cbstudentGRCourseName
            // 
            this.cbstudentGRCourseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstudentGRCourseName.FormattingEnabled = true;
            this.cbstudentGRCourseName.Location = new System.Drawing.Point(353, 39);
            this.cbstudentGRCourseName.Margin = new System.Windows.Forms.Padding(4);
            this.cbstudentGRCourseName.Name = "cbstudentGRCourseName";
            this.cbstudentGRCourseName.Size = new System.Drawing.Size(329, 21);
            this.cbstudentGRCourseName.TabIndex = 39;
            // 
            // lblstudentGRId
            // 
            this.lblstudentGRId.AutoSize = true;
            this.lblstudentGRId.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentGRId.Location = new System.Drawing.Point(4, 70);
            this.lblstudentGRId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentGRId.Name = "lblstudentGRId";
            this.lblstudentGRId.Size = new System.Drawing.Size(92, 18);
            this.lblstudentGRId.TabIndex = 40;
            this.lblstudentGRId.Text = "Student ID ";
            // 
            // txtstudentGRGrades
            // 
            this.txtstudentGRGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentGRGrades.Location = new System.Drawing.Point(353, 249);
            this.txtstudentGRGrades.Margin = new System.Windows.Forms.Padding(4);
            this.txtstudentGRGrades.Name = "txtstudentGRGrades";
            this.txtstudentGRGrades.Size = new System.Drawing.Size(329, 23);
            this.txtstudentGRGrades.TabIndex = 49;
            // 
            // cbstudentGRIdNo
            // 
            this.cbstudentGRIdNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstudentGRIdNo.FormattingEnabled = true;
            this.cbstudentGRIdNo.Location = new System.Drawing.Point(353, 74);
            this.cbstudentGRIdNo.Margin = new System.Windows.Forms.Padding(4);
            this.cbstudentGRIdNo.Name = "cbstudentGRIdNo";
            this.cbstudentGRIdNo.Size = new System.Drawing.Size(329, 21);
            this.cbstudentGRIdNo.TabIndex = 41;
            // 
            // lblstudentGRName
            // 
            this.lblstudentGRName.AutoSize = true;
            this.lblstudentGRName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentGRName.Location = new System.Drawing.Point(4, 105);
            this.lblstudentGRName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentGRName.Name = "lblstudentGRName";
            this.lblstudentGRName.Size = new System.Drawing.Size(114, 18);
            this.lblstudentGRName.TabIndex = 42;
            this.lblstudentGRName.Text = "Student Name";
            // 
            // cbstudentGRName
            // 
            this.cbstudentGRName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstudentGRName.FormattingEnabled = true;
            this.cbstudentGRName.Location = new System.Drawing.Point(353, 109);
            this.cbstudentGRName.Margin = new System.Windows.Forms.Padding(4);
            this.cbstudentGRName.Name = "cbstudentGRName";
            this.cbstudentGRName.Size = new System.Drawing.Size(329, 21);
            this.cbstudentGRName.TabIndex = 43;
            // 
            // lblstudentGRLecturer
            // 
            this.lblstudentGRLecturer.AutoSize = true;
            this.lblstudentGRLecturer.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentGRLecturer.Location = new System.Drawing.Point(4, 140);
            this.lblstudentGRLecturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentGRLecturer.Name = "lblstudentGRLecturer";
            this.lblstudentGRLecturer.Size = new System.Drawing.Size(68, 18);
            this.lblstudentGRLecturer.TabIndex = 44;
            this.lblstudentGRLecturer.Text = "Lecturer";
            // 
            // cbstudentGRLecturer
            // 
            this.cbstudentGRLecturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstudentGRLecturer.FormattingEnabled = true;
            this.cbstudentGRLecturer.Location = new System.Drawing.Point(353, 144);
            this.cbstudentGRLecturer.Margin = new System.Windows.Forms.Padding(4);
            this.cbstudentGRLecturer.Name = "cbstudentGRLecturer";
            this.cbstudentGRLecturer.Size = new System.Drawing.Size(329, 21);
            this.cbstudentGRLecturer.TabIndex = 45;
            // 
            // lblstudentGRComments
            // 
            this.lblstudentGRComments.AutoSize = true;
            this.lblstudentGRComments.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentGRComments.Location = new System.Drawing.Point(4, 175);
            this.lblstudentGRComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentGRComments.Name = "lblstudentGRComments";
            this.lblstudentGRComments.Size = new System.Drawing.Size(86, 18);
            this.lblstudentGRComments.TabIndex = 46;
            this.lblstudentGRComments.Text = "Comments";
            // 
            // txtstudentGRComments
            // 
            this.txtstudentGRComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentGRComments.Location = new System.Drawing.Point(353, 179);
            this.txtstudentGRComments.Margin = new System.Windows.Forms.Padding(4);
            this.txtstudentGRComments.Multiline = true;
            this.txtstudentGRComments.Name = "txtstudentGRComments";
            this.txtstudentGRComments.Size = new System.Drawing.Size(329, 27);
            this.txtstudentGRComments.TabIndex = 47;
            // 
            // txtstudentGRNoOfGrades
            // 
            this.txtstudentGRNoOfGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentGRNoOfGrades.Location = new System.Drawing.Point(353, 214);
            this.txtstudentGRNoOfGrades.Margin = new System.Windows.Forms.Padding(4);
            this.txtstudentGRNoOfGrades.Name = "txtstudentGRNoOfGrades";
            this.txtstudentGRNoOfGrades.Size = new System.Drawing.Size(329, 23);
            this.txtstudentGRNoOfGrades.TabIndex = 51;
            // 
            // lblNoOfGrades
            // 
            this.lblNoOfGrades.AutoSize = true;
            this.lblNoOfGrades.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfGrades.Location = new System.Drawing.Point(4, 210);
            this.lblNoOfGrades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoOfGrades.Name = "lblNoOfGrades";
            this.lblNoOfGrades.Size = new System.Drawing.Size(104, 18);
            this.lblNoOfGrades.TabIndex = 50;
            this.lblNoOfGrades.Text = "No Of Grade";
            // 
            // btncancelGRGradesCancel
            // 
            this.btncancelGRGradesCancel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelGRGradesCancel.Location = new System.Drawing.Point(450, 401);
            this.btncancelGRGradesCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancelGRGradesCancel.Name = "btncancelGRGradesCancel";
            this.btncancelGRGradesCancel.Size = new System.Drawing.Size(205, 47);
            this.btncancelGRGradesCancel.TabIndex = 23;
            this.btncancelGRGradesCancel.Text = "Cancel  Changes";
            this.btncancelGRGradesCancel.UseVisualStyleBackColor = true;
            this.btncancelGRGradesCancel.Click += new System.EventHandler(this.btncancelGRGradesCancel_Click);
            // 
            // btnsaveGRGradesChanges
            // 
            this.btnsaveGRGradesChanges.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveGRGradesChanges.Location = new System.Drawing.Point(114, 401);
            this.btnsaveGRGradesChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btnsaveGRGradesChanges.Name = "btnsaveGRGradesChanges";
            this.btnsaveGRGradesChanges.Size = new System.Drawing.Size(205, 47);
            this.btnsaveGRGradesChanges.TabIndex = 22;
            this.btnsaveGRGradesChanges.Text = "Save Changes";
            this.btnsaveGRGradesChanges.UseVisualStyleBackColor = true;
            this.btnsaveGRGradesChanges.Click += new System.EventHandler(this.btnsaveGRGradesChanges_Click);
            // 
            // lblSRId
            // 
            this.lblSRId.AutoSize = true;
            this.lblSRId.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSRId.Location = new System.Drawing.Point(492, 9);
            this.lblSRId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSRId.Name = "lblSRId";
            this.lblSRId.Size = new System.Drawing.Size(0, 55);
            this.lblSRId.TabIndex = 26;
            this.lblSRId.Visible = false;
            // 
            // pbGrades
            // 
            this.pbGrades.Image = ((System.Drawing.Image)(resources.GetObject("pbGrades.Image")));
            this.pbGrades.Location = new System.Drawing.Point(749, 355);
            this.pbGrades.Name = "pbGrades";
            this.pbGrades.Size = new System.Drawing.Size(30, 30);
            this.pbGrades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbGrades.TabIndex = 46;
            this.pbGrades.TabStop = false;
            this.pbGrades.MouseHover += new System.EventHandler(this.pbGrades_MouseHover);
            // 
            // pbHelpNoOfGrades
            // 
            this.pbHelpNoOfGrades.Image = ((System.Drawing.Image)(resources.GetObject("pbHelpNoOfGrades.Image")));
            this.pbHelpNoOfGrades.Location = new System.Drawing.Point(749, 298);
            this.pbHelpNoOfGrades.Name = "pbHelpNoOfGrades";
            this.pbHelpNoOfGrades.Size = new System.Drawing.Size(30, 30);
            this.pbHelpNoOfGrades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbHelpNoOfGrades.TabIndex = 45;
            this.pbHelpNoOfGrades.TabStop = false;
            this.pbHelpNoOfGrades.MouseHover += new System.EventHandler(this.pbHelpNoOfGrades_MouseHover);
            // 
            // AddEditGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.pbGrades);
            this.Controls.Add(this.pbHelpNoOfGrades);
            this.Controls.Add(this.lblSRId);
            this.Controls.Add(this.lblstudentGRTitle);
            this.Controls.Add(this.tlStudentGradesPanel);
            this.Controls.Add(this.btncancelGRGradesCancel);
            this.Controls.Add(this.btnsaveGRGradesChanges);
            this.Name = "AddEditGrades";
            this.Text = "AddEditGrades";
            this.Load += new System.EventHandler(this.AddEditGrades_Load);
            this.tlStudentGradesPanel.ResumeLayout(false);
            this.tlStudentGradesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelpNoOfGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstudentGRTitle;
        private System.Windows.Forms.Label lblstudentGRCourseId;
        private System.Windows.Forms.TableLayoutPanel tlStudentGradesPanel;
        private System.Windows.Forms.Button btncancelGRGradesCancel;
        private System.Windows.Forms.Button btnsaveGRGradesChanges;
        private System.Windows.Forms.ComboBox cbstudentGRCourseId;
        private System.Windows.Forms.Label lblstudentGRCourseName;
        private System.Windows.Forms.ComboBox cbstudentGRCourseName;
        private System.Windows.Forms.Label lblstudentGRId;
        private System.Windows.Forms.ComboBox cbstudentGRIdNo;
        private System.Windows.Forms.Label lblstudentGRName;
        private System.Windows.Forms.ComboBox cbstudentGRName;
        private System.Windows.Forms.Label lblstudentGRLecturer;
        private System.Windows.Forms.ComboBox cbstudentGRLecturer;
        private System.Windows.Forms.Label lblstudentGRComments;
        private System.Windows.Forms.TextBox txtstudentGRComments;
        private System.Windows.Forms.Label lblstudentGRGrades;
        private System.Windows.Forms.TextBox txtstudentGRGrades;
        private System.Windows.Forms.Label lblSRId;
        private System.Windows.Forms.Label lblNoOfGrades;
        private System.Windows.Forms.TextBox txtstudentGRNoOfGrades;
        private System.Windows.Forms.PictureBox pbGrades;
        private System.Windows.Forms.PictureBox pbHelpNoOfGrades;
        private System.Windows.Forms.ToolTip toolTipNoOfGrades;
        private System.Windows.Forms.ToolTip toolTipGrades;
    }
}