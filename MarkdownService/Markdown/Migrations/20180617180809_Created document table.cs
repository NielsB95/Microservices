﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Markdown.Migrations
{
    public partial class Createddocumenttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Markdown = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");
        }
    }
}
