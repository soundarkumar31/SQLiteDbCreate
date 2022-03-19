using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Reflection;
using System.Text;

namespace SQliteDbCreate
{
    public class MyDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\AUD Projects\TestDatabase.db");
            //optionsBuilder.UseSqlite("Filename=TestDatabase.db", options =>
            //{
            //    options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            //});
            base.OnConfiguring(optionsBuilder);
        }       
    }
}
