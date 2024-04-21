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
    public partial class ManageProgrammes : Form
    {
        private readonly KUniversityDbModel kCollege_DbEntities;

        public ManageProgrammes()
        {
            InitializeComponent();
            kCollege_DbEntities = new KUniversityDbModel();
        }

        private void ManageProgrammes_Load(object sender, EventArgs e)
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
            // Select * From TypesOfProgrammes
            //var sprogrammes = kCollege_DbEntities.TypesOfProgrammes.ToList();

            // Select Id as id , name as programme type From TypesOfProgrammes
            var sprogrammes = kCollege_DbEntities.TypesOfProgrammes
                .Select(q => new
                {
                    ID = q.id,
                    Name = q.name
                })
                .ToList();

            gvSProgrammeList.DataSource = sprogrammes;
            //gvSProgrammeList.Columns[0].HeaderText = "ID";
            gvSProgrammeList.Columns[0].Visible = false;
            gvSProgrammeList.Columns[1].HeaderText = "DEGREE PROGRAM";


        }

        private void btnaddProgramme_Click(object sender, EventArgs e)
        {
            AddEditProgrammes addEditProgrammes = new AddEditProgrammes(this)
            {
                MdiParent = this.MdiParent
            };
            addEditProgrammes.Show();
        }

        private void btneditProgramme_Click(object sender, EventArgs e)
        {

            try
            {
                // get Id of selected row
                var id = (int)gvSProgrammeList.SelectedRows[0].Cells["id"].Value;

                // query database  for record
                var programmes = kCollege_DbEntities.TypesOfProgrammes.FirstOrDefault(q => q.id == id);

                // launch AddEditStudentsRecords window  with data 
                var addEditProgrammes = new AddEditProgrammes(programmes, this);
                addEditProgrammes.MdiParent = this.MdiParent;
                addEditProgrammes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }

            
        }

        private void btndeleteProgramme_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)gvSProgrammeList.SelectedRows[0].Cells["id"].Value;

                // query database  for record
                var programmes = kCollege_DbEntities.TypesOfProgrammes.FirstOrDefault(q => q.id == id);

                DialogResult dr = MessageBox.Show($"Are you sure you want to DELETE THIS RECORD:" +
                    $" Name : {programmes.name}  \n\r ?",
                    "Delete Records", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    // delete programes from database
                    kCollege_DbEntities.TypesOfProgrammes.Remove(programmes);
                    kCollege_DbEntities.SaveChanges();
                }
                PopulateGrid();


                //gvSProgrammeList.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error : {ex.Message}");
            }

            
        }
    }
}
