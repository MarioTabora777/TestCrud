using DataAccess;
using DataAccess.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public  class UserModelLogin
    {

        public string user { get; set; }
        public string password { get; set; }

        public UserModelLogin() { 
        
        
        }

        public user login() {

            UserRepository repository = new UserRepository();

            return repository.login(user,password);
        }

    }
}
