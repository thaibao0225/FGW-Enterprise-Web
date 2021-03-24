using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FGW_Enterprise_Web.Data.Entities
{

    public class User:IdentityUser<Guid>
    {
        [Required]
        public string user_Name { get; set; }
        public string user_Password { get; set; }
        public string user_FullName { get; set; }
        public string user_PhoneNumber { get; set; }
        public DateTime user_DOB { get; set; }
        public string user_Email { get; set; }
        public DateTime user_LastLoginDate { get; set; }

        public List<UserRole> UserRole{ get; set; }
        public List<RegisterEvent> RegisterEvent { get; set; }
        public List<Comment> CommentU{ get; set; }






    }
}
