using FGW_Enterprise_Web.Data.Entities;
using Microsoft.AspNetCore.Identity;
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



         

            var roleID = new Guid("f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd");
            var adminID = new Guid("360E601E-92F2-4F08-832B-604A21293258");

            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = roleID,
                role_Name = "admin",
                NormalizedName = "admin",
                role_Descrpition ="Adminstrator role"
            });

            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = adminID,
                user_Name = "admin",
                NormalizedUserName = "admin",
                user_Email = "nhuvtqgcs18612@fpt.edu.vn",
                NormalizedEmail = "nhuvtqgcs18612@fpt.edu.vn",
                EmailConfirmed = true,
                user_Password = hasher.HashPassword(null, "123456"),
                SecurityStamp = string.Empty,
                user_FullName="VoThiQUynhNhu",
                user_DOB= new DateTime(2021,03,24),
                user_PhoneNumber="0337779292",
                
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleID,//
                UserId = adminID
            });
        }
    }
}
