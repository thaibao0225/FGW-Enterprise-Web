using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Entities
{
    public class UserRole // this class to config many to many 
    {
        public string ur_UserId { get; set; }

        public User User { get; set; }

        public string ur_RoleId { get; set; }
        public Role Role { get; set; }

    }
}
