using FGW_Enterprise_Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FGW_Enterprise_Web.Data.Extensions
{
    
    public static class ModelBuilderExtensions
    {
        
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is Home Page FWG School" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is Keyword Page FWG School" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description Page FWG School" }
               );
           
            modelBuilder.Entity<Role>().HasData(
                new Role() { role_Id="001", role_Name = "Admin", role_Descrpition = "ffff" },// chỉ quản lý user account, có quyền chỉnh sửa và tạo deadline
                new Role() { role_Id= "002", role_Name = "Marketing Manager", role_Descrpition = "ffff" },
                new Role() { role_Id= "003", role_Name = "Marketing Coordinator", role_Descrpition = "ffff" },
                new Role() { role_Id= "004", role_Name=  "Student", role_Descrpition="ffff" },/*thiếu nha mẹ*/
                new Role() { role_Id= "005", role_Name = "Guest", role_Descrpition = "ffff" }
                );
        }
    }
}
