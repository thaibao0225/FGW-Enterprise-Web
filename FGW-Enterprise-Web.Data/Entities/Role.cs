using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FGW_Enterprise_Web.Data.Entities
{
    public class Role:IdentityRole<Guid>
    {
        public string role_Descrpition { get; set; }


    }
}
