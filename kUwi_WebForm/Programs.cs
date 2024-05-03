using System.Security.Cryptography.X509Certificates;

namespace kUwi_WebForm
{
    public class Programs
    {
        private string programmeName;
        private string programmeCode;
        private Courses[] courses;

        //constructor
        public Programs(string programmeName, string programmeCode)
        {

            Courses OralComCourse = new Courses("Oral Communication", "E123", "Oral communication, apart of the english courses offered for second year student");
            Courses PreCalCourse = new Courses("Pre-Calculus", "M234", "Pre-requisite math class for calcuclus for first year students");
            Courses FunCommCourse = new Courses("Fundamentals of Communication", "E153", "This is a mandatory course for all first year students");
            Courses BuilConCourse = new Courses("Building Construction", "B412", "Building and Architectural studies on the construction of buildings");
            Courses TDCourse = new Courses("Technical Drawings", "B413", "This course is for first year student who did not attain a grade  or 2 in CXC");
            Courses WebAppCourse = new Courses("Web Application Development", "I224", "This course is to teach students how to create websites");
            Courses OOPCourse = new Courses("Oject Oriented Programming", "I225", "This course teaches how to create classes and objects used while creating a website for ICT students");
            Courses BusCourse = new Courses("Business Education", "BM323", "This is a course to teach student about how to start a business, create business plans and to how to register their business entities");
            Courses AccCourse = new Courses("Accounting", "BM327", "This is an accounts management class on how to manage account and balance accounting records");


            this.programmeName = programmeName;
            this.programmeCode = programmeCode;


            //checking which programme is select to bring back the courses associated with it
            if (programmeCode == "ICT")
            {
                courses = new Courses[] { OralComCourse, FunCommCourse, PreCalCourse, OOPCourse, WebAppCourse };

            }

            if (programmeCode == "BCON")
            {
                courses = new Courses[] { OralComCourse, FunCommCourse, PreCalCourse, BuilConCourse, TDCourse };


            }

            if (programmeCode == "BMGT")
            {
                courses = new Courses[] { OralComCourse, FunCommCourse, PreCalCourse, BusCourse, AccCourse };

            }
        }

        public string ProgrammeName
        {
            get { return programmeName; }
            set { programmeName = value; }
        }

        public string ProgrammeCode
        {
            get { return programmeCode; }
            set { programmeCode = value; }
        }
        public Courses [] Courses //property created for this class
            {
                get { return courses; }
                set {  courses = value; }
            }
    }
        
    
}