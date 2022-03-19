using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;

namespace SQliteDbCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                MyDbContext myDbContext = new MyDbContext();
                myDbContext.Database.Migrate();

                //string dbName = @"C:\SOUNDAR\POC\Console\SQliteDbCreate\TestDatabase.db";
                //if (File.Exists(dbName))
                //{
                //    File.Delete(dbName);
                //}
                //using (var dbContext = new MyDbContext())
                //{
                //    //Ensure database is created                   
                //    dbContext.Database.EnsureCreated();
                //    if (!dbContext.Blogs.Any())
                //    {
                //        dbContext.Blogs.AddRange(new Blog[]
                //            {
                //             new Blog{Title=Guid.NewGuid().ToString(), SubTitle="Blog 1 subtitle" },
                //             new Blog{Title=Guid.NewGuid().ToString(), SubTitle="Blog 2 subtitle" },
                //             new Blog{Title=Guid.NewGuid().ToString(), SubTitle="Blog 3 subtitle" }
                //            });
                //        dbContext.SaveChanges();
                //    }
                //    foreach (var blog in dbContext.Blogs)
                //    {
                //        Console.WriteLine($"BlogID={blog.BlogId}\tTitle={blog.Title}\t{blog.SubTitle}\tDateTimeAdd={blog.DateTimeAdd}");
                //    }
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
