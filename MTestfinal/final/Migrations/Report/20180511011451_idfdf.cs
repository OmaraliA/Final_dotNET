using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace final.Migrations.Report
{
    public partial class idfdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sum",
                table: "Reports",
                newName: "Place");

            migrationBuilder.AddColumn<int>(
                name: "CustDocument",
                table: "Reports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CustName",
                table: "Reports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustSurname",
                table: "Reports",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFlight",
                table: "Reports",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfSale",
                table: "Reports",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustDocument",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "CustName",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "CustSurname",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "DateFlight",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "DateOfSale",
                table: "Reports");

            migrationBuilder.RenameColumn(
                name: "Place",
                table: "Reports",
                newName: "Sum");
        }
    }
}
