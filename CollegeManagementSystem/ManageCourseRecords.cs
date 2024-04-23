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
    public partial class ManageCourseRecords : Form
    {
        
        private readonly KUniversityDbModel kCollege_DbEntities;

        public ManageCourseRecords()
        {
            InitializeComponent();
            kCollege_DbEntities = new KUniversityDbModel();
        }

        private void ManageCourseRecords_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        private void btnaddCRecords_Click(object sender, EventArgs e)
        {
            var addEditCourses = new AddEditCourse(this)
            {
                MdiParent = this.MdiParent
            };
            addEditCourses.Show();
        }

        private void btneditCRecords_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)gvCourseRecords.SelectedRows[0].Cells["Id"].Value;

                // query database  for record
                var records = kCollege_DbEntities.StudentCoursesRegistrationRecords.FirstOrDefault(q => q.Id == id);

                // launch AddEditCourse records window  with data 
                var addEditCourses = new AddEditCourse(records, this)
                {
                    MdiParent = this.MdiParent
                };
                addEditCourses.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        private void btndeleteCRecords_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)gvCourseRecords.SelectedRows[0].Cells["Id"].Value;

                // query database  for record
                var records = kCollege_DbEntities
                    .StudentCoursesRegistrationRecords
                    .FirstOrDefault(q => q.Id == id);

                DialogResult dr = MessageBox.Show($"Are you sure you want to DELETE THIS RECORD:" +
                    $" Name : {records.Coursename}  CID : {records.Cid}\n\r ?",
                    "Delete Records", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {

                    // delete students records from database
                    kCollege_DbEntities.StudentCoursesRegistrationRecords.Remove(records);
                    kCollege_DbEntities.SaveChanges();

                }
                PopulateGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        public void PopulateGrid()
        {
            var records = kCollege_DbEntities
                .StudentCoursesRegistrationRecords
                .Select(q => new
                {
                    ID = q.Id,
                    CID = q.Cid,
                    NAME = q.Coursename,
                    LECTURER = q.Lecturername,
                    DESCRIPTION = q.Sdescription,
                    SEMESTER = q.TypesOfSemester.name
                }).ToList();

            gvCourseRecords.DataSource = records;
            //gvCourseRecords.Columns[0].HeaderText = "ID";
            gvCourseRecords.Columns[0].Visible = false;
            gvCourseRecords.Columns["CID"].HeaderText = "C-ID";
            gvCourseRecords.Columns["NAME"].HeaderText = "COURSE NAME";
            gvCourseRecords.Columns["LECTURER"].HeaderText = "LECTURER";
            gvCourseRecords.Columns["DESCRIPTION"].HeaderText = "COMMENTS";
            gvCourseRecords.Columns["SEMESTER"].HeaderText = "SEMESTER";
            

        }

    }
}
