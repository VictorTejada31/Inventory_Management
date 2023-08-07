﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    public partial class DashBoardEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DashBoard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThisMonth = table.Column<double>(type: "float", nullable: false),
                    Today = table.Column<double>(type: "float", nullable: false),
                    LastMonth = table.Column<double>(type: "float", nullable: false),
                    Yesterday = table.Column<double>(type: "float", nullable: false),
                    TodayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThisMonthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashBoard", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DashBoard");
        }
    }
}
