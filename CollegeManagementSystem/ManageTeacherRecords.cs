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
    public partial class ManageTeacherRecords : Form
    {

        private readonly KUniversityDbModel kCollege_DbEntities;

        public ManageTeacherRecords()
        {
            InitializeComponent();
            kCollege_DbEntities = new KUniversityDbModel();
        }

        private void btnaddTRecords_Click(object sender, EventArgs e)
        {
            var addEditTeachers = new AddEditTeachers(this)
            {
                MdiParent = this.MdiParent
            };
            addEditTeachers.Show();


        }

        private void btneditTRecords_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)gvTeacherRecords.SelectedRows[0].Cells["id"].Value;

                // query database  for record
                var records = kCollege_DbEntities.TeacherRegistrationRecords.FirstOrDefault(q => q.id == id);

                // launch AddEditTeachers records window  with data 
                var addEditTeachers = new AddEditTeachers(records,this)
                {
                    MdiParent = this.MdiParent
                };
                addEditTeachers.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        private void btndeleteTRecords_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)gvTeacherRecords.SelectedRows[0].Cells["id"].Value;
                var userid = (int)gvTeacherRecords.SelectedRows[0].Cells["id"].Value;

                // query database  for record
                var records = kCollege_DbEntities.TeacherRegistrationRecords.FirstOrDefault(q => q.id == id);
                var userrecords = kCollege_DbEntities.LoginRecords.FirstOrDefault(q => q.teacherid == userid);

                DialogResult dr = MessageBox.Show($"Are you sure you want to DELETE THIS RECORD:" +
                    $" Name : {records.name}  TID : {records.Tid}\n\r ?",
                    "Delete Records", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {

                    // delete students records from database
                    kCollege_DbEntities.LoginRecords.Remove(userrecords);
                    kCollege_DbEntities.TeacherRegistrationRecords.Remove(records);
                    kCollege_DbEntities.SaveChanges();

                }
                PopulateGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        private void ManageTeacherRecords_Load(object sender, EventArgs e)
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
                .TeacherRegistrationRecords
                .Select(q => new
                {
                    ID = q.id,
                    TID = q.Tid,
                    NAME = q.name,
                    MAJORSUBJECT = q.TypesOfMajorSubject.name,
                    EMAIL = q.email,
                    TEL = q.phone,
                    DOB = q.DateOfBirth
                }).ToList();

            gvTeacherRecords.DataSource = records;
            //gvTeacherRecords.Columns[0].HeaderText = "ID";
            gvTeacherRecords.Columns[0].Visible = false;
            gvTeacherRecords.Columns["TID"].HeaderText = "T-ID";
            gvTeacherRecords.Columns["NAME"].HeaderText = "LECTURER";
            gvTeacherRecords.Columns["MAJORSUBJECT"].HeaderText = "INSTRUCTOR";
            gvTeacherRecords.Columns["EMAIL"].HeaderText = "EMAIL";
            gvTeacherRecords.Columns["TEL"].HeaderText = "PHONE";
            gvTeacherRecords.Columns["DOB"].HeaderText = "DOB";

        }

    }
}
