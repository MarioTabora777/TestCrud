using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace Domain.Models
{
    public class UserModelMaster
    {

        public UserModelMaster() { }

        public int Id { get; set; }
        public string name { get; set; }
        public string _User { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string idDocumento { get; set; }
        public role? rol { get; set; }

        public bool isActive { get; set; } = true;
    }
}
