﻿using FGW_Enterprise_Web.Data.Configurations;
using FGW_Enterprise_Web.Data.Entities;
using FGW_Enterprise_Web.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.EF
{
    public class SchlDBContext : DbContext
    {
        private ModelBuilder modelBuilder;

        public SchlDBContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using Fluent API
            modelBuilder.ApplyConfiguration(new UserConfigurations());//apply configure -fluent api configurations- apply one config
            modelBuilder.ApplyConfiguration(new UserRoleConfigurations());
            modelBuilder.ApplyConfiguration(new RoleConfigurations());
            modelBuilder.ApplyConfiguration(new AppConfigConfigurations());
            modelBuilder.ApplyConfiguration(new DeadlineCateConfigurations());
            modelBuilder.ApplyConfiguration(new CourseConfigurations());
            modelBuilder.ApplyConfiguration(new EventConfigurations());
            modelBuilder.ApplyConfiguration(new RegisterEventConfigurations());
            modelBuilder.ApplyConfiguration(new UserActionConfigurations());
            modelBuilder.ApplyConfiguration(new FunctionConfigurations());
            modelBuilder.ApplyConfiguration(new PermisionConfigurations());
            modelBuilder.ApplyConfiguration(new DeadlineConfigurations());
            modelBuilder.ApplyConfiguration(new RegisterDeadlineConfigurations());
            modelBuilder.ApplyConfiguration(new CommentConfigurations());
            modelBuilder.ApplyConfiguration(new UserFileConfigurations());
            modelBuilder.ApplyConfiguration(new RegisterCommentConfigurations());


         








            //data seeding
            modelBuilder.Seed();


















            //base.OnModelCreating(modelBuilder); 



            //Data seeding

        }


        public DbSet<AppConfig> AppConfig { get; set; }
        public DbSet<User> User { get; set; }
       
        public DbSet<Role> Role { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<RegisterEvent> RegisterEvent { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<DeadlineCate> DeadlineCate { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<UserAction> UserAction { get; set; }
        public DbSet<Function> Function { get; set; }
        public DbSet<Permision> Permision { get; set; }
        public DbSet<Deadline> Deadline { get; set; }
        public DbSet<RegisterDeadline> RegisterDeadline { get; set; }
        public DbSet<RegisterComment> RegisterComment { get; set; }
        public DbSet<UserFile> UserFile { get; set; }

        public DbSet<Comment> Comment { get; set; }










    }
}
