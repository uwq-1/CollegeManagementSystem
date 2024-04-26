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

        private LoginRecord _loginRecord;


        private LoginWindow _login;
        public string _roleName;
        
        public UserRole _role;

        //public UserRole userRole;

        
        private readonly KUniversityDbModel kCollege_DbEntities;



        public MainWindow()
        {
            InitializeComponent();
            kCollege_DbEntities = new KUniversityDbModel();
            //lblmainKiwa.BackColor = Color.White;    
            lblmainKiwa.BackColor = System.Drawing.Color.Transparent;
            lblmainUniversity.BackColor = System.Drawing.Color.Transparent;
        }

        public MainWindow(LoginWindow login, UserRole role, LoginRecord loginRecord)
        {
            InitializeComponent();
            _login = login;
            _role = role;
            _loginRecord = loginRecord;
            _roleName = role.LoginRecord.UserRoles.FirstOrDefault().Role.shortname;
            kCollege_DbEntities = new KUniversityDbModel();

        }

        

        private void studentsRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("StudentWindow"))
            {
                var studentsWindows = new StudentWindow();
                studentsWindows.MdiParent = this;
                studentsWindows.Show();
            }

            /*
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "StudentWindow");
            if (!isOpen)
            {
                var studentsWindows = new StudentWindow();
                studentsWindows.MdiParent = this;
                studentsWindows.Show();
            }
            */

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
                var role = _role.LoginRecord.UserRoles.FirstOrDefault();

                var manageCourseRecords = new ManageCourseRecords(role);
                manageCourseRecords.MdiParent = this;
                manageCourseRecords.Show();
            }
        }


        private void viewProgrammesListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("ManageProgrammes"))
            {
                var role = _role.LoginRecord.UserRoles.FirstOrDefault();

                var manageProgrammes = new ManageProgrammes(role);
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
                var role = _role.LoginRecord.UserRoles.FirstOrDefault();
                

                var studentDetails = new ManageGradesRecords(role);
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

            // Getting user password
            var user_Password = _login.txtloginPassword.Text;
            

            // Get hash password
            var genericPassword = user_Password;
            var hashed_password = Utils.DefaultHashedPassword(genericPassword);

            var txtusername = _login.txtloginUsername.Text.Trim();

            var user = kCollege_DbEntities
                    .LoginRecords
                    .FirstOrDefault(q =>

                        q.username == txtusername
                        &&
                        q.password == hashed_password
                        &&
                        q.isActive == true

                    );


            var userpassword = _role.LoginRecord.password;

            if (userpassword == hashed_password)
            {

                if ((bool)user.isDefaultPassword)
                {
                    var resetPassword = new ResetPassword(_loginRecord);
                    resetPassword.ShowDialog();

                }


            }
            user.isDefaultPassword = false;
            kCollege_DbEntities.SaveChanges();

            var username = _role.LoginRecord.username;
            
            tsslloginStatus.Text = $"Login currently as ID / Name : {username}";

            if (_roleName != "admin")
            {
                manageUsersToolStripMenuItem.Visible = false;
                studentsGradesToolStripMenuItem.Visible = false;
                addCourseToolStripMenuItem.Visible = false;
            }

            if (_roleName == "view" || _roleName == "student")
            {
                teacherSystemToolStripMenuItem.Visible = false;
                viewStudentsProfileToolStripMenuItem.Visible = false;
                teachersRegisterToolStripMenuItem.Visible = false;
            }

            if (_roleName == "view")
            {
                gradesToolStripMenuItem.Visible = false;

            }


            if (_roleName == "teacher")
            {
                admissionsToolStripMenuItem.Visible = false;
                teacherSystemToolStripMenuItem.Visible = false;
                viewStudentsProfileToolStripMenuItem.Visible = false;
            }


        }
    }
}

