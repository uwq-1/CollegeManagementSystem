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
            // Select * From TypesOfProgrammes
            //var sprogrammes = kCollege_DbEntities.TypesOfProgrammes.ToList();

            // Select Id as id , name as programme type From TypesOfProgrammes
            var sprogrammes = kCollege_DbEntities.TypesOfProgrammes
                .Select(q => new {ID = q.id, Name = q.name})
                .ToList();

            

            gvSProgrammeList.DataSource = sprogrammes;
            gvSProgrammeList.Columns[0].HeaderText = "ID";
            gvSProgrammeList.Columns[1].HeaderText = "NAME";
        }

        private void btnaddProgramme_Click(object sender, EventArgs e)
        {

        }

        private void btneditProgramme_Click(object sender, EventArgs e)
        {

        }

        private void btndeleteProgramme_Click(object sender, EventArgs e)
        {

        }
    }
}
