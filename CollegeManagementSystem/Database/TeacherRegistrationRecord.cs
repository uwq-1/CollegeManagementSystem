namespace CollegeManagementSystem.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TeacherRegistrationRecord")]
    public partial class TeacherRegistrationRecord
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(10)]
        public string phone { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [StringLength(15)]
        public string Tid { get; set; }

        public int? TypesOfMajorSubjectsid { get; set; }

        public virtual TypesOfMajorSubject TypesOfMajorSubject { get; set; }
    }
}
