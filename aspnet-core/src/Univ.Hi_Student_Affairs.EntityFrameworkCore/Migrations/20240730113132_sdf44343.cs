using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Univ.Hi_Student_Affairs.Migrations
{
    /// <inheritdoc />
    public partial class sdf44343 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppPunishment_AppPunishType_PunishTypeId",
                table: "AppPunishment");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdLife_Operation_OperationId",
                table: "AppStdLife");

            migrationBuilder.DropTable(
                name: "AppPunishEffect");

            migrationBuilder.DropTable(
                name: "AppPunishType");

            migrationBuilder.DropIndex(
                name: "IX_AppPunishment_PunishTypeId",
                table: "AppPunishment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Operation",
                table: "Operation");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AppSubExamStatus");

            migrationBuilder.DropColumn(
                name: "isFinal",
                table: "AppRegStage");

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "AppMilitary");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "AppDeprivation");

            migrationBuilder.RenameTable(
                name: "Operation",
                newName: "AppOperation");

            migrationBuilder.RenameColumn(
                name: "PunishTypeId",
                table: "AppPunishment",
                newName: "PunishmentType");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "AppMilitary",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AppTerminationStage",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ord",
                table: "AppTerminationStage",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StageState",
                table: "AppTerminationStage",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AppTerminationOrder",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ord",
                table: "AppTerminationOrder",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TerminationType",
                table: "AppTerminationOrder",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "AppSubExamStatus",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "AppSubExamStatus",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AppRegStage",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ord",
                table: "AppRegStage",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StageState",
                table: "AppRegStage",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AppRegOrder",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ord",
                table: "AppRegOrder",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegType",
                table: "AppRegOrder",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ord",
                table: "AppPunishmentStage",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StageState",
                table: "AppPunishmentStage",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PunishEffect",
                table: "AppPunishment",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "NUMBER(1)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeprivationType",
                table: "AppDeprivation",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "AppDegree",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "AppDegree",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ord",
                table: "AppDegree",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AppAffiliationStage",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ord",
                table: "AppAffiliationStage",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StageState",
                table: "AppAffiliationStage",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AffiliationType",
                table: "AppAffiliationOrder",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AppAffiliationOrder",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ord",
                table: "AppAffiliationOrder",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AppAbsenceStage",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ord",
                table: "AppAbsenceStage",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StageState",
                table: "AppAbsenceStage",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AbsenceType",
                table: "AppAbsenceOrder",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AppAbsenceOrder",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ord",
                table: "AppAbsenceOrder",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppOperation",
                table: "AppOperation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdLife_AppOperation_OperationId",
                table: "AppStdLife",
                column: "OperationId",
                principalTable: "AppOperation",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppStdLife_AppOperation_OperationId",
                table: "AppStdLife");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppOperation",
                table: "AppOperation");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AppTerminationStage");

            migrationBuilder.DropColumn(
                name: "Ord",
                table: "AppTerminationStage");

            migrationBuilder.DropColumn(
                name: "StageState",
                table: "AppTerminationStage");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AppTerminationOrder");

            migrationBuilder.DropColumn(
                name: "Ord",
                table: "AppTerminationOrder");

            migrationBuilder.DropColumn(
                name: "TerminationType",
                table: "AppTerminationOrder");

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "AppSubExamStatus");

            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "AppSubExamStatus");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AppRegStage");

            migrationBuilder.DropColumn(
                name: "Ord",
                table: "AppRegStage");

            migrationBuilder.DropColumn(
                name: "StageState",
                table: "AppRegStage");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AppRegOrder");

            migrationBuilder.DropColumn(
                name: "Ord",
                table: "AppRegOrder");

            migrationBuilder.DropColumn(
                name: "RegType",
                table: "AppRegOrder");

            migrationBuilder.DropColumn(
                name: "Ord",
                table: "AppPunishmentStage");

            migrationBuilder.DropColumn(
                name: "StageState",
                table: "AppPunishmentStage");

            migrationBuilder.DropColumn(
                name: "DeprivationType",
                table: "AppDeprivation");

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "AppDegree");

            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "AppDegree");

            migrationBuilder.DropColumn(
                name: "Ord",
                table: "AppDegree");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AppAffiliationStage");

            migrationBuilder.DropColumn(
                name: "Ord",
                table: "AppAffiliationStage");

            migrationBuilder.DropColumn(
                name: "StageState",
                table: "AppAffiliationStage");

            migrationBuilder.DropColumn(
                name: "AffiliationType",
                table: "AppAffiliationOrder");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AppAffiliationOrder");

            migrationBuilder.DropColumn(
                name: "Ord",
                table: "AppAffiliationOrder");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AppAbsenceStage");

            migrationBuilder.DropColumn(
                name: "Ord",
                table: "AppAbsenceStage");

            migrationBuilder.DropColumn(
                name: "StageState",
                table: "AppAbsenceStage");

            migrationBuilder.DropColumn(
                name: "AbsenceType",
                table: "AppAbsenceOrder");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AppAbsenceOrder");

            migrationBuilder.DropColumn(
                name: "Ord",
                table: "AppAbsenceOrder");

            migrationBuilder.RenameTable(
                name: "AppOperation",
                newName: "Operation");

            migrationBuilder.RenameColumn(
                name: "PunishmentType",
                table: "AppPunishment",
                newName: "PunishTypeId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AppMilitary",
                newName: "NameEn");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AppSubExamStatus",
                type: "NVARCHAR2(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isFinal",
                table: "AppRegStage",
                type: "NUMBER(1)",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "PunishEffect",
                table: "AppPunishment",
                type: "NUMBER(1)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "AppMilitary",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "AppDeprivation",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Operation",
                table: "Operation",
                column: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_AppPunishment_PunishTypeId",
                table: "AppPunishment",
                column: "PunishTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppPunishment_AppPunishType_PunishTypeId",
                table: "AppPunishment",
                column: "PunishTypeId",
                principalTable: "AppPunishType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdLife_Operation_OperationId",
                table: "AppStdLife",
                column: "OperationId",
                principalTable: "Operation",
                principalColumn: "Id");
        }
    }
}
