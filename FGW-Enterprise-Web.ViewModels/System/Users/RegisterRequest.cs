using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.System.Users
{
    public class RegisterRequest
    {
        public string user_FirstName { get; set; }
        public string user_LastName { get; set; }
        public string user_FullName { get; set; }
        public DateTime user_DOB { get; set; }
        public string UserName  {get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }





    }
}
