using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SQliteDbCreate.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("Migration_11032022111500")]
    public class Migration_11032022111500 : Migration
    {
        protected override void Up([NotNullAttribute] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>("Year", "Blog", nullable: false);
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Year", "Blog");
        }
    }
}
