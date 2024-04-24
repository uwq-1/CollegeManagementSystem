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
    public partial class ResetPassword : Form
    {
        private readonly KUniversityDbModel kCollege_DbEntities;

        private LoginRecord _loginRecord;

        public ResetPassword(LoginRecord loginRecord)
        {
            InitializeComponent();
            kCollege_DbEntities = new KUniversityDbModel();
            _loginRecord = loginRecord;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {

            try
            {
                var password = txtresetPassword.Text;
                var confirm_password = txtresetConfirmPassword.Text;
                var user = kCollege_DbEntities.LoginRecords.FirstOrDefault(q => q.id == _loginRecord.id);

                if (password != confirm_password)
                {
                    MessageBox.Show("Password do not match. Please try again.");
                }





                user.password = Utils.HashPassword(password);
                kCollege_DbEntities.SaveChanges();
                MessageBox.Show("Password has been reset successfully.");
                Close();
            }
            catch (Exception)
            {

                MessageBox.Show("An error has occured. Please try again.");
            }

            
        }
    }
}
