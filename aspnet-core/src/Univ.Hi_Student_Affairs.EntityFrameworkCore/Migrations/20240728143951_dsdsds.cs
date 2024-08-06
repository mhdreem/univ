using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Univ.Hi_Student_Affairs.Migrations
{
    /// <inheritdoc />
    public partial class dsdsds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StdPunishmentStages_AppPunishmentReason_PunishmentReasonId",
                table: "StdPunishmentStages");

            migrationBuilder.DropIndex(
                name: "IX_StdPunishmentStages_PunishmentReasonId",
                table: "StdPunishmentStages");

            migrationBuilder.DropColumn(
                name: "PunishmentReasonId",
                table: "StdPunishmentStages");

            migrationBuilder.DropColumn(
                name: "STD_CHOSE_LANG",
                table: "AppStudent");

            migrationBuilder.DropColumn(
                name: "STD_SCHOOL_NUM",
                table: "AppStudent");

            migrationBuilder.DropColumn(
                name: "CompleteCancellation",
                table: "AppStdAbolition");

            migrationBuilder.RenameColumn(
                name: "STD_NOTE",
                table: "AppStudent",
                newName: "Note");

            migrationBuilder.RenameColumn(
                name: "STD_ADM_TYPE",
                table: "AppStdAdmission",
                newName: "AdmissionType");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "StdPunishmentStages",
                type: "NVARCHAR2(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "StdPunishmentStages",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "StdPunishmentStages",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "StdPunishmentStages",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "StdPunishmentStages",
                type: "TIMESTAMP(7)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "StdPunishmentStages",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "StdPunishmentStages",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "StdPunishmentStages",
                type: "TIMESTAMP(7)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "StdPunishmentStages",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AppStdSeqSum",
                type: "NVARCHAR2(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "AppStdSeqSum",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "AppStdSeqSum",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "AppStdSeqSum",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "AppStdSeqSum",
                type: "TIMESTAMP(7)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "AppStdSeqSum",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AppStdSeqSum",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "AppStdSeqSum",
                type: "TIMESTAMP(7)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "AppStdSeqSum",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AppStdSeqStudy",
                type: "NVARCHAR2(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "AppStdSeqStudy",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "AppStdSeqStudy",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "AppStdSeqStudy",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "AppStdSeqStudy",
                type: "TIMESTAMP(7)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "AppStdSeqStudy",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AppStdSeqStudy",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "AppStdSeqStudy",
                type: "TIMESTAMP(7)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "AppStdSeqStudy",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Agent",
                table: "AppStdRegistration",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AgentDate",
                table: "AppStdRegistration",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AgentNo",
                table: "AppStdRegistration",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AgentSource",
                table: "AppStdRegistration",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AppStdRegistration",
                type: "NVARCHAR2(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "AppStdRegistration",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "AppStdRegistration",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "AppStdRegistration",
                type: "TIMESTAMP(7)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "AppStdRegistration",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "AppStdRegistration",
                type: "TIMESTAMP(7)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "AppStdRegistration",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AppStdRegistration",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "AppStdRegistration",
                type: "TIMESTAMP(7)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "AppStdRegistration",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "No",
                table: "AppStdRegistration",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RegOrderId",
                table: "AppStdRegistration",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegOrderId1",
                table: "AppStdRegistration",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegistrationState",
                table: "AppStdRegistration",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SemesterId",
                table: "AppStdRegistration",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "AppStdRegistration",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AppStdPunishment",
                type: "NVARCHAR2(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "AppStdPunishment",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "AppStdPunishment",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "AppStdPunishment",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "AppStdPunishment",
                type: "TIMESTAMP(7)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "AppStdPunishment",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AppStdPunishment",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "AppStdPunishment",
                type: "TIMESTAMP(7)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "AppStdPunishment",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PunishmentState",
                table: "AppStdPunishment",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "AppStdLife",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "AppStdLife",
                type: "TIMESTAMP(7)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AppStdLife",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AppStdCertificate",
                type: "NVARCHAR2(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "AppStdCertificate",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "AppStdCertificate",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "AppStdCertificate",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "AppStdCertificate",
                type: "TIMESTAMP(7)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "AppStdCertificate",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ForeignCert",
                table: "AppStdCertificate",
                type: "NUMBER(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ForeignCertCorrect",
                table: "AppStdCertificate",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AppStdCertificate",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsForeignCertCorrect",
                table: "AppStdCertificate",
                type: "NUMBER(1)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "AppStdCertificate",
                type: "TIMESTAMP(7)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "AppStdCertificate",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "No",
                table: "AppStdCertificate",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "AppStdCertificate",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TotalMark",
                table: "AppStdCertificate",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TotalNet",
                table: "AppStdCertificate",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "AppStdCertificate",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdmissionLanguageId",
                table: "AppStdAdmission",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AppStdAdmission",
                type: "NVARCHAR2(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "AppStdAdmission",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "AppStdAdmission",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "AppStdAdmission",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "AppStdAdmission",
                type: "TIMESTAMP(7)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "AppStdAdmission",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AppStdAdmission",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "AppStdAdmission",
                type: "TIMESTAMP(7)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "AppStdAdmission",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AppStdAbolition",
                type: "NVARCHAR2(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "AppStdAbolition",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "AppStdAbolition",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "AppStdAbolition",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "AppStdAbolition",
                type: "TIMESTAMP(7)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "AppStdAbolition",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AppStdAbolition",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "AppStdAbolition",
                type: "TIMESTAMP(7)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "AppStdAbolition",
                type: "RAW(16)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Result",
                table: "AppStdAbolition",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AppAbsenceOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAbsenceOrder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAbsenceStage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAbsenceStage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAffiliationOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAffiliationOrder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAffiliationStage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAffiliationStage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRegOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRegOrder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRegStage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    isFinal = table.Column<bool>(type: "NUMBER(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRegStage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppStdChangeCollage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: false),
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
                    table.PrimaryKey("PK_AppStdChangeCollage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdChangeCollage_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppStdInstitute",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: true),
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
                    table.PrimaryKey("PK_AppStdInstitute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdInstitute_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdNonSyrianUniv",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: false),
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
                    table.PrimaryKey("PK_AppStdNonSyrianUniv", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdNonSyrianUniv_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppStdSymTransform",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: true),
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
                    table.PrimaryKey("PK_AppStdSymTransform", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdSymTransform_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppTerminationOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTerminationOrder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppTerminationStage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTerminationStage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppStdAbsence",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    AbsenceState = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    AbsenceOrderId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    AbsenceOrderId1 = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Reason = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    YearFrom = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    YearTo = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SemesterFromId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SemesterToId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Agent = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AgentNo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AgentDate = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AgentSource = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Note = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
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
                    table.PrimaryKey("PK_AppStdAbsence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdAbsence_AppAbsenceOrder_AbsenceOrderId1",
                        column: x => x.AbsenceOrderId1,
                        principalTable: "AppAbsenceOrder",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdAbsence_AppSemester_SemesterFromId",
                        column: x => x.SemesterFromId,
                        principalTable: "AppSemester",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdAbsence_AppSemester_SemesterToId",
                        column: x => x.SemesterToId,
                        principalTable: "AppSemester",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdAbsence_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppStdAffiliation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    AffiliationState = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    AffiliationOrderId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    AffiliationOrderId1 = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Year = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SemesterId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Note = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
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
                    table.PrimaryKey("PK_AppStdAffiliation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdAffiliation_AppAffiliationOrder_AffiliationOrderId1",
                        column: x => x.AffiliationOrderId1,
                        principalTable: "AppAffiliationOrder",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdAffiliation_AppSemester_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "AppSemester",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdAffiliation_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppStdRegStage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    RegStageId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    RegStageId1 = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    StdRegistrationId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    No = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Date = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
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
                    table.PrimaryKey("PK_AppStdRegStage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdRegStage_AppRegStage_RegStageId1",
                        column: x => x.RegStageId1,
                        principalTable: "AppRegStage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdRegStage_AppStdRegistration_StdRegistrationId",
                        column: x => x.StdRegistrationId,
                        principalTable: "AppStdRegistration",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdChangeCollageDet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StdChangeCollageId = table.Column<Guid>(type: "RAW(16)", nullable: true),
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
                    table.PrimaryKey("PK_AppStdChangeCollageDet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdChangeCollageDet_AppStdChangeCollage_StdChangeCollageId",
                        column: x => x.StdChangeCollageId,
                        principalTable: "AppStdChangeCollage",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdNonSyrianUnivDet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StdNonSyrianUnivId = table.Column<Guid>(type: "RAW(16)", nullable: true),
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
                    table.PrimaryKey("PK_AppStdNonSyrianUnivDet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdNonSyrianUnivDet_AppStdNonSyrianUniv_StdNonSyrianUnivId",
                        column: x => x.StdNonSyrianUnivId,
                        principalTable: "AppStdNonSyrianUniv",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdSymTransformDet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StdSymTransformId = table.Column<Guid>(type: "RAW(16)", nullable: true),
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
                    table.PrimaryKey("PK_AppStdSymTransformDet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdSymTransformDet_AppStdSymTransform_StdSymTransformId",
                        column: x => x.StdSymTransformId,
                        principalTable: "AppStdSymTransform",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdTermination",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TerminationState = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TerminationOrderId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    TerminationOrderId1 = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    No = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Date = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Year = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SemesterId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    PrevAdmissionId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Agent = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AgentNo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AgentDate = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AgentSource = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
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
                    table.PrimaryKey("PK_AppStdTermination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdTermination_AppAdmission_PrevAdmissionId",
                        column: x => x.PrevAdmissionId,
                        principalTable: "AppAdmission",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdTermination_AppSemester_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "AppSemester",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdTermination_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppStdTermination_AppTerminationOrder_TerminationOrderId1",
                        column: x => x.TerminationOrderId1,
                        principalTable: "AppTerminationOrder",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdAbsenceStage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StdAbsenceId = table.Column<Guid>(type: "RAW(16)", nullable: true),
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
                    table.PrimaryKey("PK_AppStdAbsenceStage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdAbsenceStage_AppStdAbsence_StdAbsenceId",
                        column: x => x.StdAbsenceId,
                        principalTable: "AppStdAbsence",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdAffiliationStage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    StdAffiliationId = table.Column<Guid>(type: "RAW(16)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStdAffiliationStage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdAffiliationStage_AppStdAffiliation_StdAffiliationId",
                        column: x => x.StdAffiliationId,
                        principalTable: "AppStdAffiliation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdTerminateStage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    StdTerminationId = table.Column<Guid>(type: "RAW(16)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStdTerminateStage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdTerminateStage_AppStdTermination_StdTerminationId",
                        column: x => x.StdTerminationId,
                        principalTable: "AppStdTermination",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppStdRegistration_RegOrderId1",
                table: "AppStdRegistration",
                column: "RegOrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdRegistration_SemesterId",
                table: "AppStdRegistration",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdAdmission_AdmissionLanguageId",
                table: "AppStdAdmission",
                column: "AdmissionLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdAbsence_AbsenceOrderId1",
                table: "AppStdAbsence",
                column: "AbsenceOrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdAbsence_SemesterFromId",
                table: "AppStdAbsence",
                column: "SemesterFromId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdAbsence_SemesterToId",
                table: "AppStdAbsence",
                column: "SemesterToId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdAbsence_StudentId",
                table: "AppStdAbsence",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdAbsenceStage_StdAbsenceId",
                table: "AppStdAbsenceStage",
                column: "StdAbsenceId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdAffiliation_AffiliationOrderId1",
                table: "AppStdAffiliation",
                column: "AffiliationOrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdAffiliation_SemesterId",
                table: "AppStdAffiliation",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdAffiliation_StudentId",
                table: "AppStdAffiliation",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdAffiliationStage_StdAffiliationId",
                table: "AppStdAffiliationStage",
                column: "StdAffiliationId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdChangeCollage_StudentId",
                table: "AppStdChangeCollage",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdChangeCollageDet_StdChangeCollageId",
                table: "AppStdChangeCollageDet",
                column: "StdChangeCollageId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdInstitute_StudentId",
                table: "AppStdInstitute",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdNonSyrianUniv_StudentId",
                table: "AppStdNonSyrianUniv",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdNonSyrianUnivDet_StdNonSyrianUnivId",
                table: "AppStdNonSyrianUnivDet",
                column: "StdNonSyrianUnivId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdRegStage_RegStageId1",
                table: "AppStdRegStage",
                column: "RegStageId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdRegStage_StdRegistrationId",
                table: "AppStdRegStage",
                column: "StdRegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSymTransform_StudentId",
                table: "AppStdSymTransform",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSymTransformDet_StdSymTransformId",
                table: "AppStdSymTransformDet",
                column: "StdSymTransformId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdTerminateStage_StdTerminationId",
                table: "AppStdTerminateStage",
                column: "StdTerminationId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdTermination_PrevAdmissionId",
                table: "AppStdTermination",
                column: "PrevAdmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdTermination_SemesterId",
                table: "AppStdTermination",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdTermination_StudentId",
                table: "AppStdTermination",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdTermination_TerminationOrderId1",
                table: "AppStdTermination",
                column: "TerminationOrderId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdAdmission_AppLanguage_AdmissionLanguageId",
                table: "AppStdAdmission",
                column: "AdmissionLanguageId",
                principalTable: "AppLanguage",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdRegistration_AppRegOrder_RegOrderId1",
                table: "AppStdRegistration",
                column: "RegOrderId1",
                principalTable: "AppRegOrder",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdRegistration_AppSemester_SemesterId",
                table: "AppStdRegistration",
                column: "SemesterId",
                principalTable: "AppSemester",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppStdAdmission_AppLanguage_AdmissionLanguageId",
                table: "AppStdAdmission");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdRegistration_AppRegOrder_RegOrderId1",
                table: "AppStdRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdRegistration_AppSemester_SemesterId",
                table: "AppStdRegistration");

            migrationBuilder.DropTable(
                name: "AppAbsenceStage");

            migrationBuilder.DropTable(
                name: "AppAffiliationStage");

            migrationBuilder.DropTable(
                name: "AppRegOrder");

            migrationBuilder.DropTable(
                name: "AppStdAbsenceStage");

            migrationBuilder.DropTable(
                name: "AppStdAffiliationStage");

            migrationBuilder.DropTable(
                name: "AppStdChangeCollageDet");

            migrationBuilder.DropTable(
                name: "AppStdInstitute");

            migrationBuilder.DropTable(
                name: "AppStdNonSyrianUnivDet");

            migrationBuilder.DropTable(
                name: "AppStdRegStage");

            migrationBuilder.DropTable(
                name: "AppStdSymTransformDet");

            migrationBuilder.DropTable(
                name: "AppStdTerminateStage");

            migrationBuilder.DropTable(
                name: "AppTerminationStage");

            migrationBuilder.DropTable(
                name: "AppStdAbsence");

            migrationBuilder.DropTable(
                name: "AppStdAffiliation");

            migrationBuilder.DropTable(
                name: "AppStdChangeCollage");

            migrationBuilder.DropTable(
                name: "AppStdNonSyrianUniv");

            migrationBuilder.DropTable(
                name: "AppRegStage");

            migrationBuilder.DropTable(
                name: "AppStdSymTransform");

            migrationBuilder.DropTable(
                name: "AppStdTermination");

            migrationBuilder.DropTable(
                name: "AppAbsenceOrder");

            migrationBuilder.DropTable(
                name: "AppAffiliationOrder");

            migrationBuilder.DropTable(
                name: "AppTerminationOrder");

            migrationBuilder.DropIndex(
                name: "IX_AppStdRegistration_RegOrderId1",
                table: "AppStdRegistration");

            migrationBuilder.DropIndex(
                name: "IX_AppStdRegistration_SemesterId",
                table: "AppStdRegistration");

            migrationBuilder.DropIndex(
                name: "IX_AppStdAdmission_AdmissionLanguageId",
                table: "AppStdAdmission");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "StdPunishmentStages");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "StdPunishmentStages");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "StdPunishmentStages");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "StdPunishmentStages");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "StdPunishmentStages");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "StdPunishmentStages");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "StdPunishmentStages");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "StdPunishmentStages");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "StdPunishmentStages");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AppStdSeqSum");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "AppStdSeqSum");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "AppStdSeqSum");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "AppStdSeqSum");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "AppStdSeqSum");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "AppStdSeqSum");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AppStdSeqSum");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "AppStdSeqSum");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "AppStdSeqSum");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AppStdSeqStudy");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "AppStdSeqStudy");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "AppStdSeqStudy");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "AppStdSeqStudy");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "AppStdSeqStudy");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "AppStdSeqStudy");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AppStdSeqStudy");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "AppStdSeqStudy");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "AppStdSeqStudy");

            migrationBuilder.DropColumn(
                name: "Agent",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "AgentDate",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "AgentNo",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "AgentSource",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "No",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "RegOrderId",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "RegOrderId1",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "RegistrationState",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "SemesterId",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "AppStdRegistration");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AppStdPunishment");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "AppStdPunishment");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "AppStdPunishment");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "AppStdPunishment");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "AppStdPunishment");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "AppStdPunishment");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AppStdPunishment");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "AppStdPunishment");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "AppStdPunishment");

            migrationBuilder.DropColumn(
                name: "PunishmentState",
                table: "AppStdPunishment");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "AppStdLife");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "AppStdLife");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AppStdLife");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AppStdCertificate");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "AppStdCertificate");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "AppStdCertificate");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "AppStdCertificate");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "AppStdCertificate");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "AppStdCertificate");

            migrationBuilder.DropColumn(
                name: "ForeignCert",
                table: "AppStdCertificate");

            migrationBuilder.DropColumn(
                name: "ForeignCertCorrect",
                table: "AppStdCertificate");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AppStdCertificate");

            migrationBuilder.DropColumn(
                name: "IsForeignCertCorrect",
                table: "AppStdCertificate");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "AppStdCertificate");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "AppStdCertificate");

            migrationBuilder.DropColumn(
                name: "No",
                table: "AppStdCertificate");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "AppStdCertificate");

            migrationBuilder.DropColumn(
                name: "TotalMark",
                table: "AppStdCertificate");

            migrationBuilder.DropColumn(
                name: "TotalNet",
                table: "AppStdCertificate");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "AppStdCertificate");

            migrationBuilder.DropColumn(
                name: "AdmissionLanguageId",
                table: "AppStdAdmission");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AppStdAdmission");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "AppStdAdmission");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "AppStdAdmission");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "AppStdAdmission");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "AppStdAdmission");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "AppStdAdmission");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AppStdAdmission");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "AppStdAdmission");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "AppStdAdmission");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AppStdAbolition");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "AppStdAbolition");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "AppStdAbolition");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "AppStdAbolition");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "AppStdAbolition");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "AppStdAbolition");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AppStdAbolition");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "AppStdAbolition");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "AppStdAbolition");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "AppStdAbolition");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "AppStudent",
                newName: "STD_NOTE");

            migrationBuilder.RenameColumn(
                name: "AdmissionType",
                table: "AppStdAdmission",
                newName: "STD_ADM_TYPE");

            migrationBuilder.AddColumn<int>(
                name: "PunishmentReasonId",
                table: "StdPunishmentStages",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "STD_CHOSE_LANG",
                table: "AppStudent",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "STD_SCHOOL_NUM",
                table: "AppStudent",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CompleteCancellation",
                table: "AppStdAbolition",
                type: "NUMBER(1)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StdPunishmentStages_PunishmentReasonId",
                table: "StdPunishmentStages",
                column: "PunishmentReasonId");

            migrationBuilder.AddForeignKey(
                name: "FK_StdPunishmentStages_AppPunishmentReason_PunishmentReasonId",
                table: "StdPunishmentStages",
                column: "PunishmentReasonId",
                principalTable: "AppPunishmentReason",
                principalColumn: "Id");
        }
    }
}
