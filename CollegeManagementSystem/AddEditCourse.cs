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
    public partial class AddEditCourse : Form
    {
        private bool isEditMode;
        string studentBlank = "";

        private ManageCourseRecords _manageCourseRecords = null;
        private readonly KUniversityDbModel kCollege_DbEntities;


        public AddEditCourse(ManageCourseRecords manageCourseRecords = null)
        {
            InitializeComponent();

            lblcourseRTitle.Text = "Add New Course";

            this.Text = "Add Course";

            isEditMode = false;
            _manageCourseRecords = manageCourseRecords;
            kCollege_DbEntities = new KUniversityDbModel();
        }


        public AddEditCourse(StudentCoursesRegistrationRecord coursesRegistration, ManageCourseRecords manageCourseRecords = null)
        {
            InitializeComponent();

            lblcourseRTitle.Text = "Edit New Course";

            this.Text = "Edit Course";
            _manageCourseRecords = manageCourseRecords;

            if (coursesRegistration == null)
            {
                MessageBox.Show("Please ensure that you select a valid row to edit");
                Close();
            }
            else
            {
                isEditMode = true;

                kCollege_DbEntities = new KUniversityDbModel();
                PopulateFields(coursesRegistration);
            }

        }

        private void PopulateFields(StudentCoursesRegistrationRecord coursesRegistration)
        {
            // primary key id
            lblSRId.Text = coursesRegistration.Id.ToString();
            // Course key id
            txtstudentCourseId.Text = coursesRegistration.Cid;
            txtstudentCourseName.Text = coursesRegistration.Coursename;
            txtstudentLecturer.Text = coursesRegistration.Lecturername;
            txtstudentDescription.Text = coursesRegistration.Sdescription;
            cbstudentSemester.SelectedValue = coursesRegistration.TypesOfSemesterid.ToString();
        }

        public void StudentCourseResetButton()
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

        public void StudentCourseSubmitButton()
        {
            try
            {
                string courseId = txtstudentCourseId.Text.ToString();
                string courseName = txtstudentCourseName.Text;
                string courseLecturer = txtstudentLecturer.Text;
                string courseDescription = txtstudentDescription.Text;
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

                    if (isEditMode  == true)
                    {
                        var id = int.Parse(lblSRId.Text);
                        var courseRegistration = kCollege_DbEntities
                            .StudentCoursesRegistrationRecords
                            .FirstOrDefault(q => q.Id == id);

                        courseRegistration.Coursename = txtstudentCourseName.Text;
                        courseRegistration.Cid = txtstudentCourseId.Text.ToString();
                        courseRegistration.Lecturername = txtstudentLecturer.Text;
                        courseRegistration.Sdescription = txtstudentDescription.Text;
                        courseRegistration.TypesOfSemesterid = (int)cbstudentSemester.SelectedValue;

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
                        var courseRegistration = new StudentCoursesRegistrationRecord
                        {
                            Coursename = courseName,
                            Cid = courseId,
                            Lecturername = courseLecturer,
                            Sdescription = courseDescription,


                            TypesOfSemesterid = (int)cbstudentSemester.SelectedValue
                        };

                        kCollege_DbEntities.StudentCoursesRegistrationRecords.Add(courseRegistration);
                        

                        // Display output with Messagebox
                        MessageBox.Show($"Thanks for your submission.\n" +
                            $"Course Name : {courseName} Course ID: {courseId} \n\r" +
                            $"Lecturer : {courseLecturer}\n\r" +
                            $"Description : {courseDescription}\n\r" +
                            $"Semester : {courseSemester}");
                    }
                    kCollege_DbEntities.SaveChanges();
                    _manageCourseRecords.PopulateGrid();
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


        private void btnsaveCourseRChanges_Click(object sender, EventArgs e)
        {
            StudentCourseSubmitButton();
        }

        private void btncancelCourseRChanges_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnresetCourseRChanges_Click(object sender, EventArgs e)
        {
            StudentCourseResetButton();
        }

        private void AddEditCourse_Load(object sender, EventArgs e)
        {
            // Select * from TypesOfSemester
            var ssemsters = kCollege_DbEntities.TypesOfSemesters.ToList();
            cbstudentSemester.DisplayMember = "Name";
            cbstudentSemester.ValueMember = "id";
            cbstudentSemester.DataSource = ssemsters;
        }

        
    }
}
