using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repositories
{
    public class UserRepository : MasterRepository
    {

        public user guardar(user user) {

            var newUser = db.Database.SqlQuery<user>("[CreateUser] @user", 
                new SqlParameter("@user", user._user),
                new SqlParameter("@password", user._user),
                new SqlParameter("@name", user._user),
                new SqlParameter("@last_name", user._user),
                new SqlParameter("@id_documento", user._user)
                
                ).FirstOrDefault();

            return newUser;
            
        }


        public user modificar(user user)
        {

            var updatedUser = db.Database.SqlQuery<user>("[UpdateUser] @user",
                new SqlParameter("@user_id", user.user_id),
                new SqlParameter("@user", user._user),
                new SqlParameter("@password", user._user),
                new SqlParameter("@name", user._user),
                new SqlParameter("@last_name", user._user),
                new SqlParameter("@id_documento", user._user)

                ).FirstOrDefault();

            return updatedUser;

        }

        public user borrar(int userId)
        {

            var user = db.user.FirstOrDefault(i=> i.user_id == userId);
            user.is_active = false;

            db.SaveChanges();

            return user;

        }



        public user login(string user, string password)
        {

            var _user = db.user.FirstOrDefault(i => i._user == user && i.password == password);
           

            return _user != null ? _user : null;

        }



    }
}
