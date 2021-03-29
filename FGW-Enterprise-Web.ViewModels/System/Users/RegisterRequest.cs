using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.System.Users
{
    public class RegisterRequest
    {
        public string user_FirstName { get; set; }
        public string user_LastName { get; set; }
        public string user_FullName { get; set; }
        [DataType(DataType.Date)]
        public DateTime user_DOB { get; set; }
        public string UserName  {get; set; }
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }





    }
}
