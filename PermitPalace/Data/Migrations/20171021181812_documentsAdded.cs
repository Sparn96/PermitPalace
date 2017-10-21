using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PermitPalace.Data.Migrations
{
    public partial class documentsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DOCUMENTS",
                columns: table => new
                {
                    DOCUEMNT_GUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DOCUMENT_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REQUIRES_SIGNATURE = table.Column<bool>(type: "bit", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_last_modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_modified_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOCUMENTS", x => x.DOCUEMNT_GUID);
                });

            migrationBuilder.CreateTable(
                name: "FILED_DOCUMENT",
                columns: table => new
                {
                    FILLED_DOCUMENT_GUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DATE_SIGNED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DOCUMENT_GUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DOCUMENT_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOD_ID_OF_APPROVING_SUPERVISOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IS_SIGNED = table.Column<bool>(type: "bit", nullable: false),
                    PDF_FILENAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PERSONNEL_OWNER = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_last_modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_modified_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FILED_DOCUMENT", x => x.FILLED_DOCUMENT_GUID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DOCUMENTS");

            migrationBuilder.DropTable(
                name: "FILED_DOCUMENT");
        }
    }
}
