using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeManagementSystem.Database;

namespace CollegeManagementSystem
{
    public partial class MainWindow : Form
    {

        private LoginWindow _login;
        public string _roleName;
        public UserRole _role;
        //public UserRole userRole;

        public MainWindow()
        {
            InitializeComponent();
            //lblmainKiwa.BackColor = Color.White;    
            lblmainKiwa.BackColor = System.Drawing.Color.Transparent;
            lblmainUniversity.BackColor = System.Drawing.Color.Transparent;
        }

        public MainWindow(LoginWindow login, UserRole role)
        {
            InitializeComponent();
            _login = login;
            _role = role;
            _roleName = role.LoginRecord.UserRoles.FirstOrDefault().Role.shortname;
            
        }


        private void studentsRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("StudentWindow"))
            {
                var studentsWindows = new StudentWindow();
                studentsWindows.MdiParent = this;
                studentsWindows.Show();
            }

            /*var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "StudentWindow");
            if (!isOpen)
            {
                var studentsWindows = new StudentWindow();
                studentsWindows.MdiParent = this;
                studentsWindows.Show();
            }*/
        }

        private void teachersRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("TeacherWindow"))
            {
                TeacherWindow teacherWindows = new TeacherWindow();
                teacherWindows.MdiParent = this;
                teacherWindows.Show();
            }

        }

        private void viewCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("StudentCoursesWindow"))
            {
                var studentCourseWindows = new StudentCoursesWindow();
                studentCourseWindows.MdiParent = this;
                studentCourseWindows.Show();
            }

        }

        private void studentsGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("StudentGradesWindow"))
            {
                var studentGradeWindows = new StudentGradesWindow();
                studentGradeWindows.MdiParent = this;
                studentGradeWindows.Show();
            }

        }

        private void viewAllCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("ManageCourseRecords"))
            {
                var manageCourseRecords = new ManageCourseRecords();
                manageCourseRecords.MdiParent = this;
                manageCourseRecords.Show();
            }
        }


        private void viewProgrammesListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("ManageProgrammes"))
            {
                var manageProgrammes = new ManageProgrammes();
                manageProgrammes.MdiParent = this;
                manageProgrammes.Show();
            }
            
        }


        private void viewStudentsProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageArchiveStudentRecords"))
            {
                var manageStudentsArchive = new ManageArchiveStudentRecords();
                manageStudentsArchive.MdiParent = this;
                manageStudentsArchive.Show();
            }
            

        }


        private void viewStudentsGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("ManageGradesRecords"))
            {
                var studentDetails = new ManageGradesRecords();
                studentDetails.MdiParent = this;
                studentDetails.Show();
            }

        }


        private void viewTeacherRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageTeacherRecords"))
            {
                var teacherDetails = new ManageTeacherRecords();
                teacherDetails.MdiParent = this;
                teacherDetails.Show();
            }

        }


        private void userSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("ManageUser"))
            {
                var manageUser = new ManageUser();
                manageUser.MdiParent = this;
                manageUser.Show();
            }

        }
        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var username = _role.LoginRecord.username;
            tsslloginStatus.Text = $"Login currently as ID/Name : {username}";

            if (_roleName != "admin")
            {
                manageUsersToolStripMenuItem.Visible = false;
            }


        }
    }
}

