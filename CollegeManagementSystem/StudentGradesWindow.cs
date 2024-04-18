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
    public partial class StudentGradesWindow : Form
    {
        private readonly KUniversityDbModel kCollege_DbEntities;

        public StudentGradesWindow()
        {
            InitializeComponent();
            kCollege_DbEntities = new KUniversityDbModel();
        }


        public void studentConnectionDb()
        {

            string courseGId = cbstudentGCourseId.Text;
            string courseGName = cbstudentGCourseName.Text;
            string courseGStudentName = cbstudentGName.Text;
            string courseGStudentId = cbstudentGIdNo.Text;
            string courseGLecturer = cbstudentGLecturer.Text;
            string courseGDescription = txtstudentGComments.Text;
            int courseGGrades = Convert.ToInt32(txtstudentGGrades.Text);


            var studentGradesRecordsDb = new StudentGradesRegistrationRecord();
            studentGradesRecordsDb.Coursename = courseGName;
            studentGradesRecordsDb.Cid = courseGId;
            studentGradesRecordsDb.Lecturername = courseGLecturer;
            studentGradesRecordsDb.Sname = courseGStudentName;
            studentGradesRecordsDb.Sid = courseGStudentId;
            studentGradesRecordsDb.Scomments = courseGDescription;
            studentGradesRecordsDb.Sgrade = courseGGrades;

            //studentGradesRecordsDb.SCourseRecordsid = (int)cbstudentGCourseId.SelectedValue;
            //studentGradesRecordsDb.SCourseRecordsid = (int)cbstudentGCourseName.SelectedValue;
            
            studentGradesRecordsDb.SGradesid = (int)cbstudentGName.SelectedValue;


            kCollege_DbEntities.StudentGradesRegistrationRecords.Add(studentGradesRecordsDb);
            kCollege_DbEntities.SaveChanges();
        }

        public void studentGradeSubmitButton()
        {
            try
            {
                string courseGId = cbstudentGCourseId.Text;
                string courseGName = cbstudentGCourseName.Text;
                string courseGStudentName = cbstudentGName.Text;
                string courseGStudentId = cbstudentGIdNo.Text;
                string courseGLecturer = cbstudentGLecturer.Text;
                string courseGDescription = txtstudentGComments.Text;
                int courseGGrades = Convert.ToInt32(txtstudentGGrades.Text);
                

                bool isValid = true;
                string errorMessage = "";

                if (string.IsNullOrWhiteSpace(courseGStudentName) ||
                    string.IsNullOrWhiteSpace(courseGStudentId))
                {
                    isValid = false;
                    errorMessage += "Error : Please enter missing Student name and/or StudentId.\n\r";
                    cbstudentGIdNo.Focus();
                }

                
                if (string.IsNullOrWhiteSpace(courseGName))
                {
                    isValid = false;
                    errorMessage += "Error : Please enter missing data.\n\r";

                }

                if (string.IsNullOrWhiteSpace(courseGId))
                {
                    isValid = false;
                    errorMessage += "Error : Please enter missing data.\n\r";
                    cbstudentGCourseId.Focus();
                }

                if (string.IsNullOrWhiteSpace(courseGLecturer)
                    || string.IsNullOrWhiteSpace(courseGDescription))
                {
                    isValid = false;
                    errorMessage += "Error : Please enter missing Lecturer and/or Description.\n\r";
                    cbstudentGLecturer.Focus();
                }

                if(courseGGrades >= 0 && courseGGrades <= 100)
                {
                    // true
                    isValid = false;
                    MessageBox.Show($"Your have earned. {courseGGrades}%");
                    
                }
                else
                {
                    // false
                    isValid = false;
                    MessageBox.Show("Error : Invalid value entered.\n\r");
                    // errorMessage += "Error : Invalid value entered.\n\r";
                }

                if (isValid)
                {
                    // Display output with Messagebox
                    MessageBox.Show($"Thanks for your submission.\n" +
                        $"Course Name : {courseGName} Course ID: {courseGId} \n\r" +
                        $"Lecturer : {courseGLecturer}\n\r" +
                        $"Student Name : {courseGStudentName}  Student Id: {courseGStudentId}\n\r" +
                        $"Description : {courseGDescription}\n\r" +
                        $"Grade : {courseGGrades}");

                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }


        private void btnstudentGradesSubmit_Click(object sender, EventArgs e)
        {
            studentGradeSubmitButton();
        }

        private void btnstudentGradesClear_Click(object sender, EventArgs e)
        {

        }


        private void StudentGradesWindow_Load(object sender, EventArgs e)
        {
            // Select * from TypesOfCourses
            
            var sgradesrecords = kCollege_DbEntities.TypesOfCourses.ToList();
            cbstudentGCourseId.DisplayMember = "Cid";
            cbstudentGCourseId.ValueMember = "id";
            cbstudentGCourseName.DisplayMember = "Name";
            cbstudentGCourseName.ValueMember = "id";
            cbstudentGCourseName.DataSource = sgradesrecords;
            cbstudentGCourseId.DataSource = sgradesrecords;


            var sgradesrecordsname = kCollege_DbEntities.StudentRegistrationRecords
                .ToList();
            
            cbstudentGIdNo.DisplayMember = "Sid";
            cbstudentGIdNo.ValueMember = "id";
            cbstudentGIdNo.DataSource = sgradesrecordsname;


            cbstudentGName.DisplayMember = "Name";
            cbstudentGName.ValueMember = "id";
            cbstudentGName.DataSource = sgradesrecordsname;

            var sgradesteachersname = kCollege_DbEntities
                .TeacherRegistrationRecords
                .ToList();

            cbstudentGLecturer.DisplayMember = "Name";
            cbstudentGLecturer.ValueMember = "id";
            cbstudentGLecturer.DataSource = sgradesteachersname;


        }

    }
}
