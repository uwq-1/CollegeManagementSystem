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
    public partial class AddEditGrades : Form
    {
        private bool isEditMode;
        private string studentBlank = "";

        private ManageGradesRecords _manageGradesRecords = null;

        private readonly KUniversityDbModel kCollege_DbEntities;


        public AddEditGrades(ManageGradesRecords manageGradesRecords = null)
        {
            InitializeComponent();
            lblstudentGRTitle.Text = "Add New Grades";
            this.Text = "Add Grades";

            isEditMode = false;
            _manageGradesRecords = manageGradesRecords;
            kCollege_DbEntities = new KUniversityDbModel();
        }

        public AddEditGrades(StudentGradesRegistrationRecord  studentGradesRegistration, ManageGradesRecords manageGradesRecords = null)
        {
            InitializeComponent();
            lblstudentGRTitle.Text = "Edit New Grades";
            this.Text = "Edit Grades";
            _manageGradesRecords = manageGradesRecords;


            if (studentGradesRegistration == null)
            {
                MessageBox.Show("Please ensure that you select a valid row to edit");
                Close();
            }
            else
            {
                isEditMode = true;

                kCollege_DbEntities = new KUniversityDbModel();
                PopulateFields(studentGradesRegistration);
            }

            

        }


        private void PopulateFields(StudentGradesRegistrationRecord studentGradesRegistration)
        {
            lblSRId.Text = studentGradesRegistration.id.ToString();
            cbstudentGRCourseId.Text = studentGradesRegistration.Cid;
            cbstudentGRCourseName.Text = studentGradesRegistration.Coursename;
            cbstudentGRIdNo.Text = studentGradesRegistration.Sid;
            cbstudentGRName.Text = studentGradesRegistration.Sname;
            cbstudentGRLecturer.Text = studentGradesRegistration.Lecturername;
            txtstudentGRComments.Text = studentGradesRegistration.Scomments;
            
            txtstudentGRGrades.Text = studentGradesRegistration.Sgrade.ToString();



        }

        public void StudentGradeClearButton()
        {
            try
            {
                string courseGDescription = txtstudentGRComments.Text;
                int courseGGrades = Convert.ToInt32(txtstudentGRGrades.Text);
                //string errorMessage = "";
                string s = "";

                if (courseGDescription != string.Empty)
                {
                    txtstudentGRComments.ResetText();
                    txtstudentGRComments.AppendText(studentBlank);
                }

                // Clear Integer textbox
                // Reference :
                // https://stackoverflow.com/questions/16734172/checking-a-textbox-for-an-empty-string-an-integer-or-a-string
                if (!int.TryParse(s, out courseGGrades))
                {
                    txtstudentGRGrades.ResetText();
                    txtstudentGRGrades.AppendText(studentBlank);
                    txtstudentGRGrades.Clear();
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
                string courseGId = cbstudentGRCourseId.Text;
                string courseGName = cbstudentGRCourseName.Text;
                string courseGStudentName = cbstudentGRName.Text;
                string courseGStudentId = cbstudentGRIdNo.Text;
                string courseGLecturer = cbstudentGRLecturer.Text;
                string courseGDescription = txtstudentGRComments.Text;
                int courseGGrades = Convert.ToInt32(txtstudentGRGrades.Text);


                bool isValid = true;
                string errorMessage = "";


                if (string.IsNullOrWhiteSpace(courseGLecturer)
                    || string.IsNullOrWhiteSpace(courseGDescription))
                {
                    isValid = false;
                    errorMessage += "Error : Please enter missing Lecturer and/or Description.\n\r";
                    cbstudentGRLecturer.Focus();
                }

                if (courseGGrades >= 0 && courseGGrades <= 100)
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

                    if (isEditMode)
                    {
                        // Edit Code here
                        var id = int.Parse(lblSRId.Text);
                        var studentGradesRegistration = kCollege_DbEntities.
                            StudentGradesRegistrationRecords
                            .FirstOrDefault(q => q.id == id);

                        studentGradesRegistration.Coursename = cbstudentGRCourseName.Text;
                        studentGradesRegistration.Cid = cbstudentGRCourseId.Text;
                        studentGradesRegistration.Lecturername = cbstudentGRLecturer.Text;
                        studentGradesRegistration.Sname = cbstudentGRName.Text;
                        studentGradesRegistration.Sid = cbstudentGRIdNo.Text;
                        studentGradesRegistration.Scomments = txtstudentGRComments.Text;
                        studentGradesRegistration.Sgrade = Convert.ToInt32(txtstudentGRGrades.Text);

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
                        var studentGradesRegistration = new StudentGradesRegistrationRecord
                        {
                            Coursename = courseGName,
                            Cid = courseGId,
                            Lecturername = courseGLecturer,
                            Sname = courseGStudentName,
                            Sid = courseGStudentId,
                            Scomments = courseGDescription,
                            Sgrade = courseGGrades
                        };



                        //studentGradesRegistration.SGradesid = (int)cbstudentGCourseName.SelectedValue;

                        kCollege_DbEntities.StudentGradesRegistrationRecords.Add(studentGradesRegistration);
                        


                        // Display output with Messagebox
                        MessageBox.Show($"Thanks for your submission.\n" +
                            $"Course Name : {courseGName} Course ID: {courseGId} \n\r" +
                            $"Lecturer : {courseGLecturer}\n\r" +
                            $"Student Name : {courseGStudentName}  Student Id: {courseGStudentId}\n\r" +
                            $"Description : {courseGDescription}\n\r" +
                            $"Grade : {courseGGrades}");

                    }
                    kCollege_DbEntities.SaveChanges();
                    _manageGradesRecords.PopulateGrid();

                    MessageBox.Show("Operation completed.");
                    Close();

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

        private void btnsaveGRGradesChanges_Click(object sender, EventArgs e)
        {
            StudentGradeSubmitButton();
        }

        private void btncancelGRGradesCancel_Click(object sender, EventArgs e)
        {
            StudentGradeClearButton();
        }


        private void AddEditGrades_Load(object sender, EventArgs e)
        {
            // Select * from TypesOfCourses

            var sgradesrecords = kCollege_DbEntities.TypesOfCourses.ToList();
            cbstudentGRCourseId.DisplayMember = "Cid";
            cbstudentGRCourseId.ValueMember = "id";
            cbstudentGRCourseName.DisplayMember = "Name";
            cbstudentGRCourseName.ValueMember = "id";
            cbstudentGRCourseName.DataSource = sgradesrecords;
            cbstudentGRCourseId.DataSource = sgradesrecords;


            var sgradesrecordsname = kCollege_DbEntities.StudentRegistrationRecords
                .ToList();

            cbstudentGRIdNo.DisplayMember = "Sid";
            cbstudentGRIdNo.ValueMember = "id";
            cbstudentGRIdNo.DataSource = sgradesrecordsname;


            cbstudentGRName.DisplayMember = "Name";
            cbstudentGRName.ValueMember = "id";
            cbstudentGRName.DataSource = sgradesrecordsname;

            var sgradesteachersname = kCollege_DbEntities
                .TeacherRegistrationRecords
                .ToList();

            cbstudentGRLecturer.DisplayMember = "Name";
            cbstudentGRLecturer.ValueMember = "id";
            cbstudentGRLecturer.DataSource = sgradesteachersname;
        }

        
    }
}
