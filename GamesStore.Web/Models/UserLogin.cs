using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamesStore.Web.Models
{
    public class UserLogin
    {
        public string Email { get; set; }
        public string Credential { get; set; }
        public string Password { get; set; }
    }
}