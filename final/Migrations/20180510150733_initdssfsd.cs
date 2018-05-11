using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace final.Migrations
{
    public partial class initdssfsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FlightID",
                table: "Categorys",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FlightID",
                table: "Categorys");
        }
    }
}
