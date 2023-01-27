namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("user")]
    public partial class user
    {
        [Key]
        public int user_id { get; set; }

        [Column("user")]
        [StringLength(50)]
        public string user1 { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        [StringLength(200)]
        public string last_name { get; set; }

        [StringLength(50)]
        public string id_document { get; set; }

        public int? rol_id { get; set; }

        public int? is_active { get; set; }

        public virtual role role { get; set; }
    }
}
