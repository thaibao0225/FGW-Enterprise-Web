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
           
        }
    }
}
