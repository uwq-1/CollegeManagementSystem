using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kUwi_WebForm
{
    public class Courses
    {
        private string courseName;
        private string courseId;
        private string lecturer;
        private string description;
        private int semester;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public string CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }
        public string Lecturer
        {
            get { return lecturer; }
            set { lecturer = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int Semester
        {
            get { return semester; }
            set { semester = value; }

            // select semester displays the courses available in the semester
           /*if ( )

            {

            }*/

        }
}
        
    }

