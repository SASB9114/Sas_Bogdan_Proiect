﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sas_Bogdan_Proiect.Migrations
{
    public partial class Magazin2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Magazin",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Magazin");
        }
    }
}
