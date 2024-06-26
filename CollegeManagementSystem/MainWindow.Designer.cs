﻿namespace CollegeManagementSystem
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
            this.studentCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProgrammesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTeacherRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblmainKiwa = new System.Windows.Forms.Label();
            this.lblmainUniversity = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslloginStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuMainStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMainStrip
            // 
            this.menuMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admissionsToolStripMenuItem,
            this.gradesToolStripMenuItem,
            this.studentCourseToolStripMenuItem,
            this.studentDetailsToolStripMenuItem,
            this.teacherSystemToolStripMenuItem,
            this.manageUsersToolStripMenuItem,
            this.exitSystemToolStripMenuItem});
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
            this.viewStudentsGradesToolStripMenuItem.Click += new System.EventHandler(this.viewStudentsGradesToolStripMenuItem_Click);
            // 
            // studentCourseToolStripMenuItem
            // 
            this.studentCourseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.viewAllCourseToolStripMenuItem});
            this.studentCourseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentCourseToolStripMenuItem.Image")));
            this.studentCourseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentCourseToolStripMenuItem.Name = "studentCourseToolStripMenuItem";
            this.studentCourseToolStripMenuItem.Size = new System.Drawing.Size(72, 83);
            this.studentCourseToolStripMenuItem.Text = "Course ";
            this.studentCourseToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.addCourseToolStripMenuItem.Text = "Add Course ";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.viewCourseToolStripMenuItem_Click);
            // 
            // viewAllCourseToolStripMenuItem
            // 
            this.viewAllCourseToolStripMenuItem.Name = "viewAllCourseToolStripMenuItem";
            this.viewAllCourseToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.viewAllCourseToolStripMenuItem.Text = "View  Course";
            this.viewAllCourseToolStripMenuItem.Click += new System.EventHandler(this.viewAllCourseToolStripMenuItem_Click);
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProgrammesListToolStripMenuItem,
            this.viewStudentsProfileToolStripMenuItem});
            this.studentDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentDetailsToolStripMenuItem.Image")));
            this.studentDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(114, 83);
            this.studentDetailsToolStripMenuItem.Text = "Student Details";
            this.studentDetailsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // viewProgrammesListToolStripMenuItem
            // 
            this.viewProgrammesListToolStripMenuItem.Name = "viewProgrammesListToolStripMenuItem";
            this.viewProgrammesListToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.viewProgrammesListToolStripMenuItem.Text = "View Programmes List";
            this.viewProgrammesListToolStripMenuItem.Click += new System.EventHandler(this.viewProgrammesListToolStripMenuItem_Click);
            // 
            // viewStudentsProfileToolStripMenuItem
            // 
            this.viewStudentsProfileToolStripMenuItem.Name = "viewStudentsProfileToolStripMenuItem";
            this.viewStudentsProfileToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.viewStudentsProfileToolStripMenuItem.Text = "View Students Profile";
            this.viewStudentsProfileToolStripMenuItem.Click += new System.EventHandler(this.viewStudentsProfileToolStripMenuItem_Click);
            // 
            // teacherSystemToolStripMenuItem
            // 
            this.teacherSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTeacherRToolStripMenuItem});
            this.teacherSystemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("teacherSystemToolStripMenuItem.Image")));
            this.teacherSystemToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.teacherSystemToolStripMenuItem.Name = "teacherSystemToolStripMenuItem";
            this.teacherSystemToolStripMenuItem.Size = new System.Drawing.Size(72, 83);
            this.teacherSystemToolStripMenuItem.Text = "Teacher";
            this.teacherSystemToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // viewTeacherRToolStripMenuItem
            // 
            this.viewTeacherRToolStripMenuItem.Name = "viewTeacherRToolStripMenuItem";
            this.viewTeacherRToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.viewTeacherRToolStripMenuItem.Text = "View Teacher";
            this.viewTeacherRToolStripMenuItem.Click += new System.EventHandler(this.viewTeacherRToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userSettingsToolStripMenuItem});
            this.manageUsersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageUsersToolStripMenuItem.Image")));
            this.manageUsersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(109, 83);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // userSettingsToolStripMenuItem
            // 
            this.userSettingsToolStripMenuItem.Name = "userSettingsToolStripMenuItem";
            this.userSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.userSettingsToolStripMenuItem.Text = "User Settings";
            this.userSettingsToolStripMenuItem.Click += new System.EventHandler(this.userSettingsToolStripMenuItem_Click);
            // 
            // exitSystemToolStripMenuItem
            // 
            this.exitSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.exitSystemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitSystemToolStripMenuItem.Image")));
            this.exitSystemToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitSystemToolStripMenuItem.Name = "exitSystemToolStripMenuItem";
            this.exitSystemToolStripMenuItem.Size = new System.Drawing.Size(90, 83);
            this.exitSystemToolStripMenuItem.Text = "Exit System";
            this.exitSystemToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslloginStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 481);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(872, 24);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslloginStatus
            // 
            this.tsslloginStatus.Name = "tsslloginStatus";
            this.tsslloginStatus.Size = new System.Drawing.Size(139, 19);
            this.tsslloginStatus.Text = "toolStripStatusLabel1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(872, 505);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblmainUniversity);
            this.Controls.Add(this.lblmainKiwa);
            this.Controls.Add(this.menuMainStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMainStrip;
            this.Name = "MainWindow";
            this.Text = "Kiwa University Centre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuMainStrip.ResumeLayout(false);
            this.menuMainStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem studentCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTeacherRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsGradesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProgrammesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userSettingsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslloginStatus;
    }
}