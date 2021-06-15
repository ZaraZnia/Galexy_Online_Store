using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalexyOnlineStore.Domain.Entities.Users
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public ICollection<UserInRole> UserInRoles { get; set; }

    }
}
