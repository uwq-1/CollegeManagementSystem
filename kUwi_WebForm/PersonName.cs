﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kUwi_WebForm
{
    public class PersonName
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private string title;

    public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
    }

}