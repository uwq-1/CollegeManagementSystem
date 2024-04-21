namespace CollegeManagementSystem.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LoginRecord
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(100)]
        public string password { get; set; }

        public int? SRecords { get; set; }

        public int? TRecords { get; set; }

        public virtual StudentRegistrationRecord StudentRegistrationRecord { get; set; }

        public virtual TeacherRegistrationRecord TeacherRegistrationRecord { get; set; }
    }
}
