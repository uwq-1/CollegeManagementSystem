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
    public partial class StudentCoursesWindow : Form
    {
        string studentBlank = "";

        private readonly KUniversityDbModel kCollege_DbEntities;


        public StudentCoursesWindow()
        {
            InitializeComponent();
            kCollege_DbEntities = new KUniversityDbModel();
        }

        public void studentCourseResetButton()
        {
            string courseId = txtstudentCourseId.Text;
            string courseName = txtstudentCourseName.Text;
            string courseLecturer = txtstudentLecturer.Text;
            string courseDescription = txtstudentDescription.Text;
            //string courseSemester = cbstudentSemester.Text;

            if (courseId != string.Empty)
            {
                txtstudentCourseId.ResetText();
                txtstudentCourseId.AppendText(studentBlank);
            }

            if (courseName != string.Empty)
            {
                txtstudentCourseName.ResetText();
                txtstudentCourseName.AppendText(studentBlank);
            }

            if (courseLecturer != string.Empty)
            {
                txtstudentLecturer.ResetText();
                txtstudentLecturer.AppendText(studentBlank);
            }

            if (courseDescription != string.Empty)
            {
                txtstudentDescription.ResetText();
                txtstudentLecturer.AppendText(studentBlank);
                
            }
        }

        public void studentCourseSubmitButton()
        {
            try
            {
                string courseId = txtstudentCourseId.Text.ToString();
                string courseName = txtstudentCourseName.Text;
                string courseLecturer = txtstudentLecturer.Text.ToString();
                string courseDescription = txtstudentDescription.Text.ToString();
                string courseSemester = cbstudentSemester.Text.ToString();

                bool isValid = true;
                string errorMessage = "";

                if (string.IsNullOrWhiteSpace(courseName))
                {
                    isValid = false;
                    errorMessage += "Error : Please enter missing data.\n\r";

                }

                if (string.IsNullOrWhiteSpace(courseId))
                {
                    isValid = false;
                    errorMessage += "Error : Please enter missing data.\n\r";
                    txtstudentCourseId.Focus();
                }

                if (string.IsNullOrWhiteSpace(courseLecturer)
                    || string.IsNullOrWhiteSpace(courseDescription))
                {
                    isValid = false;
                    errorMessage += "Error : Please enter missing Lecturer and/or Description.\n\r";
                    txtstudentLecturer.Focus();
                }

                if (isValid)
                {

                    var studentCourseRecordsDb = new StudentCoursesRegistrationRecord
                    {
                        Coursename = courseName,
                        Cid = courseId,
                        Lecturername = courseLecturer,
                        Sdescription = courseDescription,


                        TypesOfSemesterid = (int)cbstudentSemester.SelectedValue
                    };

                    kCollege_DbEntities.StudentCoursesRegistrationRecords.Add(studentCourseRecordsDb);
                    kCollege_DbEntities.SaveChanges();


                    // Display output with Messagebox
                    MessageBox.Show($"Thanks for your submission.\n" +
                        $"Course Name : {courseName} Course ID: {courseId} \n\r" +
                        $"Lecturer : {courseLecturer}\n\r" +
                        $"Description : {courseDescription}\n\r" +
                        $"Semester : {courseSemester}");

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

            // Add color to button click
            // btnstudentCourseSubmit.BackColor = Color.DarkSeaGreen;

        }

        private void btnstudentCourseSubmit_Click(object sender, EventArgs e)
        {
            studentCourseSubmitButton();

        }

        private void btnstudentCourseClear_Click(object sender, EventArgs e)
        {
            studentCourseResetButton();
        }

        private void StudentCoursesWindow_Load(object sender, EventArgs e)
        {
            // Select * from TypesOfCourses
            //var scoures = kCollege_DbEntities.TypesOfCourses.ToList();
            //cbstudentSemester.Items.Clear();

            // Select * from TypesOfSemester
            var ssemsters = kCollege_DbEntities.TypesOfSemesters.ToList();
            cbstudentSemester.DisplayMember = "Name";
            cbstudentSemester.ValueMember = "id";
            cbstudentSemester.DataSource = ssemsters;

        }
    }
}
