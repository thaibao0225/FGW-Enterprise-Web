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
            var roleID1 = new Guid("f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff");

            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = roleID,
                Name = "Admin",
                NormalizedName = "Admin",
                role_Descrpition ="Adminstrator role"
                

            });
            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = roleID1,
                Name = "User",
                NormalizedName = "User",
                role_Descrpition = "User role"


            });


            modelBuilder.Entity<DeadlineCate>().HasData(new DeadlineCate
            {   dlCate_Id = "00001",
                dlCate_Name = "EnterpriseWeb ",
                dlCate_Description = "Web project",
                dlCate_CreateBy = "Vo Thi Quynh Nhu",
                dlCate_CreateDate = DateTime.Now


            });
            modelBuilder.Entity<DeadlineCate>().HasData(new DeadlineCate
            {
                dlCate_Id = "00002",
                dlCate_Name = "Project",
                dlCate_Description = "Web project",
                dlCate_CreateBy = "Vo Thi Quynh Nhu",
                dlCate_CreateDate = DateTime.Now


            });
            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = adminID,
                UserName = "Admin",
                NormalizedUserName = "Admin",
                NormalizedEmail = "nhuvtqgcs18612@fpt.edu.vn",
                Email = "nhuvtqgcs18612@fpt.edu.vn",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Ad@123"),
                SecurityStamp = string.Empty,
                user_FullName="Vo Thi Quynh Nhu",
                user_DOB= new DateTime(2021,03,24),
                
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleID,//
                UserId = adminID
            });
        }
    }
}
