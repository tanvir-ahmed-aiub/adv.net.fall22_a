using BLL.DTOs;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserService
    {
        public static UserDTO GetUser(string username) {
            UserDTO user = null;
            var dbUser = new UserRepo().Get(username);
            if (dbUser != null) {
                user = new UserDTO();   
                user.Password = dbUser.Password;
                user.Uname = dbUser.Uname;
                user.Type = dbUser.Type;
            }
          
            return user;
        }
    }
}
