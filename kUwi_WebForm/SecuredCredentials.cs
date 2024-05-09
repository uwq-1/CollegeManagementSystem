using System;
using System.Security.Cryptography;
using System.Text;


namespace kUwi_WebForm
{
    public class SecuredCredentials
    {
        private int id;
        private string password_hashAndSalt;
        protected string password;
        private bool isStudent;
        private bool isLecturer;

        public SecuredCredentials (string password, bool isLecturer, bool isStudent)
        {
            if (password == null)
            {
                throw new ArgumentNullException ("password");
            }
            //Hash Password
            var hashedAndSalted = HashPassword(password,GenerateSalt());
            password_hashAndSalt = hashedAndSalted;
            this.isStudent = isStudent; 
            this.isLecturer = isLecturer;   
        }
        public SecuredCredentials() 
        {

        }

        private static string HashPassword(string password, byte[] salt)
        {
            using (var sha256 = new SHA256Managed())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] saltedPassword = new byte[passwordBytes.Length + salt.Length];

                // Concatenate password and salt
                Buffer.BlockCopy(passwordBytes, 0, saltedPassword, 0, passwordBytes.Length);
                Buffer.BlockCopy(salt, 0, saltedPassword, passwordBytes.Length, salt.Length);

                // Hash the concatenated password and salt
                byte[] hashedBytes = sha256.ComputeHash(saltedPassword);

                // Concatenate the salt and hashed password for storage
                byte[] hashedPasswordWithSalt = new byte[hashedBytes.Length + salt.Length];
                Buffer.BlockCopy(salt, 0, hashedPasswordWithSalt, 0, salt.Length);
                Buffer.BlockCopy(hashedBytes, 0, hashedPasswordWithSalt, salt.Length, hashedBytes.Length);

                return Convert.ToBase64String(hashedPasswordWithSalt);
            }
        }

        private static byte[] GenerateSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[16]; // Adjust the size based on your security requirements
                rng.GetBytes(salt);
                return salt;
            }
        }

        public int Id
        {
            get { return id; }
            protected set { }
        } 
        public string Password_hashAndSalt
        {   
            get { return password_hashAndSalt;} 
        }
        public bool IsStudent
        {
            get { return isStudent; }
            set { isStudent = value; }
        }
        public bool IsLecturer
        {
            get { return isLecturer; }
            set { isLecturer = value;}
        }

        public string Password
        {
            get { return password; }
            protected internal set { password = value; }
        }
    }
}