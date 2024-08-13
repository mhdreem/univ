using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Univ.Hi_Student_Affairs.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "studnetProfile_MotherNameEn",
                table: "AppStudent",
                newName: "MotherNameEn");

            migrationBuilder.RenameColumn(
                name: "studnetProfile_LastNameEn",
                table: "AppStudent",
                newName: "LastNameEn");

            migrationBuilder.RenameColumn(
                name: "studnetProfile_FirstNameEn",
                table: "AppStudent",
                newName: "FirstNameEn");

            migrationBuilder.RenameColumn(
                name: "studnetProfile_FatherNameEn",
                table: "AppStudent",
                newName: "FatherNameEn");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MotherNameEn",
                table: "AppStudent",
                newName: "studnetProfile_MotherNameEn");

            migrationBuilder.RenameColumn(
                name: "LastNameEn",
                table: "AppStudent",
                newName: "studnetProfile_LastNameEn");

            migrationBuilder.RenameColumn(
                name: "FirstNameEn",
                table: "AppStudent",
                newName: "studnetProfile_FirstNameEn");

            migrationBuilder.RenameColumn(
                name: "FatherNameEn",
                table: "AppStudent",
                newName: "studnetProfile_FatherNameEn");
        }
    }
}
