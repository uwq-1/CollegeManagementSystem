using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeManagementSystem.Database;

namespace CollegeManagementSystem
{
    public static class Utils
    {

        public static StudentRegistrationRecord studentRegistration;
        public static StudentWindow studentWindow;

        public static bool FormIsOpen(string name)
        {
            // Check is window is already open
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == name);
            return isOpen;
        }

        public static string  DefaultHashedPassword()
        {
            SHA256 sha = SHA256.Create();
            // Convert the input string to a byte array  and compute the hash 
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(""));


            // Create a new Stringbuilder to collect the bytes
            // and create a string
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static  string  HashPassword(string password)
        {
            SHA256 sha = SHA256.Create();
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

            return sBuilder.ToString();
        }


        public static string GenerateRandomPassword()
        {
            // Reference to Generate Random Password
            // https://www.c-sharpcorner.com/article/how-to-generate-a-random-password-in-c-sharp-and-net-core/

            // Create a string of characters, numbers, special characters that allowed in the password
            /*string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
            Random random = new Random();

            // Minimum size 8. Max size is number of all allowed chars.
            int size = random.Next(8, validChars.Length);

            // Select one random character at a time from the string
            // and create an array of chars
            char[] chars = new char[size];
            for (int i = 0; i < size; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }*/

            //return new string(chars);

            // Reference to Generate Random Password
            // https://www.shecodes.io/athena/52295-how-to-generate-a-random-password-in-net-core-6-with-c#:~:text=To%20generate%20a%20random%20password%2C%20this%20code%20uses%20the%20Random,Linq%20namespace.

            int length = 10;
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";
            var random = new Random();
            string password = new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return password;

            
        }

    }
}
