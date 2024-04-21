using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeManagementSystem.Database;

namespace CollegeManagementSystem
{
    public partial class LoginWindow : Form
    {

        private readonly KUniversityDbModel kCollege_DbEntities;

        public LoginWindow()
        {
            InitializeComponent();
            kCollege_DbEntities = new KUniversityDbModel();
        }

        
        private void btnloginSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();


                var username = txtloginUsername.Text.Trim();
                var password = txtloginPassword.Text;


                // Convert the input string to a byte array  and compute the hash 
                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));


                // Create a new Stringbuilder to collect the bytes
                // and create a string
                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data
                // and format each one as a hexadecimal string
                for (int i = 0; i < data.Length; i++) 
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                var hashed_password = sBuilder.ToString();


                //var tuser = kCollege_DbEntities.LoginRecords.FirstOrDefault(q => q.TeacherRegistrationRecord.Tid == username && q.password == password);
                //var user = kCollege_DbEntities.LoginRecords.FirstOrDefault(q => q.username == username && q.password == hashed_password);

                var user = kCollege_DbEntities
                    .LoginRecords
                    .FirstOrDefault(q => 
                    
                        q.username == username || 
                        q.StudentRegistrationRecord.Sid == username || 
                        q.TeacherRegistrationRecord.Tid == username &&
                        q.password == hashed_password

                    );

                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                    
                }
                else
                {
                    var mainWindow = new MainWindow(this);
                    mainWindow.Show();
                    Hide();
                }


                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again");
                //throw;
            }
        }
    }
}
