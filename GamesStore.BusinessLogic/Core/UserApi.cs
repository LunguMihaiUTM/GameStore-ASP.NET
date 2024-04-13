using GamesStore.BusinessLogic.DBModel;
using GamesStore.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamesStore.Helpers;

namespace GamesStore.BusinessLogic.Core
{
    public class UserApi
    {
        internal ULoginResp UserLoginAction(ULoginData data)
        {
            using (var userContext = new UserContext())
            {
                var result = userContext.Users.FirstOrDefault(u => u.Username == data.Credential && u.Password == data.Password);
                if (result == null)
                {
                    return new ULoginResp { Status = false };
                }
            }
            return new ULoginResp { Status = true };
        }

        /*internal ULoginResp UserRegisterAction(ULoginData data)
        {
            using (var userContext = new UserContext())
            {
                var 
            }
        }
        */
    }
}
