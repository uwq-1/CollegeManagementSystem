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
    public partial class ManageArchiveStudentRecords : Form
    {

        private readonly KUniversityDbModel kCollege_DbEntities;

        public ManageArchiveStudentRecords()
        {
            InitializeComponent();
            kCollege_DbEntities = new KUniversityDbModel();
        }

        private void btnaddASRecords_Click(object sender, EventArgs e)
        {
            var addStudentsRecords = new AddEditStudentsRecords(this)
            {
                MdiParent = this.MdiParent
            };
            addStudentsRecords.Show();
        }

        private void btneditASRecords_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)gvArchiveStudentsRecords.SelectedRows[0].Cells["id"].Value;

                // query database  for record
                var records = kCollege_DbEntities.StudentRegistrationRecords.FirstOrDefault(q => q.id == id);

                // launch AddEditStudentsRecords window  with data 
                var addEditStudentsRecords = new AddEditStudentsRecords(records, this);
                addEditStudentsRecords.MdiParent = this.MdiParent;
                addEditStudentsRecords.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");

            }
        }

        private void btndeleteASRecords_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)gvArchiveStudentsRecords.SelectedRows[0].Cells["id"].Value;
                var userid = (int)gvArchiveStudentsRecords.SelectedRows[0].Cells["id"].Value;

                // query database  for record
                var records = kCollege_DbEntities.StudentRegistrationRecords.FirstOrDefault(q => q.id == id);
                var userrecords = kCollege_DbEntities.LoginRecords.FirstOrDefault(q => q.studentid == userid);
                
                DialogResult dr = MessageBox.Show($"Are you sure you want to DELETE THIS RECORD:" +
                    $" Name : {records.Name}  SID : {records.Sid}\n\r ?",
                    "Delete Records", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {

                    // delete records from database
                    kCollege_DbEntities.LoginRecords.Remove(userrecords);
                    kCollege_DbEntities.StudentRegistrationRecords.Remove(records);
                    kCollege_DbEntities.SaveChanges();
                    
                }
                PopulateGrid();

                //gvArchiveStudentsRecords.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        private void ManageArchiveStudentRecords_Load(object sender, EventArgs e)
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

        public void PopulateGrid()
        {
            var records = kCollege_DbEntities
                .StudentRegistrationRecords
                .Select(q => new 
                {
                    ID = q.id,
                    SID = q.Sid,
                    NAME = q.Name,
                    PROGRAMME = q.TypesOfProgramme.name,
                    Tution = q.Stution,
                    EMAIL = q.Email,
                    TEL = q.Phone,
                    DOB = q.DateOfBirth
                }).ToList();

            gvArchiveStudentsRecords.DataSource = records;
            //gvArchiveStudentsRecords.Columns[0].HeaderText = "ID";
            gvArchiveStudentsRecords.Columns[0].Visible = false;
            gvArchiveStudentsRecords.Columns["SID"].HeaderText = "S-ID";
            gvArchiveStudentsRecords.Columns["NAME"].HeaderText = "Stu NAME";
            gvArchiveStudentsRecords.Columns["PROGRAMME"].HeaderText = "DEGREE";
            gvArchiveStudentsRecords.Columns["TUTION"].HeaderText = "TUTION Fee";
            gvArchiveStudentsRecords.Columns["EMAIL"].HeaderText = "EMAIL";
            gvArchiveStudentsRecords.Columns["TEL"].HeaderText = "PHONE";
            gvArchiveStudentsRecords.Columns["DOB"].HeaderText = "DOB";

            

            /*var holdrecords = kCollege_DbEntities
                .StudentCoursesRegistrationRecords
                .Select(q => new 
                {
                    ID = q.Id,
                    COURSE = q.TypesOfCours.name,
                    GRADES = q.StudentGradesRegistrationRecord.Sgrade
                });*/

        }
    }
}
