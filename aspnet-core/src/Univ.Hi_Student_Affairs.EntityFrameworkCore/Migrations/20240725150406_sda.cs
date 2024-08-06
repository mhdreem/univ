using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Univ.Hi_Student_Affairs.Migrations
{
    /// <inheritdoc />
    public partial class sda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppBranch_AppDepartment_DepartmentId",
                table: "AppBranch");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCity_AppCountry_CountryId",
                table: "AppCity");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCollage_AppUnivSection_UnivSectionId",
                table: "AppCollage");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCountry_AppContinent_ContinentId",
                table: "AppCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_AppDepartment_AppCollage_CollageId",
                table: "AppDepartment");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUnivSection_AppUniv_UnivId",
                table: "AppUnivSection");

            migrationBuilder.RenameColumn(
                name: "UnivEncode",
                table: "AppUniv",
                newName: "Barcode");

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppUnivType",
                type: "NVARCHAR2(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "AppUnivType",
                type: "NVARCHAR2(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<int>(
                name: "UnivId",
                table: "AppUnivSection",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppUnivSection",
                type: "NVARCHAR2(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "AppUnivSection",
                type: "NVARCHAR2(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppUniv",
                type: "NVARCHAR2(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "AppUniv",
                type: "NVARCHAR2(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppTypeLicBranch",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ord",
                table: "AppTypeLicBranch",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppTypeLic",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "AppTypeLic",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ord",
                table: "AppTypeLic",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppNationality",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ord",
                table: "AppLanguage",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppIdentifierType",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AppFeeCalcType",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppDepartment",
                type: "NVARCHAR2(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "AppDepartment",
                type: "NVARCHAR2(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<int>(
                name: "CollageId",
                table: "AppDepartment",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppCountry",
                type: "NVARCHAR2(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "AppCountry",
                type: "NVARCHAR2(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<int>(
                name: "ContinentId",
                table: "AppCountry",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppContinent",
                type: "NVARCHAR2(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "AppContinent",
                type: "NVARCHAR2(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<int>(
                name: "UnivSectionId",
                table: "AppCollage",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppCollage",
                type: "NVARCHAR2(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "AppCollage",
                type: "NVARCHAR2(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppClass",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppCity",
                type: "NVARCHAR2(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "AppCity",
                type: "NVARCHAR2(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "AppCity",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppBranch",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "AppBranch",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppBranch_AppDepartment_DepartmentId",
                table: "AppBranch",
                column: "DepartmentId",
                principalTable: "AppDepartment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppCity_AppCountry_CountryId",
                table: "AppCity",
                column: "CountryId",
                principalTable: "AppCountry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppCollage_AppUnivSection_UnivSectionId",
                table: "AppCollage",
                column: "UnivSectionId",
                principalTable: "AppUnivSection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppCountry_AppContinent_ContinentId",
                table: "AppCountry",
                column: "ContinentId",
                principalTable: "AppContinent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppDepartment_AppCollage_CollageId",
                table: "AppDepartment",
                column: "CollageId",
                principalTable: "AppCollage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUnivSection_AppUniv_UnivId",
                table: "AppUnivSection",
                column: "UnivId",
                principalTable: "AppUniv",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppBranch_AppDepartment_DepartmentId",
                table: "AppBranch");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCity_AppCountry_CountryId",
                table: "AppCity");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCollage_AppUnivSection_UnivSectionId",
                table: "AppCollage");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCountry_AppContinent_ContinentId",
                table: "AppCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_AppDepartment_AppCollage_CollageId",
                table: "AppDepartment");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUnivSection_AppUniv_UnivId",
                table: "AppUnivSection");

            migrationBuilder.DropColumn(
                name: "Ord",
                table: "AppTypeLicBranch");

            migrationBuilder.DropColumn(
                name: "Ord",
                table: "AppTypeLic");

            migrationBuilder.DropColumn(
                name: "Ord",
                table: "AppLanguage");

            migrationBuilder.RenameColumn(
                name: "Barcode",
                table: "AppUniv",
                newName: "UnivEncode");

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppUnivType",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "AppUnivType",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "UnivId",
                table: "AppUnivSection",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppUnivSection",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "AppUnivSection",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppUniv",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "AppUniv",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppTypeLicBranch",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppTypeLic",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "AppTypeLic",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppNationality",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppIdentifierType",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AppFeeCalcType",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppDepartment",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "AppDepartment",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "CollageId",
                table: "AppDepartment",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppCountry",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "AppCountry",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "ContinentId",
                table: "AppCountry",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppContinent",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "AppContinent",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "UnivSectionId",
                table: "AppCollage",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppCollage",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "AppCollage",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppClass",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppCity",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "AppCity",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "AppCity",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "AppBranch",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "AppBranch",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AddForeignKey(
                name: "FK_AppBranch_AppDepartment_DepartmentId",
                table: "AppBranch",
                column: "DepartmentId",
                principalTable: "AppDepartment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppCity_AppCountry_CountryId",
                table: "AppCity",
                column: "CountryId",
                principalTable: "AppCountry",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppCollage_AppUnivSection_UnivSectionId",
                table: "AppCollage",
                column: "UnivSectionId",
                principalTable: "AppUnivSection",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppCountry_AppContinent_ContinentId",
                table: "AppCountry",
                column: "ContinentId",
                principalTable: "AppContinent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppDepartment_AppCollage_CollageId",
                table: "AppDepartment",
                column: "CollageId",
                principalTable: "AppCollage",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUnivSection_AppUniv_UnivId",
                table: "AppUnivSection",
                column: "UnivId",
                principalTable: "AppUniv",
                principalColumn: "Id");
        }
    }
}
