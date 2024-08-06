using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Univ.Hi_Student_Affairs.Migrations
{
    /// <inheritdoc />
    public partial class ffdfdfd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DegreeId",
                table: "AppCollage",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AppCivilReg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NameAr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NameEn = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CountryId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CityId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCivilReg", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCivilReg_AppCity_CityId",
                        column: x => x.CityId,
                        principalTable: "AppCity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppCivilReg_AppCountry_CountryId",
                        column: x => x.CountryId,
                        principalTable: "AppCountry",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppDegree",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDegree", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppDeprivation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Number = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Type = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDeprivation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppMilitary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NameAr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NameEn = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CityId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppMilitary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppMilitary_AppCity_CityId",
                        column: x => x.CityId,
                        principalTable: "AppCity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppMinistry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NameAr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NameEn = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppMinistry", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppPunishEffect",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPunishEffect", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppPunishmentReason",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPunishmentReason", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppPunishmentStage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPunishmentStage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppPunishType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPunishType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppSeqResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NameAr = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    NameEn = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSeqResult", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppSeqStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NameAr = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    NameEn = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSeqStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NameAr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NameEn = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppStdPhoto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    Data = table.Column<byte[]>(type: "RAW(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStdPhoto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppSubExamStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSubExamStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AverageCalc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Desc = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AverageCalc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NameAr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NameEn = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    MinistryEncode = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppPunishment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PunishEffect = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    UnivDismissal = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    ZeroMark = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    DeprivationId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    PunishTypeId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPunishment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppPunishment_AppDeprivation_DeprivationId",
                        column: x => x.DeprivationId,
                        principalTable: "AppDeprivation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppPunishment_AppPunishType_PunishTypeId",
                        column: x => x.PunishTypeId,
                        principalTable: "AppPunishType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StudyPlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    FireDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CollageId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    AverageCalcId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyPlan_AppCollage_CollageId",
                        column: x => x.CollageId,
                        principalTable: "AppCollage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudyPlan_AverageCalc_AverageCalcId",
                        column: x => x.AverageCalcId,
                        principalTable: "AverageCalc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppStdAbolition",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    No = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Date = table.Column<DateTime>(type: "DATE", nullable: true),
                    CompleteCancellation = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    PunishmentId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStdAbolition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdAbolition_AppPunishment_PunishmentId",
                        column: x => x.PunishmentId,
                        principalTable: "AppPunishment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStudent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StdMinistryId = table.Column<decimal>(type: "NUMBER(20)", nullable: true),
                    StdCollageId = table.Column<decimal>(type: "NUMBER(20)", nullable: true),
                    ExamCollageId = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CountryId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    NationalityId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    FirstNameAR = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    FirstNameEn = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    LastNameAr = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    LastNameEn = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    FatherNameAr = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    FatherNameEn = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    MotherNameAr = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    MotherNameEn = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    YearBirth = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    MonthBirth = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    DayBirth = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    JenderId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    MilitaryId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    STD_SCHOOL_NUM = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    IdentifierTypeId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Identifier = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    Phone = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    Mobile = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    CivilRegId = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CivilRegId1 = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Address = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    BirthPlaceAr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    BirthPlaceEn = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CityBirthId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Email = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    STD_NOTE = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    IsForeign = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    IsArab = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    StdPhotoId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    StdPhotoId1 = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    YEAR = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    AdmissionId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UnivId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UnivSectionId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CollageId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    DepartmentId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    BranchId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    ClassId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    StatusId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SemesterId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    StudyPlanId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    STD_CHOSE_LANG = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Fixed = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "NVARCHAR2(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStudent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStudent_AppAdmission_AdmissionId",
                        column: x => x.AdmissionId,
                        principalTable: "AppAdmission",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppBranch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppCity_CityBirthId",
                        column: x => x.CityBirthId,
                        principalTable: "AppCity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppCivilReg_CivilRegId1",
                        column: x => x.CivilRegId1,
                        principalTable: "AppCivilReg",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppClass_ClassId",
                        column: x => x.ClassId,
                        principalTable: "AppClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppCollage_CollageId",
                        column: x => x.CollageId,
                        principalTable: "AppCollage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppCountry_CountryId",
                        column: x => x.CountryId,
                        principalTable: "AppCountry",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppDepartment_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "AppDepartment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppIdentifierType_IdentifierTypeId",
                        column: x => x.IdentifierTypeId,
                        principalTable: "AppIdentifierType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppMilitary_MilitaryId",
                        column: x => x.MilitaryId,
                        principalTable: "AppMilitary",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppNationality_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "AppNationality",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppSemester_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "AppSemester",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "AppStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppStdPhoto_StdPhotoId1",
                        column: x => x.StdPhotoId1,
                        principalTable: "AppStdPhoto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppUnivSection_UnivSectionId",
                        column: x => x.UnivSectionId,
                        principalTable: "AppUnivSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppUniv_UnivId",
                        column: x => x.UnivId,
                        principalTable: "AppUniv",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_Jender_JenderId",
                        column: x => x.JenderId,
                        principalTable: "Jender",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_StudyPlan_StudyPlanId",
                        column: x => x.StudyPlanId,
                        principalTable: "StudyPlan",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdAdmission",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    AdmissionID = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    STD_ADM_TYPE = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    No = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: true),
                    TotalMarkNet = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    TotalMark = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    LanguageId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SubectMark = table.Column<long>(type: "NUMBER(10)", nullable: true),
                    LanguageMark = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Note = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStdAdmission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdAdmission_AppAdmission_AdmissionID",
                        column: x => x.AdmissionID,
                        principalTable: "AppAdmission",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdAdmission_AppLanguage_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "AppLanguage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdAdmission_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppStdCertificate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    CountryId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CityId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    TypeLicId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    TypeLicBranchId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStdCertificate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdCertificate_AppCity_CityId",
                        column: x => x.CityId,
                        principalTable: "AppCity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdCertificate_AppCountry_CountryId",
                        column: x => x.CountryId,
                        principalTable: "AppCountry",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdCertificate_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppStdCertificate_AppTypeLicBranch_TypeLicBranchId",
                        column: x => x.TypeLicBranchId,
                        principalTable: "AppTypeLicBranch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdCertificate_AppTypeLic_TypeLicId",
                        column: x => x.TypeLicId,
                        principalTable: "AppTypeLic",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdLife",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    OperationId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    RefrenceID = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Date = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Time = table.Column<string>(type: "NVARCHAR2(48)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "NVARCHAR2(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "RAW(16)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStdLife", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdLife_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppStdLife_Operation_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdPunishment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    PunishmentId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    StdAbolitionId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    StdAbolitionId1 = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    PunishmentReasonId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Year = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    ClassId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SemesterId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    YearEnd = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SemesterEndId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Note = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Fixed = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Outside = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    doublePunishment = table.Column<bool>(type: "NUMBER(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStdPunishment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdPunishment_AppClass_ClassId",
                        column: x => x.ClassId,
                        principalTable: "AppClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdPunishment_AppPunishmentReason_PunishmentReasonId",
                        column: x => x.PunishmentReasonId,
                        principalTable: "AppPunishmentReason",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdPunishment_AppPunishment_PunishmentId",
                        column: x => x.PunishmentId,
                        principalTable: "AppPunishment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdPunishment_AppSemester_SemesterEndId",
                        column: x => x.SemesterEndId,
                        principalTable: "AppSemester",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdPunishment_AppSemester_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "AppSemester",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdPunishment_AppStdAbolition_StdAbolitionId1",
                        column: x => x.StdAbolitionId1,
                        principalTable: "AppStdAbolition",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdPunishment_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppStdRegistration",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStdRegistration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdRegistration_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppStdSeqSum",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    Year = table.Column<long>(type: "NUMBER(10)", nullable: true),
                    UnivId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UnivSectionId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CollageId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    DepartmentId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    BranchId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    ClassId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SemesterId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SeqStatusId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SeqResultId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Fixed = table.Column<bool>(type: "NUMBER(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStdSeqSum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdSeqSum_AppBranch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqSum_AppClass_ClassId",
                        column: x => x.ClassId,
                        principalTable: "AppClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqSum_AppCollage_CollageId",
                        column: x => x.CollageId,
                        principalTable: "AppCollage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqSum_AppDepartment_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "AppDepartment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqSum_AppSemester_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "AppSemester",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqSum_AppSeqResult_SeqResultId",
                        column: x => x.SeqResultId,
                        principalTable: "AppSeqResult",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqSum_AppSeqStatus_SeqStatusId",
                        column: x => x.SeqStatusId,
                        principalTable: "AppSeqStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqSum_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqSum_AppUnivSection_UnivSectionId",
                        column: x => x.UnivSectionId,
                        principalTable: "AppUnivSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqSum_AppUniv_UnivId",
                        column: x => x.UnivId,
                        principalTable: "AppUniv",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StdPunishmentStages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    PunishmentStageId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    StdPunishmentId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    StdPunishmentId1 = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    PunishmentId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    PunishmentReasonId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    No = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Date = table.Column<DateTime>(type: "DATE", nullable: true),
                    Note = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StdPunishmentStages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StdPunishmentStages_AppPunishmentReason_PunishmentReasonId",
                        column: x => x.PunishmentReasonId,
                        principalTable: "AppPunishmentReason",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StdPunishmentStages_AppPunishmentStage_PunishmentStageId",
                        column: x => x.PunishmentStageId,
                        principalTable: "AppPunishmentStage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StdPunishmentStages_AppPunishment_PunishmentId",
                        column: x => x.PunishmentId,
                        principalTable: "AppPunishment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StdPunishmentStages_AppStdPunishment_StdPunishmentId1",
                        column: x => x.StdPunishmentId1,
                        principalTable: "AppStdPunishment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdSeqStudy",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Year = table.Column<long>(type: "NUMBER(10)", nullable: true),
                    UnivId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UnivSectionId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CollageId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    DepartmentId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    BranchId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    ClassId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SemesterId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    StatusId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SeqResultId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    TakeSemesterExam = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    Note = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    IsSemesterCounted = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    SEQ_CANCEL_CHEK = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    StdSeqSumId = table.Column<Guid>(type: "RAW(16)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStdSeqStudy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdSeqStudy_AppBranch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqStudy_AppClass_ClassId",
                        column: x => x.ClassId,
                        principalTable: "AppClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqStudy_AppCollage_CollageId",
                        column: x => x.CollageId,
                        principalTable: "AppCollage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqStudy_AppDepartment_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "AppDepartment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqStudy_AppSemester_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "AppSemester",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqStudy_AppSeqResult_SeqResultId",
                        column: x => x.SeqResultId,
                        principalTable: "AppSeqResult",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqStudy_AppStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "AppStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqStudy_AppStdSeqSum_StdSeqSumId",
                        column: x => x.StdSeqSumId,
                        principalTable: "AppStdSeqSum",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqStudy_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppStdSeqStudy_AppUnivSection_UnivSectionId",
                        column: x => x.UnivSectionId,
                        principalTable: "AppUnivSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqStudy_AppUniv_UnivId",
                        column: x => x.UnivId,
                        principalTable: "AppUniv",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppCollage_DegreeId",
                table: "AppCollage",
                column: "DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCivilReg_CityId",
                table: "AppCivilReg",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCivilReg_CountryId",
                table: "AppCivilReg",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AppMilitary_CityId",
                table: "AppMilitary",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AppPunishment_DeprivationId",
                table: "AppPunishment",
                column: "DeprivationId");

            migrationBuilder.CreateIndex(
                name: "IX_AppPunishment_PunishTypeId",
                table: "AppPunishment",
                column: "PunishTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdAbolition_PunishmentId",
                table: "AppStdAbolition",
                column: "PunishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdAdmission_AdmissionID",
                table: "AppStdAdmission",
                column: "AdmissionID");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdAdmission_LanguageId",
                table: "AppStdAdmission",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdAdmission_StudentId",
                table: "AppStdAdmission",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdCertificate_CityId",
                table: "AppStdCertificate",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdCertificate_CountryId",
                table: "AppStdCertificate",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdCertificate_StudentId",
                table: "AppStdCertificate",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdCertificate_TypeLicBranchId",
                table: "AppStdCertificate",
                column: "TypeLicBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdCertificate_TypeLicId",
                table: "AppStdCertificate",
                column: "TypeLicId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdLife_OperationId",
                table: "AppStdLife",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdLife_StudentId",
                table: "AppStdLife",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdPunishment_ClassId",
                table: "AppStdPunishment",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdPunishment_PunishmentId",
                table: "AppStdPunishment",
                column: "PunishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdPunishment_PunishmentReasonId",
                table: "AppStdPunishment",
                column: "PunishmentReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdPunishment_SemesterEndId",
                table: "AppStdPunishment",
                column: "SemesterEndId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdPunishment_SemesterId",
                table: "AppStdPunishment",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdPunishment_StdAbolitionId1",
                table: "AppStdPunishment",
                column: "StdAbolitionId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdPunishment_StudentId",
                table: "AppStdPunishment",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdRegistration_StudentId",
                table: "AppStdRegistration",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_BranchId",
                table: "AppStdSeqStudy",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_ClassId",
                table: "AppStdSeqStudy",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_CollageId",
                table: "AppStdSeqStudy",
                column: "CollageId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_DepartmentId",
                table: "AppStdSeqStudy",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_SemesterId",
                table: "AppStdSeqStudy",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_SeqResultId",
                table: "AppStdSeqStudy",
                column: "SeqResultId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_StatusId",
                table: "AppStdSeqStudy",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_StdSeqSumId",
                table: "AppStdSeqStudy",
                column: "StdSeqSumId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_StudentId",
                table: "AppStdSeqStudy",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_UnivId",
                table: "AppStdSeqStudy",
                column: "UnivId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_UnivSectionId",
                table: "AppStdSeqStudy",
                column: "UnivSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_BranchId",
                table: "AppStdSeqSum",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_ClassId",
                table: "AppStdSeqSum",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_CollageId",
                table: "AppStdSeqSum",
                column: "CollageId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_DepartmentId",
                table: "AppStdSeqSum",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_SemesterId",
                table: "AppStdSeqSum",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_SeqResultId",
                table: "AppStdSeqSum",
                column: "SeqResultId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_SeqStatusId",
                table: "AppStdSeqSum",
                column: "SeqStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_StudentId",
                table: "AppStdSeqSum",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_UnivId",
                table: "AppStdSeqSum",
                column: "UnivId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_UnivSectionId",
                table: "AppStdSeqSum",
                column: "UnivSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_AdmissionId",
                table: "AppStudent",
                column: "AdmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_BranchId",
                table: "AppStudent",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_CityBirthId",
                table: "AppStudent",
                column: "CityBirthId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_CivilRegId1",
                table: "AppStudent",
                column: "CivilRegId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_ClassId",
                table: "AppStudent",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_CollageId",
                table: "AppStudent",
                column: "CollageId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_CountryId",
                table: "AppStudent",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_DepartmentId",
                table: "AppStudent",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_IdentifierTypeId",
                table: "AppStudent",
                column: "IdentifierTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_JenderId",
                table: "AppStudent",
                column: "JenderId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_MilitaryId",
                table: "AppStudent",
                column: "MilitaryId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_NationalityId",
                table: "AppStudent",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_SemesterId",
                table: "AppStudent",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_StatusId",
                table: "AppStudent",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_StdPhotoId1",
                table: "AppStudent",
                column: "StdPhotoId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_StudyPlanId",
                table: "AppStudent",
                column: "StudyPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_UnivId",
                table: "AppStudent",
                column: "UnivId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_UnivSectionId",
                table: "AppStudent",
                column: "UnivSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_StdPunishmentStages_PunishmentId",
                table: "StdPunishmentStages",
                column: "PunishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_StdPunishmentStages_PunishmentReasonId",
                table: "StdPunishmentStages",
                column: "PunishmentReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_StdPunishmentStages_PunishmentStageId",
                table: "StdPunishmentStages",
                column: "PunishmentStageId");

            migrationBuilder.CreateIndex(
                name: "IX_StdPunishmentStages_StdPunishmentId1",
                table: "StdPunishmentStages",
                column: "StdPunishmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_StudyPlan_AverageCalcId",
                table: "StudyPlan",
                column: "AverageCalcId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyPlan_CollageId",
                table: "StudyPlan",
                column: "CollageId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppCollage_AppDegree_DegreeId",
                table: "AppCollage",
                column: "DegreeId",
                principalTable: "AppDegree",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppCollage_AppDegree_DegreeId",
                table: "AppCollage");

            migrationBuilder.DropTable(
                name: "AppDegree");

            migrationBuilder.DropTable(
                name: "AppMinistry");

            migrationBuilder.DropTable(
                name: "AppPunishEffect");

            migrationBuilder.DropTable(
                name: "AppStdAdmission");

            migrationBuilder.DropTable(
                name: "AppStdCertificate");

            migrationBuilder.DropTable(
                name: "AppStdLife");

            migrationBuilder.DropTable(
                name: "AppStdRegistration");

            migrationBuilder.DropTable(
                name: "AppStdSeqStudy");

            migrationBuilder.DropTable(
                name: "AppSubExamStatus");

            migrationBuilder.DropTable(
                name: "StdPunishmentStages");

            migrationBuilder.DropTable(
                name: "Operation");

            migrationBuilder.DropTable(
                name: "AppStdSeqSum");

            migrationBuilder.DropTable(
                name: "AppPunishmentStage");

            migrationBuilder.DropTable(
                name: "AppStdPunishment");

            migrationBuilder.DropTable(
                name: "AppSeqResult");

            migrationBuilder.DropTable(
                name: "AppSeqStatus");

            migrationBuilder.DropTable(
                name: "AppPunishmentReason");

            migrationBuilder.DropTable(
                name: "AppStdAbolition");

            migrationBuilder.DropTable(
                name: "AppStudent");

            migrationBuilder.DropTable(
                name: "AppPunishment");

            migrationBuilder.DropTable(
                name: "AppCivilReg");

            migrationBuilder.DropTable(
                name: "AppMilitary");

            migrationBuilder.DropTable(
                name: "AppStatus");

            migrationBuilder.DropTable(
                name: "AppStdPhoto");

            migrationBuilder.DropTable(
                name: "Jender");

            migrationBuilder.DropTable(
                name: "StudyPlan");

            migrationBuilder.DropTable(
                name: "AppDeprivation");

            migrationBuilder.DropTable(
                name: "AppPunishType");

            migrationBuilder.DropTable(
                name: "AverageCalc");

            migrationBuilder.DropIndex(
                name: "IX_AppCollage_DegreeId",
                table: "AppCollage");

            migrationBuilder.DropColumn(
                name: "DegreeId",
                table: "AppCollage");
        }
    }
}
