using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.System.Users
{
    public class UserVm
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public string Email { get; set; }
        public string RoleUser { get; set; }


        public IList<string> Roles { get; set; }


    }
}
