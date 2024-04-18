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
        public MainWindow()
        {
            InitializeComponent();
            //lblmainKiwa.BackColor = Color.White;    
            lblmainKiwa.BackColor = System.Drawing.Color.Transparent;
            lblmainUniversity.BackColor = System.Drawing.Color.Transparent;
        }

        private void studentsRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studentsWindows = new StudentWindow();
            studentsWindows.MdiParent = this;
            studentsWindows.Show();
        }

        private void teachersRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherWindow teacherWindows = new TeacherWindow();
            teacherWindows.MdiParent = this;
            teacherWindows.Show();
        }

        private void viewCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studentCourseWindows = new StudentCoursesWindow();
            studentCourseWindows.MdiParent = this;
            studentCourseWindows.Show();
        }

        private void studentsGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studentGradeWindows = new StudentGradesWindow();
            studentGradeWindows.MdiParent = this;
            studentGradeWindows.Show();
        }

        private void viewProgrammesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageProgrammes = new ManageProgrammes();
            manageProgrammes.MdiParent = this;
            manageProgrammes.Show();
        }

        private void studentsPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studentDetails = new ManageStudentsRecords();
            studentDetails.MdiParent = this;
            studentDetails.Show();
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
