using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace DataAccess.DBModels
{
    [Table("rental_movie")]
    public partial class rental_movie
    {
        [Key]
        public int rental_id { get; set; }

        [StringLength(255)]
        public string comment { get; set; }

        public int user_id { get; set; }

        [ForeignKey("user_id")]
        public user user { get; set; }

        public int movie_id { get; set; }

        [ForeignKey("movie_id")]
        public movie movie { get; set; }

        public DateTime transaction_date { get; set;  } 

        public double transaction_price { get; set; }

    }
}
