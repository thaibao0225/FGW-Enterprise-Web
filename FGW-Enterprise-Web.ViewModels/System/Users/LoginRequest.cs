using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.System.Users
{
    public class LoginRequest
    {
        //[Required(ErrorMessage="User name is required")]
        public string UserName { set; get; }
        public string Password { set; get; }

        public bool RememberMe { set; get; }

    }
}
