using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Univ.Hi_Student_Affairs.Migrations
{
    /// <inheritdoc />
    public partial class AAAA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbpAuditLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    ApplicationName = table.Column<string>(type: "NVARCHAR2(96)", maxLength: 96, nullable: true),
                    UserId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    UserName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    TenantId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    TenantName = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true),
                    ImpersonatorUserId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    ImpersonatorUserName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    ImpersonatorTenantId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    ImpersonatorTenantName = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true),
                    ExecutionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ExecutionDuration = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ClientIpAddress = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true),
                    ClientName = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: true),
                    ClientId = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true),
                    CorrelationId = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true),
                    BrowserInfo = table.Column<string>(type: "NVARCHAR2(512)", maxLength: 512, nullable: true),
                    HttpMethod = table.Column<string>(type: "NVARCHAR2(16)", maxLength: 16, nullable: true),
                    Url = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    Exceptions = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Comments = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    HttpStatusCode = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "NVARCHAR2(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpAuditLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpBackgroundJobs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    JobName = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    JobArgs = table.Column<string>(type: "NCLOB", maxLength: 1048576, nullable: false),
                    TryCount = table.Column<short>(type: "NUMBER(5)", nullable: false, defaultValue: (short)0),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    NextTryTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    LastTryTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    IsAbandoned = table.Column<bool>(type: "NUMBER(1)", nullable: false, defaultValue: false),
                    Priority = table.Column<byte>(type: "NUMBER(3)", nullable: false, defaultValue: (byte)15),
                    ExtraProperties = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "NVARCHAR2(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpBackgroundJobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpClaimTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    Required = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    IsStatic = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    Regex = table.Column<string>(type: "NVARCHAR2(512)", maxLength: 512, nullable: true),
                    RegexDescription = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: true),
                    Description = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    ValueType = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "NVARCHAR2(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpClaimTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpFeatureGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    DisplayName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    ExtraProperties = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpFeatureGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpFeatures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    GroupName = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    ParentName = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: true),
                    DisplayName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    DefaultValue = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    IsVisibleToClients = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    IsAvailableToHost = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    AllowedProviders = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    ValueType = table.Column<string>(type: "NCLOB", maxLength: 2048, nullable: true),
                    ExtraProperties = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpFeatureValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    ProviderName = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true),
                    ProviderKey = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpFeatureValues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpLinkUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    SourceUserId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    SourceTenantId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    TargetUserId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TargetTenantId = table.Column<Guid>(type: "RAW(16)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpLinkUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpOrganizationUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TenantId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    ParentId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    Code = table.Column<string>(type: "NVARCHAR2(95)", maxLength: 95, nullable: false),
                    DisplayName = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    EntityVersion = table.Column<int>(type: "NUMBER(10)", nullable: false),
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
                    table.PrimaryKey("PK_AbpOrganizationUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId",
                        column: x => x.ParentId,
                        principalTable: "AbpOrganizationUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AbpPermissionGrants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TenantId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    Name = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    ProviderName = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: false),
                    ProviderKey = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpPermissionGrants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpPermissionGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    DisplayName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    ExtraProperties = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpPermissionGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpPermissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    GroupName = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    ParentName = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: true),
                    DisplayName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    IsEnabled = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    MultiTenancySide = table.Column<byte>(type: "NUMBER(3)", nullable: false),
                    Providers = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: true),
                    StateCheckers = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    ExtraProperties = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpPermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TenantId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    Name = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    NormalizedName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    IsDefault = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    IsStatic = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    IsPublic = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    EntityVersion = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "NVARCHAR2(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpSecurityLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TenantId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    ApplicationName = table.Column<string>(type: "NVARCHAR2(96)", maxLength: 96, nullable: true),
                    Identity = table.Column<string>(type: "NVARCHAR2(96)", maxLength: 96, nullable: true),
                    Action = table.Column<string>(type: "NVARCHAR2(96)", maxLength: 96, nullable: true),
                    UserId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    UserName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    TenantName = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true),
                    ClientId = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true),
                    CorrelationId = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true),
                    ClientIpAddress = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true),
                    BrowserInfo = table.Column<string>(type: "NVARCHAR2(512)", maxLength: 512, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "NVARCHAR2(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpSecurityLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpSettingDefinitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    DisplayName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR2(512)", maxLength: 512, nullable: true),
                    DefaultValue = table.Column<string>(type: "NVARCHAR2(2000)", maxLength: 2000, nullable: true),
                    IsVisibleToClients = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    Providers = table.Column<string>(type: "NVARCHAR2(1024)", maxLength: 1024, nullable: true),
                    IsInherited = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    IsEncrypted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpSettingDefinitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "NVARCHAR2(2000)", maxLength: 2000, nullable: false),
                    ProviderName = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true),
                    ProviderKey = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpTenants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: false),
                    NormalizedName = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: false),
                    EntityVersion = table.Column<int>(type: "NUMBER(10)", nullable: false),
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
                    table.PrimaryKey("PK_AbpTenants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserDelegations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TenantId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    SourceUserId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TargetUserId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserDelegations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TenantId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    UserName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true),
                    Surname = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: true),
                    Email = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "NUMBER(1)", nullable: false, defaultValue: false),
                    PasswordHash = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    SecurityStamp = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    IsExternal = table.Column<bool>(type: "NUMBER(1)", nullable: false, defaultValue: false),
                    PhoneNumber = table.Column<string>(type: "NVARCHAR2(16)", maxLength: 16, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "NUMBER(1)", nullable: false, defaultValue: false),
                    IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "NUMBER(1)", nullable: false, defaultValue: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TIMESTAMP(7) WITH TIME ZONE", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "NUMBER(1)", nullable: false, defaultValue: false),
                    AccessFailedCount = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ShouldChangePasswordOnNextLogin = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    EntityVersion = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    LastPasswordChangeTime = table.Column<DateTimeOffset>(type: "TIMESTAMP(7) WITH TIME ZONE", nullable: true),
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
                    table.PrimaryKey("PK_AbpUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAbsenceOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    AbsenceType = table.Column<byte>(type: "NUMBER(3)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
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
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    StageState = table.Column<byte>(type: "NUMBER(3)", nullable: false),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAbsenceStage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAdmission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Ministry = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    AdmissionKind = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    FeeCalcType = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NameAr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NameEn = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAdmission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAffiliationOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    AffiliationType = table.Column<byte>(type: "NUMBER(3)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
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
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    StageState = table.Column<byte>(type: "NUMBER(3)", nullable: false),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAffiliationStage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppCivilReg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    CountryId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CityId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NameAr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NameEn = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCivilReg", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NameAr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NameEn = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppCountry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Continent = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NameAr = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCountry", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppDeprivation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Number = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    DeprivationType = table.Column<byte>(type: "NUMBER(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDeprivation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppIdentifierType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NameAr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NameEn = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppIdentifierType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppMilitary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    CityId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NameAr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NameEn = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppMilitary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppPunishmentReason",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
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
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    StageState = table.Column<byte>(type: "NUMBER(3)", nullable: false),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPunishmentStage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRegOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    RegType = table.Column<byte>(type: "NUMBER(3)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
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
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    StageState = table.Column<byte>(type: "NUMBER(3)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRegStage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppSemester",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    GradeNameAr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    GradeNameEn = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NameAr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NameEn = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSemester", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppStdAbolition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    No = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Date = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Result = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PunishmentId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStdAbolition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppStdChangeCollageDet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StdChangeCollageId = table.Column<Guid>(type: "RAW(16)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStdChangeCollageDet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppStdNonSyrianUnivDet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StdNonSyrianUnivId = table.Column<Guid>(type: "RAW(16)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStdNonSyrianUnivDet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppStdSymTransformDet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StdSymTransformId = table.Column<Guid>(type: "RAW(16)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStdSymTransformDet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppTerminationOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TerminationType = table.Column<byte>(type: "NUMBER(3)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
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
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    StageState = table.Column<byte>(type: "NUMBER(3)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTerminationStage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppTypeLic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NameAr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NameEn = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTypeLic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUniv",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    UnivType = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NameAr = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUniv", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpenIddictApplications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    ApplicationType = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: true),
                    ClientId = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: true),
                    ClientSecret = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ClientType = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: true),
                    ConsentType = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: true),
                    DisplayName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DisplayNames = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    JsonWebKeySet = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Permissions = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PostLogoutRedirectUris = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Properties = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    RedirectUris = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Requirements = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Settings = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ClientUri = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    LogoUri = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
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
                    table.PrimaryKey("PK_OpenIddictApplications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpenIddictScopes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Descriptions = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DisplayName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DisplayNames = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Name = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: true),
                    Properties = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Resources = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
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
                    table.PrimaryKey("PK_OpenIddictScopes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpAuditLogActions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TenantId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    AuditLogId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    ServiceName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    MethodName = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: true),
                    Parameters = table.Column<string>(type: "NVARCHAR2(2000)", maxLength: 2000, nullable: true),
                    ExecutionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ExecutionDuration = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpAuditLogActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpAuditLogActions_AbpAuditLogs_AuditLogId",
                        column: x => x.AuditLogId,
                        principalTable: "AbpAuditLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpEntityChanges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    AuditLogId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TenantId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    ChangeTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ChangeType = table.Column<byte>(type: "NUMBER(3)", nullable: false),
                    EntityTenantId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    EntityId = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: true),
                    EntityTypeFullName = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    ExtraProperties = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpEntityChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpEntityChanges_AbpAuditLogs_AuditLogId",
                        column: x => x.AuditLogId,
                        principalTable: "AbpAuditLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpOrganizationUnitRoles",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    OrganizationUnitId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TenantId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "RAW(16)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpOrganizationUnitRoles", x => new { x.OrganizationUnitId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AbpOrganizationUnitRoles_AbpOrganizationUnits_OrganizationUnitId",
                        column: x => x.OrganizationUnitId,
                        principalTable: "AbpOrganizationUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbpOrganizationUnitRoles_AbpRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AbpRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpRoleClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    RoleId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TenantId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    ClaimType = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    ClaimValue = table.Column<string>(type: "NVARCHAR2(1024)", maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpRoleClaims_AbpRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AbpRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpTenantConnectionStrings",
                columns: table => new
                {
                    TenantId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: false),
                    Value = table.Column<string>(type: "NVARCHAR2(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpTenantConnectionStrings", x => new { x.TenantId, x.Name });
                    table.ForeignKey(
                        name: "FK_AbpTenantConnectionStrings_AbpTenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AbpTenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    UserId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TenantId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    ClaimType = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    ClaimValue = table.Column<string>(type: "NVARCHAR2(1024)", maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpUserClaims_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    LoginProvider = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: false),
                    TenantId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    ProviderKey = table.Column<string>(type: "NVARCHAR2(196)", maxLength: 196, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserLogins", x => new { x.UserId, x.LoginProvider });
                    table.ForeignKey(
                        name: "FK_AbpUserLogins_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserOrganizationUnits",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    OrganizationUnitId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TenantId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "RAW(16)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserOrganizationUnits", x => new { x.OrganizationUnitId, x.UserId });
                    table.ForeignKey(
                        name: "FK_AbpUserOrganizationUnits_AbpOrganizationUnits_OrganizationUnitId",
                        column: x => x.OrganizationUnitId,
                        principalTable: "AbpOrganizationUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbpUserOrganizationUnits_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    RoleId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TenantId = table.Column<Guid>(type: "RAW(16)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AbpUserRoles_AbpRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AbpRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbpUserRoles_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    LoginProvider = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    TenantId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    Value = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AbpUserTokens_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppCity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    CountryId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    PhoneCode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NameAr = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCity_AppCountry_CountryId",
                        column: x => x.CountryId,
                        principalTable: "AppCountry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppPunishment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    PunishEffect = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    PunishmentType = table.Column<byte>(type: "NUMBER(3)", nullable: false),
                    DeprivationId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPunishment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppPunishment_AppDeprivation_DeprivationId",
                        column: x => x.DeprivationId,
                        principalTable: "AppDeprivation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppTypeLicBranch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TypeLicId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    NameAr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NameEn = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTypeLicBranch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppTypeLicBranch_AppTypeLic_TypeLicId",
                        column: x => x.TypeLicId,
                        principalTable: "AppTypeLic",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppUnivSection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    UnivId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NameAr = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUnivSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUnivSection_AppUniv_UnivId",
                        column: x => x.UnivId,
                        principalTable: "AppUniv",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpenIddictAuthorizations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Properties = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Scopes = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Status = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: true),
                    Subject = table.Column<string>(type: "NVARCHAR2(400)", maxLength: 400, nullable: true),
                    Type = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: true),
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
                    table.PrimaryKey("PK_OpenIddictAuthorizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpenIddictAuthorizations_OpenIddictApplications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "OpenIddictApplications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AbpEntityPropertyChanges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TenantId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    EntityChangeId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    NewValue = table.Column<string>(type: "NVARCHAR2(512)", maxLength: 512, nullable: true),
                    OriginalValue = table.Column<string>(type: "NVARCHAR2(512)", maxLength: 512, nullable: true),
                    PropertyName = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    PropertyTypeFullName = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpEntityPropertyChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId",
                        column: x => x.EntityChangeId,
                        principalTable: "AbpEntityChanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppCollage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    UnivSectionId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DeanAr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DeanEn = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NumYear = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Degree = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DegreeNameAr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DegreeNameEn = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ColType = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ColClassification = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NameAr = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCollage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCollage_AppUnivSection_UnivSectionId",
                        column: x => x.UnivSectionId,
                        principalTable: "AppUnivSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpenIddictTokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    AuthorizationId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Payload = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Properties = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    RedemptionDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    ReferenceId = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: true),
                    Status = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: true),
                    Subject = table.Column<string>(type: "NVARCHAR2(400)", maxLength: 400, nullable: true),
                    Type = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: true),
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
                    table.PrimaryKey("PK_OpenIddictTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpenIddictTokens_OpenIddictApplications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "OpenIddictApplications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OpenIddictTokens_OpenIddictAuthorizations_AuthorizationId",
                        column: x => x.AuthorizationId,
                        principalTable: "OpenIddictAuthorizations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppDepartment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DegreeNameAr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DegreeNameEn = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CollageId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NameAr = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: false),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDepartment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppDepartment_AppCollage_CollageId",
                        column: x => x.CollageId,
                        principalTable: "AppCollage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudyPlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    CollageId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    FireDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyPlan_AppCollage_CollageId",
                        column: x => x.CollageId,
                        principalTable: "AppCollage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppBranch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DepartmentId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NameAr = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NameEn = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBranch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppBranch_AppDepartment_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "AppDepartment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppStudent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StdNo_StdMinistryId = table.Column<decimal>(type: "NUMBER(20)", nullable: false),
                    StdNo_StdCollageId = table.Column<decimal>(type: "NUMBER(20)", nullable: false),
                    StdNo_ExamCollageId = table.Column<decimal>(type: "NUMBER(20)", nullable: true),
                    studnetProfile_NationalityId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    studnetProfile_Nationality = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    studnetProfile_CountryId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    studnetProfile_FirstNameAR = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: false),
                    studnetProfile_FirstNameEn = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    studnetProfile_LastNameAr = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: false),
                    studnetProfile_LastNameEn = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    studnetProfile_FatherNameAr = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: false),
                    studnetProfile_FatherNameEn = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    studnetProfile_MotherNameAr = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: false),
                    studnetProfile_MotherNameEn = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    studnetProfile_YearBirth = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    studnetProfile_MonthBirth = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    studnetProfile_DayBirth = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    studnetProfile_Jender = table.Column<byte>(type: "NUMBER(3)", nullable: true),
                    studnetProfile_IdentifierTypeId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    studnetProfile_Identifier = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    studnetProfile_Data = table.Column<byte[]>(type: "RAW(2000)", nullable: true),
                    UniveInfo_Year = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    UniveInfo_AdmissionId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    UniveInfo_UnivId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    UniveInfo_UnivSectionId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    UniveInfo_CollageId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    UniveInfo_DepartmentId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UniveInfo_BranchId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UniveInfo_ClassId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UniveInfo_SemesterId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Note = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    IsForeign = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    IsArab = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    Status = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    StudyPlanId = table.Column<int>(type: "NUMBER(10)", nullable: true),
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
                        name: "FK_AppStudent_AppAdmission_UniveInfo_AdmissionId",
                        column: x => x.UniveInfo_AdmissionId,
                        principalTable: "AppAdmission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppStudent_AppBranch_UniveInfo_BranchId",
                        column: x => x.UniveInfo_BranchId,
                        principalTable: "AppBranch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppClass_UniveInfo_ClassId",
                        column: x => x.UniveInfo_ClassId,
                        principalTable: "AppClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppCollage_UniveInfo_CollageId",
                        column: x => x.UniveInfo_CollageId,
                        principalTable: "AppCollage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppStudent_AppCountry_studnetProfile_CountryId",
                        column: x => x.studnetProfile_CountryId,
                        principalTable: "AppCountry",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppDepartment_UniveInfo_DepartmentId",
                        column: x => x.UniveInfo_DepartmentId,
                        principalTable: "AppDepartment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppIdentifierType_studnetProfile_IdentifierTypeId",
                        column: x => x.studnetProfile_IdentifierTypeId,
                        principalTable: "AppIdentifierType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppSemester_UniveInfo_SemesterId",
                        column: x => x.UniveInfo_SemesterId,
                        principalTable: "AppSemester",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStudent_AppUnivSection_UniveInfo_UnivSectionId",
                        column: x => x.UniveInfo_UnivSectionId,
                        principalTable: "AppUnivSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppStudent_AppUniv_UniveInfo_UnivId",
                        column: x => x.UniveInfo_UnivId,
                        principalTable: "AppUniv",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppStdAbsence",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    AbsenceState = table.Column<byte>(type: "NUMBER(3)", nullable: true),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: true),
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
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdAdmission",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    AdmissionID = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Acceptance = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    No = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: true),
                    TotalMarkNet = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    TotalMark = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    AdmissionLanguage = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Language = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SubectMark = table.Column<long>(type: "NUMBER(10)", nullable: true),
                    LanguageMark = table.Column<int>(type: "NUMBER(10)", nullable: true),
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
                    table.PrimaryKey("PK_AppStdAdmission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdAdmission_AppAdmission_AdmissionID",
                        column: x => x.AdmissionID,
                        principalTable: "AppAdmission",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdAdmission_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdAffiliation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    AffiliationState = table.Column<byte>(type: "NUMBER(3)", nullable: true),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: true),
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
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdCertificate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    CountryId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CityId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    TypeLicId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    TypeLicBranchId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Year = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    ForeignCert = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    IsForeignCertCorrect = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    ForeignCertCorrect = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    No = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Note = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TotalMark = table.Column<long>(type: "NUMBER(10)", nullable: true),
                    TotalNet = table.Column<long>(type: "NUMBER(10)", nullable: true),
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
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdChangeCollage",
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
                    table.PrimaryKey("PK_AppStdChangeCollage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdChangeCollage_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id");
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
                name: "AppStdLife",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Operation = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    RefrenceID = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    Date = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Time = table.Column<string>(type: "NVARCHAR2(48)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: false),
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
                    table.PrimaryKey("PK_AppStdLife", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdLife_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdNonSyrianUniv",
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
                    table.PrimaryKey("PK_AppStdNonSyrianUniv", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdNonSyrianUniv_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdPunishment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    PunishmentState = table.Column<byte>(type: "NUMBER(3)", nullable: true),
                    PunishmentId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    StdAbolitionId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    PunishmentReasonId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Year = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    ClassId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SemesterId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    YearEnd = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SemesterEndId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Note = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Fixed = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    Outside = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    DoublePunishment = table.Column<bool>(type: "NUMBER(1)", nullable: true),
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
                    table.PrimaryKey("PK_AppStdPunishment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdPunishment_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdRegistration",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    RegistrationState = table.Column<byte>(type: "NUMBER(3)", nullable: true),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    RegOrderId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    RegOrderId1 = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    No = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Date = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Year = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SemesterId = table.Column<int>(type: "NUMBER(10)", nullable: true),
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
                    table.PrimaryKey("PK_AppStdRegistration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdRegistration_AppRegOrder_RegOrderId1",
                        column: x => x.RegOrderId1,
                        principalTable: "AppRegOrder",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdRegistration_AppSemester_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "AppSemester",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdRegistration_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStdSeqSum",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    UniveInfo_Year = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    UniveInfo_AdmissionId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    UniveInfo_UnivId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    UniveInfo_UnivSectionId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    UniveInfo_CollageId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    UniveInfo_DepartmentId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UniveInfo_BranchId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UniveInfo_ClassId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UniveInfo_SemesterId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Status = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SeqResultId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SeqResult = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SeqStatusId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SeqStatus = table.Column<int>(type: "NUMBER(10)", nullable: true),
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
                    table.PrimaryKey("PK_AppStdSeqSum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdSeqSum_AppAdmission_UniveInfo_AdmissionId",
                        column: x => x.UniveInfo_AdmissionId,
                        principalTable: "AppAdmission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppStdSeqSum_AppBranch_UniveInfo_BranchId",
                        column: x => x.UniveInfo_BranchId,
                        principalTable: "AppBranch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqSum_AppClass_UniveInfo_ClassId",
                        column: x => x.UniveInfo_ClassId,
                        principalTable: "AppClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqSum_AppCollage_UniveInfo_CollageId",
                        column: x => x.UniveInfo_CollageId,
                        principalTable: "AppCollage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppStdSeqSum_AppDepartment_UniveInfo_DepartmentId",
                        column: x => x.UniveInfo_DepartmentId,
                        principalTable: "AppDepartment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqSum_AppSemester_UniveInfo_SemesterId",
                        column: x => x.UniveInfo_SemesterId,
                        principalTable: "AppSemester",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqSum_AppStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AppStudent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqSum_AppUnivSection_UniveInfo_UnivSectionId",
                        column: x => x.UniveInfo_UnivSectionId,
                        principalTable: "AppUnivSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppStdSeqSum_AppUniv_UniveInfo_UnivId",
                        column: x => x.UniveInfo_UnivId,
                        principalTable: "AppUniv",
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
                name: "AppStdTermination",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TerminationState = table.Column<byte>(type: "NUMBER(3)", nullable: true),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: true),
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
                        principalColumn: "Id");
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
                    StdAbsenceId = table.Column<Guid>(type: "RAW(16)", nullable: true)
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
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
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
                name: "StdPunishmentStages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    PunishmentStageId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    StdPunishmentId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    PunishmentId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    No = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Date = table.Column<DateTime>(type: "DATE", nullable: true),
                    Note = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StdPunishmentStages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StdPunishmentStages_AppStdPunishment_StdPunishmentId",
                        column: x => x.StdPunishmentId,
                        principalTable: "AppStdPunishment",
                        principalColumn: "Id");
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
                    Date = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
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
                name: "AppStdSeqStudy",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StudentId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    UniveInfo_Year = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UniveInfo_AdmissionId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UniveInfo_UnivId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UniveInfo_UnivSectionId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UniveInfo_CollageId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UniveInfo_DepartmentId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UniveInfo_BranchId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UniveInfo_ClassId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UniveInfo_SemesterId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Status = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SeqResultId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SeqResult = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    TakeSemesterExam = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    Note = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    IsSemesterCounted = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    SEQ_CANCEL_CHEK = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    StdSeqSumId = table.Column<Guid>(type: "RAW(16)", nullable: true),
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
                    table.PrimaryKey("PK_AppStdSeqStudy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStdSeqStudy_AppAdmission_UniveInfo_AdmissionId",
                        column: x => x.UniveInfo_AdmissionId,
                        principalTable: "AppAdmission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppStdSeqStudy_AppBranch_UniveInfo_BranchId",
                        column: x => x.UniveInfo_BranchId,
                        principalTable: "AppBranch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqStudy_AppClass_UniveInfo_ClassId",
                        column: x => x.UniveInfo_ClassId,
                        principalTable: "AppClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqStudy_AppCollage_UniveInfo_CollageId",
                        column: x => x.UniveInfo_CollageId,
                        principalTable: "AppCollage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppStdSeqStudy_AppDepartment_UniveInfo_DepartmentId",
                        column: x => x.UniveInfo_DepartmentId,
                        principalTable: "AppDepartment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqStudy_AppSemester_UniveInfo_SemesterId",
                        column: x => x.UniveInfo_SemesterId,
                        principalTable: "AppSemester",
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStdSeqStudy_AppUnivSection_UniveInfo_UnivSectionId",
                        column: x => x.UniveInfo_UnivSectionId,
                        principalTable: "AppUnivSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppStdSeqStudy_AppUniv_UniveInfo_UnivId",
                        column: x => x.UniveInfo_UnivId,
                        principalTable: "AppUniv",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_AbpAuditLogActions_AuditLogId",
                table: "AbpAuditLogActions",
                column: "AuditLogId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogActions_TenantId_ServiceName_MethodName_ExecutionTime",
                table: "AbpAuditLogActions",
                columns: new[] { "TenantId", "ServiceName", "MethodName", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogs_TenantId_ExecutionTime",
                table: "AbpAuditLogs",
                columns: new[] { "TenantId", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogs_TenantId_UserId_ExecutionTime",
                table: "AbpAuditLogs",
                columns: new[] { "TenantId", "UserId", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime",
                table: "AbpBackgroundJobs",
                columns: new[] { "IsAbandoned", "NextTryTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityChanges_AuditLogId",
                table: "AbpEntityChanges",
                column: "AuditLogId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityChanges_TenantId_EntityTypeFullName_EntityId",
                table: "AbpEntityChanges",
                columns: new[] { "TenantId", "EntityTypeFullName", "EntityId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityPropertyChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges",
                column: "EntityChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpFeatureGroups_Name",
                table: "AbpFeatureGroups",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpFeatures_GroupName",
                table: "AbpFeatures",
                column: "GroupName");

            migrationBuilder.CreateIndex(
                name: "IX_AbpFeatures_Name",
                table: "AbpFeatures",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpFeatureValues_Name_ProviderName_ProviderKey",
                table: "AbpFeatureValues",
                columns: new[] { "Name", "ProviderName", "ProviderKey" },
                unique: true,
                filter: "\"ProviderName\" IS NOT NULL AND \"ProviderKey\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AbpLinkUsers_SourceUserId_SourceTenantId_TargetUserId_TargetTenantId",
                table: "AbpLinkUsers",
                columns: new[] { "SourceUserId", "SourceTenantId", "TargetUserId", "TargetTenantId" },
                unique: true,
                filter: "\"SourceTenantId\" IS NOT NULL AND \"TargetTenantId\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AbpOrganizationUnitRoles_RoleId_OrganizationUnitId",
                table: "AbpOrganizationUnitRoles",
                columns: new[] { "RoleId", "OrganizationUnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpOrganizationUnits_Code",
                table: "AbpOrganizationUnits",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AbpOrganizationUnits_ParentId",
                table: "AbpOrganizationUnits",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpPermissionGrants_TenantId_Name_ProviderName_ProviderKey",
                table: "AbpPermissionGrants",
                columns: new[] { "TenantId", "Name", "ProviderName", "ProviderKey" },
                unique: true,
                filter: "\"TenantId\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AbpPermissionGroups_Name",
                table: "AbpPermissionGroups",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpPermissions_GroupName",
                table: "AbpPermissions",
                column: "GroupName");

            migrationBuilder.CreateIndex(
                name: "IX_AbpPermissions_Name",
                table: "AbpPermissions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpRoleClaims_RoleId",
                table: "AbpRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpRoles_NormalizedName",
                table: "AbpRoles",
                column: "NormalizedName");

            migrationBuilder.CreateIndex(
                name: "IX_AbpSecurityLogs_TenantId_Action",
                table: "AbpSecurityLogs",
                columns: new[] { "TenantId", "Action" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpSecurityLogs_TenantId_ApplicationName",
                table: "AbpSecurityLogs",
                columns: new[] { "TenantId", "ApplicationName" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpSecurityLogs_TenantId_Identity",
                table: "AbpSecurityLogs",
                columns: new[] { "TenantId", "Identity" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpSecurityLogs_TenantId_UserId",
                table: "AbpSecurityLogs",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpSettingDefinitions_Name",
                table: "AbpSettingDefinitions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpSettings_Name_ProviderName_ProviderKey",
                table: "AbpSettings",
                columns: new[] { "Name", "ProviderName", "ProviderKey" },
                unique: true,
                filter: "\"ProviderName\" IS NOT NULL AND \"ProviderKey\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenants_Name",
                table: "AbpTenants",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenants_NormalizedName",
                table: "AbpTenants",
                column: "NormalizedName");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserClaims_UserId",
                table: "AbpUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserLogins_LoginProvider_ProviderKey",
                table: "AbpUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserOrganizationUnits_UserId_OrganizationUnitId",
                table: "AbpUserOrganizationUnits",
                columns: new[] { "UserId", "OrganizationUnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserRoles_RoleId_UserId",
                table: "AbpUserRoles",
                columns: new[] { "RoleId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_Email",
                table: "AbpUsers",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_NormalizedEmail",
                table: "AbpUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_NormalizedUserName",
                table: "AbpUsers",
                column: "NormalizedUserName");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_UserName",
                table: "AbpUsers",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_AppBranch_DepartmentId",
                table: "AppBranch",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCity_CountryId",
                table: "AppCity",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCollage_UnivSectionId",
                table: "AppCollage",
                column: "UnivSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppDepartment_CollageId",
                table: "AppDepartment",
                column: "CollageId");

            migrationBuilder.CreateIndex(
                name: "IX_AppPunishment_DeprivationId",
                table: "AppPunishment",
                column: "DeprivationId");

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
                name: "IX_AppStdAdmission_AdmissionID",
                table: "AppStdAdmission",
                column: "AdmissionID");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdAdmission_StudentId",
                table: "AppStdAdmission",
                column: "StudentId");

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
                name: "IX_AppStdChangeCollage_StudentId",
                table: "AppStdChangeCollage",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdInstitute_StudentId",
                table: "AppStdInstitute",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdLife_StudentId",
                table: "AppStdLife",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdNonSyrianUniv_StudentId",
                table: "AppStdNonSyrianUniv",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdPunishment_StudentId",
                table: "AppStdPunishment",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdRegistration_RegOrderId1",
                table: "AppStdRegistration",
                column: "RegOrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdRegistration_SemesterId",
                table: "AppStdRegistration",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdRegistration_StudentId",
                table: "AppStdRegistration",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdRegStage_RegStageId1",
                table: "AppStdRegStage",
                column: "RegStageId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdRegStage_StdRegistrationId",
                table: "AppStdRegStage",
                column: "StdRegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_StdSeqSumId",
                table: "AppStdSeqStudy",
                column: "StdSeqSumId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_StudentId",
                table: "AppStdSeqStudy",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_UniveInfo_AdmissionId",
                table: "AppStdSeqStudy",
                column: "UniveInfo_AdmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_UniveInfo_BranchId",
                table: "AppStdSeqStudy",
                column: "UniveInfo_BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_UniveInfo_ClassId",
                table: "AppStdSeqStudy",
                column: "UniveInfo_ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_UniveInfo_CollageId",
                table: "AppStdSeqStudy",
                column: "UniveInfo_CollageId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_UniveInfo_DepartmentId",
                table: "AppStdSeqStudy",
                column: "UniveInfo_DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_UniveInfo_SemesterId",
                table: "AppStdSeqStudy",
                column: "UniveInfo_SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_UniveInfo_UnivId",
                table: "AppStdSeqStudy",
                column: "UniveInfo_UnivId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqStudy_UniveInfo_UnivSectionId",
                table: "AppStdSeqStudy",
                column: "UniveInfo_UnivSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_StudentId",
                table: "AppStdSeqSum",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_UniveInfo_AdmissionId",
                table: "AppStdSeqSum",
                column: "UniveInfo_AdmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_UniveInfo_BranchId",
                table: "AppStdSeqSum",
                column: "UniveInfo_BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_UniveInfo_ClassId",
                table: "AppStdSeqSum",
                column: "UniveInfo_ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_UniveInfo_CollageId",
                table: "AppStdSeqSum",
                column: "UniveInfo_CollageId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_UniveInfo_DepartmentId",
                table: "AppStdSeqSum",
                column: "UniveInfo_DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_UniveInfo_SemesterId",
                table: "AppStdSeqSum",
                column: "UniveInfo_SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_UniveInfo_UnivId",
                table: "AppStdSeqSum",
                column: "UniveInfo_UnivId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_UniveInfo_UnivSectionId",
                table: "AppStdSeqSum",
                column: "UniveInfo_UnivSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSymTransform_StudentId",
                table: "AppStdSymTransform",
                column: "StudentId");

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

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_studnetProfile_CountryId",
                table: "AppStudent",
                column: "studnetProfile_CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_studnetProfile_IdentifierTypeId",
                table: "AppStudent",
                column: "studnetProfile_IdentifierTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_UniveInfo_AdmissionId",
                table: "AppStudent",
                column: "UniveInfo_AdmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_UniveInfo_BranchId",
                table: "AppStudent",
                column: "UniveInfo_BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_UniveInfo_ClassId",
                table: "AppStudent",
                column: "UniveInfo_ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_UniveInfo_CollageId",
                table: "AppStudent",
                column: "UniveInfo_CollageId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_UniveInfo_DepartmentId",
                table: "AppStudent",
                column: "UniveInfo_DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_UniveInfo_SemesterId",
                table: "AppStudent",
                column: "UniveInfo_SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_UniveInfo_UnivId",
                table: "AppStudent",
                column: "UniveInfo_UnivId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStudent_UniveInfo_UnivSectionId",
                table: "AppStudent",
                column: "UniveInfo_UnivSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppTypeLicBranch_TypeLicId",
                table: "AppTypeLicBranch",
                column: "TypeLicId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUnivSection_UnivId",
                table: "AppUnivSection",
                column: "UnivId");

            migrationBuilder.CreateIndex(
                name: "IX_OpenIddictApplications_ClientId",
                table: "OpenIddictApplications",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_OpenIddictAuthorizations_ApplicationId_Status_Subject_Type",
                table: "OpenIddictAuthorizations",
                columns: new[] { "ApplicationId", "Status", "Subject", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_OpenIddictScopes_Name",
                table: "OpenIddictScopes",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_OpenIddictTokens_ApplicationId_Status_Subject_Type",
                table: "OpenIddictTokens",
                columns: new[] { "ApplicationId", "Status", "Subject", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_OpenIddictTokens_AuthorizationId",
                table: "OpenIddictTokens",
                column: "AuthorizationId");

            migrationBuilder.CreateIndex(
                name: "IX_OpenIddictTokens_ReferenceId",
                table: "OpenIddictTokens",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_StdPunishmentStages_StdPunishmentId",
                table: "StdPunishmentStages",
                column: "StdPunishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyPlan_CollageId",
                table: "StudyPlan",
                column: "CollageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbpAuditLogActions");

            migrationBuilder.DropTable(
                name: "AbpBackgroundJobs");

            migrationBuilder.DropTable(
                name: "AbpClaimTypes");

            migrationBuilder.DropTable(
                name: "AbpEntityPropertyChanges");

            migrationBuilder.DropTable(
                name: "AbpFeatureGroups");

            migrationBuilder.DropTable(
                name: "AbpFeatures");

            migrationBuilder.DropTable(
                name: "AbpFeatureValues");

            migrationBuilder.DropTable(
                name: "AbpLinkUsers");

            migrationBuilder.DropTable(
                name: "AbpOrganizationUnitRoles");

            migrationBuilder.DropTable(
                name: "AbpPermissionGrants");

            migrationBuilder.DropTable(
                name: "AbpPermissionGroups");

            migrationBuilder.DropTable(
                name: "AbpPermissions");

            migrationBuilder.DropTable(
                name: "AbpRoleClaims");

            migrationBuilder.DropTable(
                name: "AbpSecurityLogs");

            migrationBuilder.DropTable(
                name: "AbpSettingDefinitions");

            migrationBuilder.DropTable(
                name: "AbpSettings");

            migrationBuilder.DropTable(
                name: "AbpTenantConnectionStrings");

            migrationBuilder.DropTable(
                name: "AbpUserClaims");

            migrationBuilder.DropTable(
                name: "AbpUserDelegations");

            migrationBuilder.DropTable(
                name: "AbpUserLogins");

            migrationBuilder.DropTable(
                name: "AbpUserOrganizationUnits");

            migrationBuilder.DropTable(
                name: "AbpUserRoles");

            migrationBuilder.DropTable(
                name: "AbpUserTokens");

            migrationBuilder.DropTable(
                name: "AppAbsenceStage");

            migrationBuilder.DropTable(
                name: "AppAffiliationStage");

            migrationBuilder.DropTable(
                name: "AppCivilReg");

            migrationBuilder.DropTable(
                name: "AppMilitary");

            migrationBuilder.DropTable(
                name: "AppPunishment");

            migrationBuilder.DropTable(
                name: "AppPunishmentReason");

            migrationBuilder.DropTable(
                name: "AppPunishmentStage");

            migrationBuilder.DropTable(
                name: "AppStdAbolition");

            migrationBuilder.DropTable(
                name: "AppStdAbsenceStage");

            migrationBuilder.DropTable(
                name: "AppStdAdmission");

            migrationBuilder.DropTable(
                name: "AppStdAffiliationStage");

            migrationBuilder.DropTable(
                name: "AppStdCertificate");

            migrationBuilder.DropTable(
                name: "AppStdChangeCollage");

            migrationBuilder.DropTable(
                name: "AppStdChangeCollageDet");

            migrationBuilder.DropTable(
                name: "AppStdInstitute");

            migrationBuilder.DropTable(
                name: "AppStdLife");

            migrationBuilder.DropTable(
                name: "AppStdNonSyrianUniv");

            migrationBuilder.DropTable(
                name: "AppStdNonSyrianUnivDet");

            migrationBuilder.DropTable(
                name: "AppStdRegStage");

            migrationBuilder.DropTable(
                name: "AppStdSeqStudy");

            migrationBuilder.DropTable(
                name: "AppStdSymTransform");

            migrationBuilder.DropTable(
                name: "AppStdSymTransformDet");

            migrationBuilder.DropTable(
                name: "AppStdTerminateStage");

            migrationBuilder.DropTable(
                name: "AppTerminationStage");

            migrationBuilder.DropTable(
                name: "AppTypeLicBranch");

            migrationBuilder.DropTable(
                name: "OpenIddictScopes");

            migrationBuilder.DropTable(
                name: "OpenIddictTokens");

            migrationBuilder.DropTable(
                name: "StdPunishmentStages");

            migrationBuilder.DropTable(
                name: "StudyPlan");

            migrationBuilder.DropTable(
                name: "AbpEntityChanges");

            migrationBuilder.DropTable(
                name: "AbpTenants");

            migrationBuilder.DropTable(
                name: "AbpOrganizationUnits");

            migrationBuilder.DropTable(
                name: "AbpRoles");

            migrationBuilder.DropTable(
                name: "AbpUsers");

            migrationBuilder.DropTable(
                name: "AppDeprivation");

            migrationBuilder.DropTable(
                name: "AppStdAbsence");

            migrationBuilder.DropTable(
                name: "AppStdAffiliation");

            migrationBuilder.DropTable(
                name: "AppCity");

            migrationBuilder.DropTable(
                name: "AppRegStage");

            migrationBuilder.DropTable(
                name: "AppStdRegistration");

            migrationBuilder.DropTable(
                name: "AppStdSeqSum");

            migrationBuilder.DropTable(
                name: "AppStdTermination");

            migrationBuilder.DropTable(
                name: "AppTypeLic");

            migrationBuilder.DropTable(
                name: "OpenIddictAuthorizations");

            migrationBuilder.DropTable(
                name: "AppStdPunishment");

            migrationBuilder.DropTable(
                name: "AbpAuditLogs");

            migrationBuilder.DropTable(
                name: "AppAbsenceOrder");

            migrationBuilder.DropTable(
                name: "AppAffiliationOrder");

            migrationBuilder.DropTable(
                name: "AppRegOrder");

            migrationBuilder.DropTable(
                name: "AppTerminationOrder");

            migrationBuilder.DropTable(
                name: "OpenIddictApplications");

            migrationBuilder.DropTable(
                name: "AppStudent");

            migrationBuilder.DropTable(
                name: "AppAdmission");

            migrationBuilder.DropTable(
                name: "AppBranch");

            migrationBuilder.DropTable(
                name: "AppClass");

            migrationBuilder.DropTable(
                name: "AppCountry");

            migrationBuilder.DropTable(
                name: "AppIdentifierType");

            migrationBuilder.DropTable(
                name: "AppSemester");

            migrationBuilder.DropTable(
                name: "AppDepartment");

            migrationBuilder.DropTable(
                name: "AppCollage");

            migrationBuilder.DropTable(
                name: "AppUnivSection");

            migrationBuilder.DropTable(
                name: "AppUniv");
        }
    }
}
