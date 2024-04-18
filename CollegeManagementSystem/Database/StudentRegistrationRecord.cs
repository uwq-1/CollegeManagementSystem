namespace CollegeManagementSystem.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentRegistrationRecord")]
    public partial class StudentRegistrationRecord
    {
        public int id { get; set; }

        [StringLength(15)]
        public string Sid { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? TypeOfProgrammeid { get; set; }

        [StringLength(255)]
        public string Stution { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        public virtual TypesOfProgramme TypesOfProgramme { get; set; }
    }
}
