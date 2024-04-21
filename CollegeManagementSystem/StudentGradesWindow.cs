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

        private string studentBlank = "";

        public StudentGradesWindow()
        {
            InitializeComponent();
            kCollege_DbEntities = new KUniversityDbModel();
        }

        public void StudentGradeClearButton() 
        {
            try
            {
                string courseGDescription = txtstudentGComments.Text;
                int courseGGrades = Convert.ToInt32(txtstudentGGrades.Text);
                //string errorMessage = "";
                string s = "";

                if (courseGDescription != string.Empty)
                {
                    txtstudentGComments.ResetText();
                    txtstudentGComments.AppendText(studentBlank);
                }

                // Clear Integer textbox
                // Reference :
                // https://stackoverflow.com/questions/16734172/checking-a-textbox-for-an-empty-string-an-integer-or-a-string
                if (!int.TryParse(s,out courseGGrades))
                {
                    txtstudentGGrades.ResetText();
                    txtstudentGGrades.AppendText(studentBlank);
                    txtstudentGGrades.Clear();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        public void StudentGradeSubmitButton()
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
                    MessageBox.Show($"Your have earned. {courseGGrades}%");
                    
                }
                /*else
                {
                    // false
                    MessageBox.Show("Error : Invalid value entered.\n\r");
                    // errorMessage += "Error : Invalid value entered.\n\r";
                }*/

                

                if (isValid == true)
                {


                    var studentGradesRecordsDb = new StudentGradesRegistrationRecord();
                    studentGradesRecordsDb.Coursename = courseGName;
                    studentGradesRecordsDb.Cid = courseGId;
                    studentGradesRecordsDb.Lecturername = courseGLecturer;
                    studentGradesRecordsDb.Sname = courseGStudentName;
                    studentGradesRecordsDb.Sid = courseGStudentId;
                    studentGradesRecordsDb.Scomments = courseGDescription;
                    studentGradesRecordsDb.Sgrade = courseGGrades;

                    

                    //studentGradesRecordsDb.SGradesid = (int)cbstudentGCourseName.SelectedValue;

                    kCollege_DbEntities.StudentGradesRegistrationRecords.Add(studentGradesRecordsDb);
                    kCollege_DbEntities.SaveChanges();


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
                
            }

        }


        private void btnstudentGradesSubmit_Click(object sender, EventArgs e)
        {
            
            StudentGradeSubmitButton();
            
        }

        private void btnstudentGradesClear_Click(object sender, EventArgs e)
        {
            StudentGradeClearButton();
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
