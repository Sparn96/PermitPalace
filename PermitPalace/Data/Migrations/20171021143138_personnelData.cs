﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PermitPalace.Data.Migrations
{
    public partial class personnelData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PERSONNEL_DATA",
                columns: table => new
                {
                    PERSONNEL_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AFADBD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AGE = table.Column<int>(type: "int", nullable: false),
                    AMMO = table.Column<bool>(type: "bit", nullable: false),
                    AMOS_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AMOS_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AMOS_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AMOS_4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ANNIVESARY_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BILLET = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BLOOD_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BMOS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BODY_FAT_PERCENT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BUS = table.Column<bool>(type: "bit", nullable: false),
                    CAR_INSURANCE_COMPANY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAR_INSURANCE_EXPIRES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CELL_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CERTIFCATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CFT_CLASS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CFT_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CFT_SCORE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CIVILIAN_EXP_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CIVILIAN_ISSUE_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CIVILIAN_LIC_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CIVILIAN_LIC_STATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CLASS_OF_VEHICLE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CURRENT_PLT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCTB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIC_CARD_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EAS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EBFL_MMV = table.Column<bool>(type: "bit", nullable: false),
                    EDIPI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EDUCATION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EET = table.Column<bool>(type: "bit", nullable: false),
                    ENDORSEMENTS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EYE_COLOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FIRST_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FLAK_SIZE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FULL_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FULL_NAME_10964 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GLOVES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GORTEX_BOTTOM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GORTEX_TOP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HAIR_COLOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HAZMAT = table.Column<bool>(type: "bit", nullable: false),
                    HEIGHT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HEIGHT_IN_FEET = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HEIGHT_IN_INCHES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HELMET_SIZE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HIGH_RISK_LETTER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HIGH_RISK_LETTER_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HOME_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HOME_OF_RECORD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMVOV_HMMWV_3503AO = table.Column<bool>(type: "bit", nullable: false),
                    IMVOV_HMMWV_3504AO = table.Column<bool>(type: "bit", nullable: false),
                    IMVOV_HMMWV_3505AO = table.Column<bool>(type: "bit", nullable: false),
                    IMVOV_HMMWV_3506AO = table.Column<bool>(type: "bit", nullable: false),
                    IMVOV_HMMWV_3507AO = table.Column<bool>(type: "bit", nullable: false),
                    IMVOV_HMMWV_3508AO = table.Column<bool>(type: "bit", nullable: false),
                    IMVOV_HMMWV_3509AO = table.Column<bool>(type: "bit", nullable: false),
                    IMVOV_MK3510AO = table.Column<bool>(type: "bit", nullable: false),
                    IMVOV_MK3511AO = table.Column<bool>(type: "bit", nullable: false),
                    IMVOV_MK3512AO = table.Column<bool>(type: "bit", nullable: false),
                    IMVOV_MK3513AO = table.Column<bool>(type: "bit", nullable: false),
                    INSURANCE_POLICY_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LAST_4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LAST_FIRST_MI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LAST_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LICENSE_PLATE_NUMBER_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LICENSE_PLATE_NUMBER_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LICENSE_PLATE_NUMBER_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M1043_44_45_46_A1_A2 = table.Column<bool>(type: "bit", nullable: false),
                    M1097_A2 = table.Column<bool>(type: "bit", nullable: false),
                    M1114_51_52_65A1 = table.Column<bool>(type: "bit", nullable: false),
                    M1116_ITV = table.Column<bool>(type: "bit", nullable: false),
                    M198 = table.Column<bool>(type: "bit", nullable: false),
                    M777 = table.Column<bool>(type: "bit", nullable: false),
                    M870A2E1 = table.Column<bool>(type: "bit", nullable: false),
                    M870_870A1_870A2 = table.Column<bool>(type: "bit", nullable: false),
                    M996_997_A1_A2AMB = table.Column<bool>(type: "bit", nullable: false),
                    M998_1035_1038_1123_A2 = table.Column<bool>(type: "bit", nullable: false),
                    MAK = table.Column<bool>(type: "bit", nullable: false),
                    MARINES_ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MARRIED_OR_SINGLE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MAS = table.Column<bool>(type: "bit", nullable: false),
                    MAXX_PRO = table.Column<bool>(type: "bit", nullable: false),
                    MCMAP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MCMAP_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MEDICAL_CERT_EXPIRES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MEP831A_GEN = table.Column<bool>(type: "bit", nullable: false),
                    MI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MK14 = table.Column<bool>(type: "bit", nullable: false),
                    MK15_15A1_WRECKER = table.Column<bool>(type: "bit", nullable: false),
                    MK16 = table.Column<bool>(type: "bit", nullable: false),
                    MK17_17A1 = table.Column<bool>(type: "bit", nullable: false),
                    MK18_18A1 = table.Column<bool>(type: "bit", nullable: false),
                    MK23_25_27_28 = table.Column<bool>(type: "bit", nullable: false),
                    MK29_30_DUMP = table.Column<bool>(type: "bit", nullable: false),
                    MK31 = table.Column<bool>(type: "bit", nullable: false),
                    MK36_WRECKER = table.Column<bool>(type: "bit", nullable: false),
                    MK48_LVS = table.Column<bool>(type: "bit", nullable: false),
                    MK970_REFUELER = table.Column<bool>(type: "bit", nullable: false),
                    MKR16 = table.Column<bool>(type: "bit", nullable: false),
                    MKR18 = table.Column<bool>(type: "bit", nullable: false),
                    MOS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOS_SCHOOL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOTORCYCLE_INSURANCE_COMPANY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOTORCYCLE_INSURANCE_EXPIRES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOTORCYCLE_PLATE_NUMBER1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOTORCYCLE_POLICY_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOTORCYCLE_SAFE_FOUDATION_LEVEL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MRAP_CAT_III = table.Column<bool>(type: "bit", nullable: false),
                    MRAP_CAT_I_II = table.Column<bool>(type: "bit", nullable: false),
                    MRC145_148 = table.Column<bool>(type: "bit", nullable: false),
                    NEW_TRAM = table.Column<bool>(type: "bit", nullable: false),
                    NOK_1_ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOK_1_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOK_1_PHONE_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOK_1_RELATION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOK_ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOK_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOK_PHONE_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOK_RELATION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OF_346_EXPIRES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OF_346_ISSUE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OF_346_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OLD_TRAM = table.Column<bool>(type: "bit", nullable: false),
                    ORGANIZATION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PEBD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFT_CLASS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFT_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFT_SCORE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PISTOL_CLASS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PISTOL_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PISTOL_SCORE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PLACE_OF_BIRTH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PME_NON_RESIDENT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PME_RESIDENT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RANK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RELIGON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REMARKS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RG_31 = table.Column<bool>(type: "bit", nullable: false),
                    RIFLE_CLASS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RIFLE_RANGE_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RIFLE_RANGE_SCORE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SERVICE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPOUSE_ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPOUSE_DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SPOUSE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPOUSE_PHONE_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STEEL_TOE_BOOTS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SWIM_QUAL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SWIM_QUAL_REQUAL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TANDEMTOW = table.Column<bool>(type: "bit", nullable: false),
                    TIG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TIS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WEIGHT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WEIGH_IN_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WORK_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _1ST_CHILDS_AGE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _1ST_CHILDS_DOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _1ST_CHILDS_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _1ST_CHILD_RELATIONSHIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _1ST_MOTORCYCLE_YEAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _1ST_MOTORCYLCE_MAKE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _1ST_POV_COLOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _1ST_POV_MAKE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _1ST_POV_MODEL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _1ST_POV_YEAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _2ND_CHILDS_AGE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _2ND_CHILDS_DOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _2ND_CHILDS_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _2ND_CHILDS_RELATIONSHIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _2ND_POV_COLOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _2ND_POV_MAKE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _2ND_POV_MODEL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _2ND_POV_YEAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _3RD_CHILDS_AGE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _3RD_CHILDS_DOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _3RD_CHILDS_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _3RD_CHILDS_RELATIONSHIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _4TH_CHILDS_AGE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _4TH_CHILDS_DOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _4TH_CHILDS_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _4TH_CHILDS_RELATIONSHIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _5TH_CHILDS_AGE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _5TH_CHILDS_DOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _5TH_CHILDS_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _5TH_CHILDS_RELATIONSHIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _5_K_FORKLIFT = table.Column<bool>(type: "bit", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_last_modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_modified_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSONNEL_DATA", x => x.PERSONNEL_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PERSONNEL_DATA");
        }
    }
}
