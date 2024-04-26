using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kUwi_WebForm
{
    public class Student
    {
        private PersonName name;
        private DateTime DOB;
        private string loginName;
        private string emailAddress;
        private string Program;
        private Courses[] courses;
        private int Id_num;
        private int intakeYear;
        private Grades grades;

        public DateTime DOB
        {
            get { return DOB; } //get method(field) 
            set { DOB = value; } // set method for the field
        }

        public int Id_num
        {
            get { return id_Num; }
            protected set { }
        }

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public string LoginName
        {
            get { return loginName; }
            set { loginName = value; }
        }


        public Student(PersonName name, Program program, string emailAddress)
        {

        }
        public void updateCourse()
        {

        }
        public Courses[] getCourses()
        {

        }
        public Program[] GetProgram()
    
}

}


