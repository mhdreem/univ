using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Univ.Hi_Student_Affairs.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "AppStdSeqSum",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppStdSeqSum_StatusId",
                table: "AppStdSeqSum",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqSum_AppStatus_StatusId",
                table: "AppStdSeqSum",
                column: "StatusId",
                principalTable: "AppStatus",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqSum_AppStatus_StatusId",
                table: "AppStdSeqSum");

            migrationBuilder.DropIndex(
                name: "IX_AppStdSeqSum_StatusId",
                table: "AppStdSeqSum");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "AppStdSeqSum");
        }
    }
}
