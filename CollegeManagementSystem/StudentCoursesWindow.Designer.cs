namespace CollegeManagementSystem
{
    partial class StudentCoursesWindow
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
            this.lblstudentCourses = new System.Windows.Forms.Label();
            this.lblstudentCourseName = new System.Windows.Forms.Label();
            this.txtstudentCourseName = new System.Windows.Forms.TextBox();
            this.lblstudentLecturer = new System.Windows.Forms.Label();
            this.txtstudentLecturer = new System.Windows.Forms.TextBox();
            this.lblstudentDescription = new System.Windows.Forms.Label();
            this.txtstudentDescription = new System.Windows.Forms.TextBox();
            this.lblstudentSemester = new System.Windows.Forms.Label();
            this.cbstudentSemester = new System.Windows.Forms.ComboBox();
            this.lblstudentCourseId = new System.Windows.Forms.Label();
            this.txtstudentCourseId = new System.Windows.Forms.TextBox();
            this.btnstudentCourseSubmit = new System.Windows.Forms.Button();
            this.btnstudentCourseClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblstudentCourses
            // 
            this.lblstudentCourses.AutoSize = true;
            this.lblstudentCourses.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentCourses.Location = new System.Drawing.Point(99, 19);
            this.lblstudentCourses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentCourses.Name = "lblstudentCourses";
            this.lblstudentCourses.Size = new System.Drawing.Size(341, 55);
            this.lblstudentCourses.TabIndex = 2;
            this.lblstudentCourses.Text = "Student Courses";
            // 
            // lblstudentCourseName
            // 
            this.lblstudentCourseName.AutoSize = true;
            this.lblstudentCourseName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentCourseName.Location = new System.Drawing.Point(22, 135);
            this.lblstudentCourseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentCourseName.Name = "lblstudentCourseName";
            this.lblstudentCourseName.Size = new System.Drawing.Size(109, 18);
            this.lblstudentCourseName.TabIndex = 4;
            this.lblstudentCourseName.Text = "Course Name";
            // 
            // txtstudentCourseName
            // 
            this.txtstudentCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentCourseName.Location = new System.Drawing.Point(151, 134);
            this.txtstudentCourseName.Margin = new System.Windows.Forms.Padding(4);
            this.txtstudentCourseName.Name = "txtstudentCourseName";
            this.txtstudentCourseName.Size = new System.Drawing.Size(329, 23);
            this.txtstudentCourseName.TabIndex = 5;
            // 
            // lblstudentLecturer
            // 
            this.lblstudentLecturer.AutoSize = true;
            this.lblstudentLecturer.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentLecturer.Location = new System.Drawing.Point(22, 197);
            this.lblstudentLecturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentLecturer.Name = "lblstudentLecturer";
            this.lblstudentLecturer.Size = new System.Drawing.Size(68, 18);
            this.lblstudentLecturer.TabIndex = 6;
            this.lblstudentLecturer.Text = "Lecturer";
            // 
            // txtstudentLecturer
            // 
            this.txtstudentLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentLecturer.Location = new System.Drawing.Point(151, 196);
            this.txtstudentLecturer.Margin = new System.Windows.Forms.Padding(4);
            this.txtstudentLecturer.Name = "txtstudentLecturer";
            this.txtstudentLecturer.Size = new System.Drawing.Size(329, 23);
            this.txtstudentLecturer.TabIndex = 7;
            // 
            // lblstudentDescription
            // 
            this.lblstudentDescription.AutoSize = true;
            this.lblstudentDescription.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentDescription.Location = new System.Drawing.Point(22, 260);
            this.lblstudentDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentDescription.Name = "lblstudentDescription";
            this.lblstudentDescription.Size = new System.Drawing.Size(95, 18);
            this.lblstudentDescription.TabIndex = 8;
            this.lblstudentDescription.Text = "Description";
            // 
            // txtstudentDescription
            // 
            this.txtstudentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentDescription.Location = new System.Drawing.Point(151, 255);
            this.txtstudentDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtstudentDescription.Multiline = true;
            this.txtstudentDescription.Name = "txtstudentDescription";
            this.txtstudentDescription.Size = new System.Drawing.Size(329, 63);
            this.txtstudentDescription.TabIndex = 9;
            // 
            // lblstudentSemester
            // 
            this.lblstudentSemester.AutoSize = true;
            this.lblstudentSemester.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentSemester.Location = new System.Drawing.Point(22, 351);
            this.lblstudentSemester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentSemester.Name = "lblstudentSemester";
            this.lblstudentSemester.Size = new System.Drawing.Size(75, 18);
            this.lblstudentSemester.TabIndex = 10;
            this.lblstudentSemester.Text = "Semester";
            // 
            // cbstudentSemester
            // 
            this.cbstudentSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstudentSemester.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbstudentSemester.FormattingEnabled = true;
            this.cbstudentSemester.Location = new System.Drawing.Point(151, 348);
            this.cbstudentSemester.Margin = new System.Windows.Forms.Padding(4);
            this.cbstudentSemester.Name = "cbstudentSemester";
            this.cbstudentSemester.Size = new System.Drawing.Size(329, 23);
            this.cbstudentSemester.TabIndex = 18;
            // 
            // lblstudentCourseId
            // 
            this.lblstudentCourseId.AutoSize = true;
            this.lblstudentCourseId.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentCourseId.Location = new System.Drawing.Point(22, 101);
            this.lblstudentCourseId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentCourseId.Name = "lblstudentCourseId";
            this.lblstudentCourseId.Size = new System.Drawing.Size(87, 18);
            this.lblstudentCourseId.TabIndex = 19;
            this.lblstudentCourseId.Text = "Course ID ";
            // 
            // txtstudentCourseId
            // 
            this.txtstudentCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentCourseId.Location = new System.Drawing.Point(151, 100);
            this.txtstudentCourseId.Margin = new System.Windows.Forms.Padding(4);
            this.txtstudentCourseId.Name = "txtstudentCourseId";
            this.txtstudentCourseId.Size = new System.Drawing.Size(329, 23);
            this.txtstudentCourseId.TabIndex = 20;
            // 
            // btnstudentCourseSubmit
            // 
            this.btnstudentCourseSubmit.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudentCourseSubmit.Location = new System.Drawing.Point(347, 400);
            this.btnstudentCourseSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnstudentCourseSubmit.Name = "btnstudentCourseSubmit";
            this.btnstudentCourseSubmit.Size = new System.Drawing.Size(133, 47);
            this.btnstudentCourseSubmit.TabIndex = 21;
            this.btnstudentCourseSubmit.Text = "Submit";
            this.btnstudentCourseSubmit.UseVisualStyleBackColor = true;
            this.btnstudentCourseSubmit.Click += new System.EventHandler(this.btnstudentCourseSubmit_Click);
            // 
            // btnstudentCourseClear
            // 
            this.btnstudentCourseClear.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudentCourseClear.Location = new System.Drawing.Point(133, 400);
            this.btnstudentCourseClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnstudentCourseClear.Name = "btnstudentCourseClear";
            this.btnstudentCourseClear.Size = new System.Drawing.Size(133, 47);
            this.btnstudentCourseClear.TabIndex = 24;
            this.btnstudentCourseClear.Text = "Clear";
            this.btnstudentCourseClear.UseVisualStyleBackColor = true;
            this.btnstudentCourseClear.Click += new System.EventHandler(this.btnstudentCourseClear_Click);
            // 
            // StudentCoursesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 480);
            this.Controls.Add(this.btnstudentCourseClear);
            this.Controls.Add(this.btnstudentCourseSubmit);
            this.Controls.Add(this.txtstudentCourseId);
            this.Controls.Add(this.lblstudentCourseId);
            this.Controls.Add(this.cbstudentSemester);
            this.Controls.Add(this.lblstudentSemester);
            this.Controls.Add(this.txtstudentDescription);
            this.Controls.Add(this.lblstudentDescription);
            this.Controls.Add(this.txtstudentLecturer);
            this.Controls.Add(this.lblstudentLecturer);
            this.Controls.Add(this.txtstudentCourseName);
            this.Controls.Add(this.lblstudentCourseName);
            this.Controls.Add(this.lblstudentCourses);
            this.Name = "StudentCoursesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Courses";
            this.Load += new System.EventHandler(this.StudentCoursesWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstudentCourses;
        private System.Windows.Forms.Label lblstudentCourseName;
        private System.Windows.Forms.TextBox txtstudentCourseName;
        private System.Windows.Forms.Label lblstudentLecturer;
        private System.Windows.Forms.TextBox txtstudentLecturer;
        private System.Windows.Forms.Label lblstudentDescription;
        private System.Windows.Forms.TextBox txtstudentDescription;
        private System.Windows.Forms.Label lblstudentSemester;
        private System.Windows.Forms.ComboBox cbstudentSemester;
        private System.Windows.Forms.Label lblstudentCourseId;
        private System.Windows.Forms.TextBox txtstudentCourseId;
        private System.Windows.Forms.Button btnstudentCourseSubmit;
        private System.Windows.Forms.Button btnstudentCourseClear;
    }
}