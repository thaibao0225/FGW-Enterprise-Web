using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FGW_Enterprise_Web.Data.EF
{
    public class AspShlDbContextFactory: IDesignTimeDbContextFactory<SchlDBContext>
    {
        public SchlDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())//Download the library
                .AddJsonFile("appsetting.json")// Download the library
                .Build();

            var connectionString = configuration.GetConnectionString("AspSchlDB");//add name data in file appsetting.json

            var optionsBuilder = new DbContextOptionsBuilder<SchlDBContext>();
            optionsBuilder.UseSqlServer(connectionString);//truyen data 

            return new SchlDBContext(optionsBuilder.Options);
        }

       
    }
}
