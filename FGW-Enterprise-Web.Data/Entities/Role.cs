using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FGW_Enterprise_Web.Data.Entities
{
    public class Role
    {
        public string role_Id { get; set; }
        public string role_Name { get; set; }
        public string role_Descrpition { get; set; }
        public List<UserRole> UserRole { get; set; }
        public List<Permision> Permision { get; set; }


    }
}
