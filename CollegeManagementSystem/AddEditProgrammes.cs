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
    public partial class AddEditProgrammes : Form
    {

        private bool isEditMode;

        private readonly ManageProgrammes _manageProgrammes;

        private readonly KUniversityDbModel kCollege_DbEntities;

        public AddEditProgrammes(ManageProgrammes manageProgramme = null)
        {
            InitializeComponent();
            lbltitlePProgramme.Text = "Add New Programme";
            isEditMode = false;
            _manageProgrammes = manageProgramme;
            kCollege_DbEntities = new KUniversityDbModel();
        }

        public AddEditProgrammes(TypesOfProgramme programmeToEdit, ManageProgrammes manageProgramme = null)
        {
            InitializeComponent();
            lbltitlePProgramme.Text = "Edit Programme";
            _manageProgrammes = manageProgramme;

            if (programmeToEdit == null)
            {
                MessageBox.Show("Please ensure that you select a valid row to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                
                kCollege_DbEntities = new KUniversityDbModel();
                PopulateFields(programmeToEdit);
            }

            
        }

        private void PopulateFields(TypesOfProgramme programmeToEdit)
        {
            lblprogramsId.Text = programmeToEdit.id.ToString();
            txtdegreePProgrammeName.Text = programmeToEdit.name;
        }

        private void btnsavePChanges_Click(object sender, EventArgs e)
        {

            string studentProgramme = txtdegreePProgrammeName.Text;

            // if(isEditMode == true)
            if (isEditMode)
            {
                // Edit Code here
                var id = int.Parse(lblprogramsId.Text);
                var programmeToEdit = kCollege_DbEntities.
                    TypesOfProgrammes
                    .FirstOrDefault(q => q.id == id);

                programmeToEdit.name = txtdegreePProgrammeName.Text;

                kCollege_DbEntities.SaveChanges();
            }
            else
            {
                // Add Code here

                var newProgrammes = new TypesOfProgramme 
                { 
                    name = txtdegreePProgrammeName.Text 
                };

                kCollege_DbEntities.TypesOfProgrammes.Add(newProgrammes);

                MessageBox.Show($"Thanks for your submission.\n" +
                            $"DEGREE  Name : {studentProgramme}  \n\r" +
                            $"");

            }
            kCollege_DbEntities.SaveChanges();
            _manageProgrammes.PopulateGrid();
            MessageBox.Show("Operation completed.");
            Close();
        }

        private void btncancelPChanges_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
