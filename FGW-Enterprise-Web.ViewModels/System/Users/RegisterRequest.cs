using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.System.Users
{
    public class RegisterRequest
    {
        public string user_Name { get; set; }
        public string user_Password { get; set; }
        public string user_FullName { get; set; }
        public string user_PhoneNumber { get; set; }
        public DateTime user_DOB { get; set; }
        public string user_Email { get; set; }
        public DateTime user_LastLoginDate { get; set; }

    }
}
