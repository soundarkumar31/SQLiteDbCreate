using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SQliteDbCreate.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("Migration_11032022104400")]
    public class Migration_11032022104400 : Migration
    {
        protected override void Up([NotNullAttribute] MigrationBuilder migrationBuilder)
        {
          
            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false).Annotation("SqlServer:Identity", "1,1"),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: true)
                },
                    constraints: cb => cb.PrimaryKey("PK_BlogID_Key", x => x.Id)
                );
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Blog");
        }
    }
}
