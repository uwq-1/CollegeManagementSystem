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

        public MainWindow()
        {
            InitializeComponent();
            //lblmainKiwa.BackColor = Color.White;    
            lblmainKiwa.BackColor = System.Drawing.Color.Transparent;
            lblmainUniversity.BackColor = System.Drawing.Color.Transparent;
        }

        public MainWindow(LoginWindow login)
        {
            InitializeComponent();
            _login = login;
        }


        private void studentsRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "StudentWindow");
            if (!isOpen)
            {
                var studentsWindows = new StudentWindow();
                studentsWindows.MdiParent = this;
                studentsWindows.Show();
            }    
        }

        private void teachersRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "TeacherWindow");
            if (!isOpen)
            {
                TeacherWindow teacherWindows = new TeacherWindow();
                teacherWindows.MdiParent = this;
                teacherWindows.Show();
            }    
        }

        private void viewCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "StudentCoursesWindow");
            if (!isOpen)
            {
                var studentCourseWindows = new StudentCoursesWindow();
                studentCourseWindows.MdiParent = this;
                studentCourseWindows.Show();
            }
    
        }

        private void studentsGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "StudentGradesWindow");
            if (!isOpen)
            {
                var studentGradeWindows = new StudentGradesWindow();
                studentGradeWindows.MdiParent = this;
                studentGradeWindows.Show();
            }

            
        }

        private void viewProgrammesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "ManageProgrammes");
            if (!isOpen)
            {
                var manageProgrammes = new ManageProgrammes();
                manageProgrammes.MdiParent = this;
                manageProgrammes.Show();
            }

        }

        
        private void viewStudentsProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "ManageArchiveStudentRecords");
            if (!isOpen)
            {
                var manageStudentsArchive = new ManageArchiveStudentRecords();
                manageStudentsArchive.MdiParent = this;
                manageStudentsArchive.Show();
            }

        }


        private void viewStudentsGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "ManageGradesRecords");
            if (!isOpen)
            {
                var studentDetails = new ManageGradesRecords();
                studentDetails.MdiParent = this;
                studentDetails.Show();
            }

        }


        private void viewTeacherRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "ManageTeacherRecords");
            if (!isOpen)
            {
                var teacherDetails = new ManageTeacherRecords();
                teacherDetails.MdiParent = this;
                teacherDetails.Show();
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

        
    }
}
