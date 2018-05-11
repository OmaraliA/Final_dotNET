using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace final.Migrations.Detail
{
    public partial class initdssfssd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateFlight",
                table: "Details",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateFlight",
                table: "Details");
        }
    }
}
