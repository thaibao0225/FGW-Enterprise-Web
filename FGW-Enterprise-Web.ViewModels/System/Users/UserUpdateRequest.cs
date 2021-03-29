using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.System.Users
{
    public class UserUpdateRequest
    {
        public Guid Id { get; set; }

       
        public string FirstName { get; set; }

        
        public string LastName { get; set; }

       
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        public string UserName { get; set; }


        public string Email { get; set; }

       
        public string FullName { get; set; }
    }
}