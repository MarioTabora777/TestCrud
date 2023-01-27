using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repositories
{
    public class RoleRepository: MasterRepository
    {
        public List<role> obtener()
        {
            return db.role.ToList();
        }
    }
}
