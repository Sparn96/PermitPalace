﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PermitPalace.Data;
using System;

namespace PermitPalace.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20171021190017_dbUpdates")]
    partial class dbUpdates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PermitPalace.Data.DOCUMENT_DATA", b =>
                {
                    b.Property<Guid>("DOCUEMNT_GUID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DOCUMENT_NAME");

                    b.Property<bool>("REQUIRES_SIGNATURE");

                    b.Property<string>("created_by");

                    b.Property<DateTime>("date_created");

                    b.Property<DateTime>("date_last_modified");

                    b.Property<string>("last_modified_by");

                    b.HasKey("DOCUEMNT_GUID");

                    b.ToTable("DOCUMENTS");
                });

            modelBuilder.Entity("PermitPalace.Data.FILLED_DOCUMENT", b =>
                {
                    b.Property<Guid>("FILLED_DOCUMENT_GUID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DATE_SIGNED");

                    b.Property<Guid>("DOCUMENT_GUID");

                    b.Property<string>("DOCUMENT_NAME");

                    b.Property<string>("DOD_ID_OF_APPROVING_SUPERVISOR");

                    b.Property<bool>("IS_SIGNED");

                    b.Property<string>("PDF_FILENAME");

                    b.Property<Guid>("PERSONNEL_OWNER");

                    b.Property<string>("created_by");

                    b.Property<DateTime>("date_created");

                    b.Property<DateTime>("date_last_modified");

                    b.Property<string>("last_modified_by");

                    b.HasKey("FILLED_DOCUMENT_GUID");

                    b.ToTable("FILED_DOCUMENT");
                });

            modelBuilder.Entity("PermitPalace.Data.PERMIT_DATA", b =>
                {
                    b.Property<Guid>("PERMIT_GUID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("APPROVED_BY");

                    b.Property<DateTime>("DATE_EXP");

                    b.Property<DateTime>("DATE_ISSUED");

                    b.Property<string>("PERMIT_NUMBER");

                    b.Property<Guid>("PERSONNEL_ID");

                    b.Property<string>("created_by");

                    b.Property<DateTime>("date_created");

                    b.Property<DateTime>("date_last_modified");

                    b.Property<string>("last_modified_by");

                    b.HasKey("PERMIT_GUID");

                    b.ToTable("PERMIT_DATA");
                });

            modelBuilder.Entity("PermitPalace.Data.PERSONNEL_DATA", b =>
                {
                    b.Property<Guid>("PERSONNEL_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AFADBD");

                    b.Property<int>("AGE");

                    b.Property<bool>("AMMO");

                    b.Property<string>("AMOS_1");

                    b.Property<string>("AMOS_2");

                    b.Property<string>("AMOS_3");

                    b.Property<string>("AMOS_4");

                    b.Property<string>("ANNIVESARY_DATE");

                    b.Property<bool>("ARTHRITIS_RHEUMATISM_SWOLLEN_OR_PAINFUL_JOINTS");

                    b.Property<string>("BILLET");

                    b.Property<bool>("BLACKOUTS_EPILIEPSY");

                    b.Property<string>("BLOOD_TYPE");

                    b.Property<string>("BMOS");

                    b.Property<string>("BODY_FAT_PERCENT");

                    b.Property<bool>("BUS");

                    b.Property<string>("CAR_INSURANCE_COMPANY");

                    b.Property<string>("CAR_INSURANCE_EXPIRES");

                    b.Property<string>("CELL_NUMBER");

                    b.Property<string>("CERTIFCATE");

                    b.Property<string>("CFT_CLASS");

                    b.Property<string>("CFT_DATE");

                    b.Property<string>("CFT_SCORE");

                    b.Property<DateTime>("CIVILIAN_EXP_DATE");

                    b.Property<DateTime>("CIVILIAN_ISSUE_DATE");

                    b.Property<string>("CIVILIAN_LIC_NUMBER");

                    b.Property<string>("CIVILIAN_LIC_STATE");

                    b.Property<string>("CLASS_OF_VEHICLE");

                    b.Property<string>("CURRENT_PLT");

                    b.Property<string>("DCTB");

                    b.Property<bool>("DEFOMITY_OF_HAND_ARM_FOOT_OR_LEG");

                    b.Property<bool>("DIABETES");

                    b.Property<string>("DIC_CARD_NUMBER");

                    b.Property<bool>("DIZZINESS_OR_FAINT_SPELLS");

                    b.Property<DateTime>("DOB");

                    b.Property<string>("DOD_NUMBER");

                    b.Property<bool>("DOES_WEAR_GLASSES_OR_CONTACTS_WHILE_DRIVING");

                    b.Property<bool>("DOES_WEAR_HEARING_AID");

                    b.Property<string>("DOR");

                    b.Property<bool>("DRUG_OR_NARCODIC_HABIT");

                    b.Property<string>("EAS");

                    b.Property<bool>("EBFL_MMV");

                    b.Property<string>("EDIPI");

                    b.Property<string>("EDUCATION");

                    b.Property<bool>("EET");

                    b.Property<string>("ENDORSEMENTS");

                    b.Property<bool>("EXCESSIVE_DRINKING_HABIT");

                    b.Property<string>("EYE_COLOR");

                    b.Property<bool>("EYE_DISEASE");

                    b.Property<string>("FIRST_NAME");

                    b.Property<string>("FLAK_SIZE");

                    b.Property<bool>("FREQUENT_OR_SEVERE_HEADACHES");

                    b.Property<string>("GLOVES");

                    b.Property<string>("GORTEX_BOTTOM");

                    b.Property<string>("GORTEX_TOP");

                    b.Property<string>("HAIR_COLOR");

                    b.Property<bool>("HAZMAT");

                    b.Property<string>("HEIGHT");

                    b.Property<string>("HEIGHT_IN_FEET");

                    b.Property<int>("HEIGHT_IN_INCHES");

                    b.Property<string>("HELMET_SIZE");

                    b.Property<bool>("HIGH_OR_LOW_BLOOD_PRESSURE");

                    b.Property<string>("HIGH_RISK_LETTER");

                    b.Property<string>("HIGH_RISK_LETTER_DATE");

                    b.Property<string>("HOME_NUMBER");

                    b.Property<string>("HOME_OF_RECORD");

                    b.Property<bool>("IMVOV_HMMWV_3503AO");

                    b.Property<bool>("IMVOV_HMMWV_3504AO");

                    b.Property<bool>("IMVOV_HMMWV_3505AO");

                    b.Property<bool>("IMVOV_HMMWV_3506AO");

                    b.Property<bool>("IMVOV_HMMWV_3507AO");

                    b.Property<bool>("IMVOV_HMMWV_3508AO");

                    b.Property<bool>("IMVOV_HMMWV_3509AO");

                    b.Property<bool>("IMVOV_MK3510AO");

                    b.Property<bool>("IMVOV_MK3511AO");

                    b.Property<bool>("IMVOV_MK3512AO");

                    b.Property<bool>("IMVOV_MK3513AO");

                    b.Property<string>("INSURANCE_POLICY_NUMBER");

                    b.Property<string>("LAST_4");

                    b.Property<string>("LAST_NAME");

                    b.Property<string>("LICENSE_PLATE_NUMBER_1");

                    b.Property<string>("LICENSE_PLATE_NUMBER_2");

                    b.Property<string>("LICENSE_PLATE_NUMBER_3");

                    b.Property<bool>("LOSS_OF_HAND_ARM_FOOT_OR_LEG");

                    b.Property<bool>("M1043_44_45_46_A1_A2");

                    b.Property<bool>("M1097_A2");

                    b.Property<bool>("M1114_51_52_65A1");

                    b.Property<bool>("M1116_ITV");

                    b.Property<bool>("M198");

                    b.Property<bool>("M777");

                    b.Property<bool>("M870A2E1");

                    b.Property<bool>("M870_870A1_870A2");

                    b.Property<bool>("M996_997_A1_A2AMB");

                    b.Property<bool>("M998_1035_1038_1123_A2");

                    b.Property<bool>("MAK");

                    b.Property<string>("MARINES_ADDRESS");

                    b.Property<string>("MARRIED_OR_SINGLE");

                    b.Property<bool>("MAS");

                    b.Property<bool>("MAXX_PRO");

                    b.Property<string>("MCMAP");

                    b.Property<string>("MCMAP_DATE");

                    b.Property<string>("MEDICAL_CERT_EXPIRES");

                    b.Property<string>("MED_CERT_REQ");

                    b.Property<bool>("MEP831A_GEN");

                    b.Property<string>("MIDDLE_NAME");

                    b.Property<bool>("MK14");

                    b.Property<bool>("MK15_15A1_WRECKER");

                    b.Property<bool>("MK16");

                    b.Property<bool>("MK17_17A1");

                    b.Property<bool>("MK18_18A1");

                    b.Property<bool>("MK23_25_27_28");

                    b.Property<bool>("MK29_30_DUMP");

                    b.Property<bool>("MK31");

                    b.Property<bool>("MK36_WRECKER");

                    b.Property<bool>("MK48_LVS");

                    b.Property<bool>("MK970_REFUELER");

                    b.Property<bool>("MKR16");

                    b.Property<bool>("MKR18");

                    b.Property<string>("MOS");

                    b.Property<string>("MOS_SCHOOL");

                    b.Property<string>("MOTORCYCLE_INSURANCE_COMPANY");

                    b.Property<string>("MOTORCYCLE_INSURANCE_EXPIRES");

                    b.Property<string>("MOTORCYCLE_PLATE_NUMBER1");

                    b.Property<string>("MOTORCYCLE_POLICY_NUMBER");

                    b.Property<string>("MOTORCYCLE_SAFE_FOUDATION_LEVEL");

                    b.Property<bool>("MRAP_CAT_III");

                    b.Property<bool>("MRAP_CAT_I_II");

                    b.Property<bool>("MRC145_148");

                    b.Property<bool>("NERVOUS_OR_MENTAL_TROUBLE");

                    b.Property<bool>("NEW_TRAM");

                    b.Property<string>("NOK_1_ADDRESS");

                    b.Property<string>("NOK_1_NAME");

                    b.Property<string>("NOK_1_PHONE_NUMBER");

                    b.Property<string>("NOK_1_RELATION");

                    b.Property<string>("NOK_ADDRESS");

                    b.Property<string>("NOK_NAME");

                    b.Property<string>("NOK_PHONE_NUMBER");

                    b.Property<string>("NOK_RELATION");

                    b.Property<string>("OF_346_EXPIRES");

                    b.Property<string>("OF_346_ISSUE");

                    b.Property<string>("OF_346_NUMBER");

                    b.Property<bool>("OLD_TRAM");

                    b.Property<string>("ORGANIZATION");

                    b.Property<bool>("OTHER_SERIOUS_DEFECTS_OR_DISEASE");

                    b.Property<bool>("PALPITATION_CHEST_PAIN_SHORT_BREATH");

                    b.Property<string>("PEBD");

                    b.Property<string>("PFT_CLASS");

                    b.Property<string>("PFT_DATE");

                    b.Property<string>("PFT_SCORE");

                    b.Property<string>("PISTOL_CLASS");

                    b.Property<string>("PISTOL_DATE");

                    b.Property<string>("PISTOL_SCORE");

                    b.Property<string>("PLACE_OF_BIRTH");

                    b.Property<string>("PME_NON_RESIDENT");

                    b.Property<string>("PME_RESIDENT");

                    b.Property<bool>("POOR_HEARING_IN_ONE_OR_BOTH");

                    b.Property<bool>("POOR_VIS_IN_ONE_OR_BOTH");

                    b.Property<string>("RANK");

                    b.Property<string>("RELIGON");

                    b.Property<string>("REMARKS");

                    b.Property<bool>("RG_31");

                    b.Property<string>("RIFLE_CLASS");

                    b.Property<string>("RIFLE_RANGE_DATE");

                    b.Property<string>("RIFLE_RANGE_SCORE");

                    b.Property<string>("SERVICE");

                    b.Property<string>("SEX");

                    b.Property<string>("SPOUSE_ADDRESS");

                    b.Property<DateTime>("SPOUSE_DOB");

                    b.Property<string>("SPOUSE_NAME");

                    b.Property<string>("SPOUSE_PHONE_NUMBER");

                    b.Property<string>("STEEL_TOE_BOOTS");

                    b.Property<bool>("SUGAR_OR_ALBUMIN_IN_URINE");

                    b.Property<string>("SWIM_QUAL");

                    b.Property<string>("SWIM_QUAL_REQUAL");

                    b.Property<bool>("TANDEMTOW");

                    b.Property<string>("TIG");

                    b.Property<string>("TIS");

                    b.Property<bool>("WEARS_GLASSES");

                    b.Property<string>("WEIGHT");

                    b.Property<string>("WEIGH_IN_DATE");

                    b.Property<string>("WORK_NUMBER");

                    b.Property<string>("_1ST_CHILDS_AGE");

                    b.Property<string>("_1ST_CHILDS_DOB");

                    b.Property<string>("_1ST_CHILDS_NAME");

                    b.Property<string>("_1ST_CHILD_RELATIONSHIP");

                    b.Property<string>("_1ST_MOTORCYCLE_YEAR");

                    b.Property<string>("_1ST_MOTORCYLCE_MAKE");

                    b.Property<string>("_1ST_POV_COLOR");

                    b.Property<string>("_1ST_POV_MAKE");

                    b.Property<string>("_1ST_POV_MODEL");

                    b.Property<string>("_1ST_POV_YEAR");

                    b.Property<string>("_2ND_CHILDS_AGE");

                    b.Property<string>("_2ND_CHILDS_DOB");

                    b.Property<string>("_2ND_CHILDS_NAME");

                    b.Property<string>("_2ND_CHILDS_RELATIONSHIP");

                    b.Property<string>("_2ND_POV_COLOR");

                    b.Property<string>("_2ND_POV_MAKE");

                    b.Property<string>("_2ND_POV_MODEL");

                    b.Property<string>("_2ND_POV_YEAR");

                    b.Property<string>("_3270");

                    b.Property<string>("_3RD_CHILDS_AGE");

                    b.Property<string>("_3RD_CHILDS_DOB");

                    b.Property<string>("_3RD_CHILDS_NAME");

                    b.Property<string>("_3RD_CHILDS_RELATIONSHIP");

                    b.Property<string>("_4TH_CHILDS_AGE");

                    b.Property<string>("_4TH_CHILDS_DOB");

                    b.Property<string>("_4TH_CHILDS_NAME");

                    b.Property<string>("_4TH_CHILDS_RELATIONSHIP");

                    b.Property<string>("_5TH_CHILDS_AGE");

                    b.Property<string>("_5TH_CHILDS_DOB");

                    b.Property<string>("_5TH_CHILDS_NAME");

                    b.Property<string>("_5TH_CHILDS_RELATIONSHIP");

                    b.Property<bool>("_5_K_FORKLIFT");

                    b.Property<string>("created_by");

                    b.Property<DateTime>("date_created");

                    b.Property<DateTime>("date_last_modified");

                    b.Property<string>("last_modified_by");

                    b.HasKey("PERSONNEL_ID");

                    b.ToTable("PERSONNEL_DATA");
                });

            modelBuilder.Entity("PermitPalace.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PermitPalace.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PermitPalace.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PermitPalace.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PermitPalace.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
