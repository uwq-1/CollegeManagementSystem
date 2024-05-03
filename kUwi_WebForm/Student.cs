﻿using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kUwi_WebForm
{
    public class Student
    {
        private PersonName name;
        private DateTime dob;
        private string loginName;
        private string emailAddress;
        private Programs[] program ;
       // private Courses[] courses;
        private int id_num;
        private int intakeYear;
        private Grades grades;
        private string password;

        public DateTime DOB //properties created for the class
        {
            get { return dob; } //get method(field)C
            set { dob = value; } // set method for the field
        }

        public int Id_num
        {
            get { return id_num; }
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

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public Student(PersonName name, Programs program, string emailAddress)
        {
            if (name != null && program != null && emailAddress.IsNullOrWhiteSpace())
            {
                this.name = name;
                this.program = new Programs []{program};
                this.emailAddress = emailAddress;
            }
        }
        public void updateCourse()
        {

        }
        /*public Courses[] getCourses()
        {
            return courses;
        }*/
        public Programs[] GetProgram()
        {
            return program;
        }
    
}

}


