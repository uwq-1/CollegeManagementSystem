namespace CollegeManagementSystem.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserRole
    {
        public int id { get; set; }

        public int? userid { get; set; }

        public int? roleid { get; set; }

        public virtual LoginRecord LoginRecord { get; set; }

        public virtual Role Role { get; set; }
    }
}
