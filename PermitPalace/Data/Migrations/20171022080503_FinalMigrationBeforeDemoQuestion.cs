using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PermitPalace.Data.Migrations
{
    public partial class FinalMigrationBeforeDemoQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IS_APPROVED",
                table: "FILED_DOCUMENT",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IS_APPROVED",
                table: "FILED_DOCUMENT");
        }
    }
}
