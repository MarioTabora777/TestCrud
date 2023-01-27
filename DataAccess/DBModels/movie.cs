using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBModels
{
    [Table("movie")]
    public partial class movie
    {
        [Key]
        public int movie_id { get; set; }

        [StringLength(500)]
        public string description { get; set; }
        public int number_available_rental { get; set; }
        public int number_available_sale { get; set; }
        public double rental_price { get; set; }
        public double sale_price { get; set; }

    }
}
