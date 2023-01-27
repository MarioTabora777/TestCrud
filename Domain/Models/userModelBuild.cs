using DataAccess;
using DataAccess.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    internal class UserModelBuild:UserModelMaster 
    {

        public UserModelBuild() { 
        
        
        
        }

        public UserModelBuild(UserModelBuild newUSer)
        {
            this.name = newUSer.name;
            this.lastName = newUSer.lastName; 
            this.password = newUSer.password;
            this.idDocumento = newUSer.idDocumento; 
            this.rol = null; 

        }

        public UserModelBuild guardar() {

            user _newUSer = new user();
            _newUSer.name = this.name;
            _newUSer.last_name = this.lastName;
            _newUSer.password = this.password;
            _newUSer.id_document = this.idDocumento; 
            UserRepository repository = new UserRepository();

            repository.guardar(_newUSer);




            return this;
        }


    }
}
