using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PermitPalace.Data.Migrations
{
    public partial class permit_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FULL_NAME",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "FULL_NAME_10964",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "LAST_FIRST_MI",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "MI",
                table: "PERSONNEL_DATA");

            migrationBuilder.AddColumn<bool>(
                name: "ARTHRITIS_RHEUMATISM_SWOLLEN_OR_PAINFUL_JOINTS",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "BLACKOUTS_EPILIEPSY",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DEFOMITY_OF_HAND_ARM_FOOT_OR_LEG",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DIABETES",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DIZZINESS_OR_FAINT_SPELLS",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DOD_NUMBER",
                table: "PERSONNEL_DATA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DOES_WEAR_GLASSES_OR_CONTACTS_WHILE_DRIVING",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DOES_WEAR_HEARING_AID",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DRUG_OR_NARCODIC_HABIT",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EXCESSIVE_DRINKING_HABIT",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EYE_DISEASE",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FREQUENT_OR_SEVERE_HEADACHES",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HIGH_OR_LOW_BLOOD_PRESSURE",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LOSS_OF_HAND_ARM_FOOT_OR_LEG",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MED_CERT_REQ",
                table: "PERSONNEL_DATA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MIDDLE_NAME",
                table: "PERSONNEL_DATA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "NERVOUS_OR_MENTAL_TROUBLE",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OTHER_SERIOUS_DEFECTS_OR_DISEASE",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PALPITATION_CHEST_PAIN_SHORT_BREATH",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "POOR_HEARING_IN_ONE_OR_BOTH",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "POOR_VIS_IN_ONE_OR_BOTH",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SUGAR_OR_ALBUMIN_IN_URINE",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "WEARS_GLASSES",
                table: "PERSONNEL_DATA",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "_3270",
                table: "PERSONNEL_DATA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PERMIT_DATA",
                columns: table => new
                {
                    PERMIT_GUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    APPROVED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATE_EXP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATE_ISSUED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PERMIT_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PERSONNEL_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_last_modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_modified_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERMIT_DATA", x => x.PERMIT_GUID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PERMIT_DATA");

            migrationBuilder.DropColumn(
                name: "ARTHRITIS_RHEUMATISM_SWOLLEN_OR_PAINFUL_JOINTS",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "BLACKOUTS_EPILIEPSY",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "DEFOMITY_OF_HAND_ARM_FOOT_OR_LEG",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "DIABETES",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "DIZZINESS_OR_FAINT_SPELLS",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "DOD_NUMBER",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "DOES_WEAR_GLASSES_OR_CONTACTS_WHILE_DRIVING",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "DOES_WEAR_HEARING_AID",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "DRUG_OR_NARCODIC_HABIT",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "EXCESSIVE_DRINKING_HABIT",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "EYE_DISEASE",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "FREQUENT_OR_SEVERE_HEADACHES",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "HIGH_OR_LOW_BLOOD_PRESSURE",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "LOSS_OF_HAND_ARM_FOOT_OR_LEG",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "MED_CERT_REQ",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "MIDDLE_NAME",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "NERVOUS_OR_MENTAL_TROUBLE",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "OTHER_SERIOUS_DEFECTS_OR_DISEASE",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "PALPITATION_CHEST_PAIN_SHORT_BREATH",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "POOR_HEARING_IN_ONE_OR_BOTH",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "POOR_VIS_IN_ONE_OR_BOTH",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "SUGAR_OR_ALBUMIN_IN_URINE",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "WEARS_GLASSES",
                table: "PERSONNEL_DATA");

            migrationBuilder.DropColumn(
                name: "_3270",
                table: "PERSONNEL_DATA");

            migrationBuilder.AddColumn<string>(
                name: "FULL_NAME",
                table: "PERSONNEL_DATA",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FULL_NAME_10964",
                table: "PERSONNEL_DATA",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LAST_FIRST_MI",
                table: "PERSONNEL_DATA",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MI",
                table: "PERSONNEL_DATA",
                nullable: true);
        }
    }
}
