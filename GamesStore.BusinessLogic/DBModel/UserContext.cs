using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamesStore.Domain.Entities.User;


namespace GamesStore.BusinessLogic.DBModel
{
    class UserContext : DbContext
    {
        public UserContext() :
            base("name=GamesStore") // connectionstring name define in your web.config
        {

        }

        public virtual DbSet<UDBTable> Users { get; set; }
    }
}
