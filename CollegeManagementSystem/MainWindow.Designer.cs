namespace CollegeManagementSystem
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuMainStrip = new System.Windows.Forms.MenuStrip();
            this.admissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsGradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsGradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProgrammesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSystemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTeacherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSystemToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblmainKiwa = new System.Windows.Forms.Label();
            this.lblmainUniversity = new System.Windows.Forms.Label();
            this.menuMainStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMainStrip
            // 
            this.menuMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admissionsToolStripMenuItem,
            this.gradesToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.exitSystemToolStripMenuItem,
            this.exitSystemToolStripMenuItem1,
            this.exitSystemToolStripMenuItem2});
            this.menuMainStrip.Location = new System.Drawing.Point(0, 0);
            this.menuMainStrip.Name = "menuMainStrip";
            this.menuMainStrip.Size = new System.Drawing.Size(872, 87);
            this.menuMainStrip.TabIndex = 0;
            this.menuMainStrip.Text = "menuStrip1";
            // 
            // admissionsToolStripMenuItem
            // 
            this.admissionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsRegisterToolStripMenuItem,
            this.teachersRegisterToolStripMenuItem});
            this.admissionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("admissionsToolStripMenuItem.Image")));
            this.admissionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.admissionsToolStripMenuItem.Name = "admissionsToolStripMenuItem";
            this.admissionsToolStripMenuItem.Size = new System.Drawing.Size(90, 83);
            this.admissionsToolStripMenuItem.Text = "Admissions";
            this.admissionsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // studentsRegisterToolStripMenuItem
            // 
            this.studentsRegisterToolStripMenuItem.Name = "studentsRegisterToolStripMenuItem";
            this.studentsRegisterToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.studentsRegisterToolStripMenuItem.Text = "Student\'s Register";
            this.studentsRegisterToolStripMenuItem.Click += new System.EventHandler(this.studentsRegisterToolStripMenuItem_Click);
            // 
            // teachersRegisterToolStripMenuItem
            // 
            this.teachersRegisterToolStripMenuItem.Name = "teachersRegisterToolStripMenuItem";
            this.teachersRegisterToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.teachersRegisterToolStripMenuItem.Text = "Teacher\'s  Register";
            this.teachersRegisterToolStripMenuItem.Click += new System.EventHandler(this.teachersRegisterToolStripMenuItem_Click);
            // 
            // gradesToolStripMenuItem
            // 
            this.gradesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsGradesToolStripMenuItem,
            this.viewStudentsGradesToolStripMenuItem});
            this.gradesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gradesToolStripMenuItem.Image")));
            this.gradesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gradesToolStripMenuItem.Name = "gradesToolStripMenuItem";
            this.gradesToolStripMenuItem.Size = new System.Drawing.Size(72, 83);
            this.gradesToolStripMenuItem.Text = "Grades";
            this.gradesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // studentsGradesToolStripMenuItem
            // 
            this.studentsGradesToolStripMenuItem.Name = "studentsGradesToolStripMenuItem";
            this.studentsGradesToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.studentsGradesToolStripMenuItem.Text = "Add Student\'s Grades";
            this.studentsGradesToolStripMenuItem.Click += new System.EventHandler(this.studentsGradesToolStripMenuItem_Click);
            // 
            // viewStudentsGradesToolStripMenuItem
            // 
            this.viewStudentsGradesToolStripMenuItem.Name = "viewStudentsGradesToolStripMenuItem";
            this.viewStudentsGradesToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.viewStudentsGradesToolStripMenuItem.Text = "View Student\'s Grades";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCourseToolStripMenuItem,
            this.viewAllCourseToolStripMenuItem});
            this.studentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentToolStripMenuItem.Image")));
            this.studentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(72, 83);
            this.studentToolStripMenuItem.Text = "Course ";
            this.studentToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // viewCourseToolStripMenuItem
            // 
            this.viewCourseToolStripMenuItem.Name = "viewCourseToolStripMenuItem";
            this.viewCourseToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.viewCourseToolStripMenuItem.Text = "Add Course ";
            this.viewCourseToolStripMenuItem.Click += new System.EventHandler(this.viewCourseToolStripMenuItem_Click);
            // 
            // viewAllCourseToolStripMenuItem
            // 
            this.viewAllCourseToolStripMenuItem.Name = "viewAllCourseToolStripMenuItem";
            this.viewAllCourseToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.viewAllCourseToolStripMenuItem.Text = "View  Course";
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsPToolStripMenuItem,
            this.viewProgrammesListToolStripMenuItem});
            this.teacherToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("teacherToolStripMenuItem.Image")));
            this.teacherToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(114, 83);
            this.teacherToolStripMenuItem.Text = "Student Details";
            this.teacherToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // studentsPToolStripMenuItem
            // 
            this.studentsPToolStripMenuItem.Name = "studentsPToolStripMenuItem";
            this.studentsPToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.studentsPToolStripMenuItem.Text = "Students Profile";
            this.studentsPToolStripMenuItem.Click += new System.EventHandler(this.studentsPToolStripMenuItem_Click);
            // 
            // viewProgrammesListToolStripMenuItem
            // 
            this.viewProgrammesListToolStripMenuItem.Name = "viewProgrammesListToolStripMenuItem";
            this.viewProgrammesListToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.viewProgrammesListToolStripMenuItem.Text = "View Programmes List";
            this.viewProgrammesListToolStripMenuItem.Click += new System.EventHandler(this.viewProgrammesListToolStripMenuItem_Click);
            // 
            // exitSystemToolStripMenuItem
            // 
            this.exitSystemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitSystemToolStripMenuItem.Image")));
            this.exitSystemToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitSystemToolStripMenuItem.Name = "exitSystemToolStripMenuItem";
            this.exitSystemToolStripMenuItem.Size = new System.Drawing.Size(122, 83);
            this.exitSystemToolStripMenuItem.Text = "Remove Student";
            this.exitSystemToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // exitSystemToolStripMenuItem1
            // 
            this.exitSystemToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTeacherToolStripMenuItem1});
            this.exitSystemToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("exitSystemToolStripMenuItem1.Image")));
            this.exitSystemToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitSystemToolStripMenuItem1.Name = "exitSystemToolStripMenuItem1";
            this.exitSystemToolStripMenuItem1.Size = new System.Drawing.Size(72, 83);
            this.exitSystemToolStripMenuItem1.Text = "Teacher";
            this.exitSystemToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // viewTeacherToolStripMenuItem1
            // 
            this.viewTeacherToolStripMenuItem1.Name = "viewTeacherToolStripMenuItem1";
            this.viewTeacherToolStripMenuItem1.Size = new System.Drawing.Size(157, 24);
            this.viewTeacherToolStripMenuItem1.Text = "View Teacher";
            // 
            // exitSystemToolStripMenuItem2
            // 
            this.exitSystemToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.exitSystemToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("exitSystemToolStripMenuItem2.Image")));
            this.exitSystemToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitSystemToolStripMenuItem2.Name = "exitSystemToolStripMenuItem2";
            this.exitSystemToolStripMenuItem2.Size = new System.Drawing.Size(90, 83);
            this.exitSystemToolStripMenuItem2.Text = "Exit System";
            this.exitSystemToolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.exitToolStripMenuItem.Text = "Exit ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblmainKiwa
            // 
            this.lblmainKiwa.AutoSize = true;
            this.lblmainKiwa.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmainKiwa.Location = new System.Drawing.Point(12, 395);
            this.lblmainKiwa.Name = "lblmainKiwa";
            this.lblmainKiwa.Size = new System.Drawing.Size(158, 63);
            this.lblmainKiwa.TabIndex = 1;
            this.lblmainKiwa.Text = "Kiwa ";
            // 
            // lblmainUniversity
            // 
            this.lblmainUniversity.AutoSize = true;
            this.lblmainUniversity.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmainUniversity.Location = new System.Drawing.Point(73, 481);
            this.lblmainUniversity.Name = "lblmainUniversity";
            this.lblmainUniversity.Size = new System.Drawing.Size(259, 63);
            this.lblmainUniversity.TabIndex = 2;
            this.lblmainUniversity.Text = "University";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(872, 505);
            this.Controls.Add(this.lblmainUniversity);
            this.Controls.Add(this.lblmainKiwa);
            this.Controls.Add(this.menuMainStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMainStrip;
            this.Name = "MainWindow";
            this.Text = "Kiwa University Centre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuMainStrip.ResumeLayout(false);
            this.menuMainStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMainStrip;
        private System.Windows.Forms.ToolStripMenuItem admissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradesToolStripMenuItem;
        private System.Windows.Forms.Label lblmainKiwa;
        private System.Windows.Forms.ToolStripMenuItem studentsRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsGradesToolStripMenuItem;
        private System.Windows.Forms.Label lblmainUniversity;
        private System.Windows.Forms.ToolStripMenuItem teachersRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitSystemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewTeacherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitSystemToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsGradesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProgrammesListToolStripMenuItem;
    }
}