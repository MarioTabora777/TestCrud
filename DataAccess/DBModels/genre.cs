using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBModels
{
    [Table("genre")]
    public partial class genre
    {
        [Key]
        public int genre_id { get; set; }
        [StringLength(500)]
        public string description { get; set; }
    }
}
