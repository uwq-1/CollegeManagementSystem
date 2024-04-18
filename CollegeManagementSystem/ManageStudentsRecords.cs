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
    public partial class ManageStudentsRecords : Form
    {
        private readonly KUniversityDbModel kCollege_DbEntities;

        public ManageStudentsRecords()
        {
            InitializeComponent();
            kCollege_DbEntities = new KUniversityDbModel();
        }

        private void ManageStudentsRecords_Load(object sender, EventArgs e)
        {
            var sdatainfo = kCollege_DbEntities.StudentRegistrationRecords
                .Select(q => new { ID = q.id,
                    SID = q.Sid, NAME = q.Name, 
                    PROGRAMME = q.TypesOfProgramme.name,
                    Tution = q.Stution, DOB = q.DateOfBirth})
                .ToList();

            gvStudentsRecords.DataSource = sdatainfo;
            gvStudentsRecords.Columns[0].HeaderText = "ID";
            gvStudentsRecords.Columns[1].HeaderText = "S-ID";
            gvStudentsRecords.Columns[2].HeaderText = "NAME";
            gvStudentsRecords.Columns[3].HeaderText = "DEGREE";
            gvStudentsRecords.Columns[4].HeaderText = "TUTION";
            gvStudentsRecords.Columns[5].HeaderText = "DOB";
        }
    }
}
