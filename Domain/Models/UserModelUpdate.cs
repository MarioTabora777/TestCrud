using DataAccess.repositories;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UserModelUpdate:UserModelMaster
    {
        public UserModelUpdate() { }
        public UserModelUpdate(UserModelUpdate user)
        {
            this.name = user.name;
            this.lastName = user.lastName;
            this.password = user.password;
            this.idDocumento = user.idDocumento;
            this.rol = null;

        }


        public UserModelUpdate modificar()
        {

            user user = new user();
            user.name = this.name;
            user.last_name = this.lastName;
            user.password = this.password;
            user.id_document = this.idDocumento;
            UserRepository repository = new UserRepository();

            repository.modificar(user);

            return this;
        }

    }
}
