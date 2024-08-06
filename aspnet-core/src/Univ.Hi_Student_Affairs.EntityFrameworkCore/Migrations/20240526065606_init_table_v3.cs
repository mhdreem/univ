using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Univ.Hi_Student_Affairs.Migrations
{
    /// <inheritdoc />
    public partial class init_table_v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppAdmission_AppAdmission_Kind_AdmissionKindId",
                table: "AppAdmission");

            migrationBuilder.DropForeignKey(
                name: "FK_AppAdmission_AppFee_Calc_Type_FeeCalcTypeId",
                table: "AppAdmission");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCollage_AppColl_Type_CollTypeId",
                table: "AppCollage");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCollage_AppUniv_Section_UnivSectionId",
                table: "AppCollage");

            migrationBuilder.DropForeignKey(
                name: "FK_AppType_Lic_Branch_AppType_Lic_TypeLicId",
                table: "AppType_Lic_Branch");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUniv_AppUniv_Type_UnivTypeId",
                table: "AppUniv");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUniv_Section_AppUniv_UnivId",
                table: "AppUniv_Section");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUniv_Type",
                table: "AppUniv_Type");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUniv_Section",
                table: "AppUniv_Section");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppType_Lic_Branch",
                table: "AppType_Lic_Branch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppType_Lic",
                table: "AppType_Lic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppIdentifier_Type",
                table: "AppIdentifier_Type");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppFee_Calc_Type",
                table: "AppFee_Calc_Type");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppColl_Type",
                table: "AppColl_Type");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppAdmission_Kind",
                table: "AppAdmission_Kind");

            migrationBuilder.RenameTable(
                name: "AppUniv_Type",
                newName: "AppUnivType");

            migrationBuilder.RenameTable(
                name: "AppUniv_Section",
                newName: "AppUnivSection");

            migrationBuilder.RenameTable(
                name: "AppType_Lic_Branch",
                newName: "AppTypeLicBranch");

            migrationBuilder.RenameTable(
                name: "AppType_Lic",
                newName: "AppTypeLic");

            migrationBuilder.RenameTable(
                name: "AppIdentifier_Type",
                newName: "AppIdentifierType");

            migrationBuilder.RenameTable(
                name: "AppFee_Calc_Type",
                newName: "AppFeeCalcType");

            migrationBuilder.RenameTable(
                name: "AppColl_Type",
                newName: "AppCollType");

            migrationBuilder.RenameTable(
                name: "AppAdmission_Kind",
                newName: "AppAdmissionKind");

            migrationBuilder.RenameIndex(
                name: "IX_AppUniv_Section_UnivId",
                table: "AppUnivSection",
                newName: "IX_AppUnivSection_UnivId");

            migrationBuilder.RenameIndex(
                name: "IX_AppType_Lic_Branch_TypeLicId",
                table: "AppTypeLicBranch",
                newName: "IX_AppTypeLicBranch_TypeLicId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUnivType",
                table: "AppUnivType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUnivSection",
                table: "AppUnivSection",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppTypeLicBranch",
                table: "AppTypeLicBranch",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppTypeLic",
                table: "AppTypeLic",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppIdentifierType",
                table: "AppIdentifierType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppFeeCalcType",
                table: "AppFeeCalcType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppCollType",
                table: "AppCollType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppAdmissionKind",
                table: "AppAdmissionKind",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppAdmission_AppAdmissionKind_AdmissionKindId",
                table: "AppAdmission",
                column: "AdmissionKindId",
                principalTable: "AppAdmissionKind",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppAdmission_AppFeeCalcType_FeeCalcTypeId",
                table: "AppAdmission",
                column: "FeeCalcTypeId",
                principalTable: "AppFeeCalcType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppCollage_AppCollType_CollTypeId",
                table: "AppCollage",
                column: "CollTypeId",
                principalTable: "AppCollType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppCollage_AppUnivSection_UnivSectionId",
                table: "AppCollage",
                column: "UnivSectionId",
                principalTable: "AppUnivSection",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppTypeLicBranch_AppTypeLic_TypeLicId",
                table: "AppTypeLicBranch",
                column: "TypeLicId",
                principalTable: "AppTypeLic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUniv_AppUnivType_UnivTypeId",
                table: "AppUniv",
                column: "UnivTypeId",
                principalTable: "AppUnivType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUnivSection_AppUniv_UnivId",
                table: "AppUnivSection",
                column: "UnivId",
                principalTable: "AppUniv",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppAdmission_AppAdmissionKind_AdmissionKindId",
                table: "AppAdmission");

            migrationBuilder.DropForeignKey(
                name: "FK_AppAdmission_AppFeeCalcType_FeeCalcTypeId",
                table: "AppAdmission");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCollage_AppCollType_CollTypeId",
                table: "AppCollage");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCollage_AppUnivSection_UnivSectionId",
                table: "AppCollage");

            migrationBuilder.DropForeignKey(
                name: "FK_AppTypeLicBranch_AppTypeLic_TypeLicId",
                table: "AppTypeLicBranch");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUniv_AppUnivType_UnivTypeId",
                table: "AppUniv");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUnivSection_AppUniv_UnivId",
                table: "AppUnivSection");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUnivType",
                table: "AppUnivType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUnivSection",
                table: "AppUnivSection");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppTypeLicBranch",
                table: "AppTypeLicBranch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppTypeLic",
                table: "AppTypeLic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppIdentifierType",
                table: "AppIdentifierType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppFeeCalcType",
                table: "AppFeeCalcType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppCollType",
                table: "AppCollType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppAdmissionKind",
                table: "AppAdmissionKind");

            migrationBuilder.RenameTable(
                name: "AppUnivType",
                newName: "AppUniv_Type");

            migrationBuilder.RenameTable(
                name: "AppUnivSection",
                newName: "AppUniv_Section");

            migrationBuilder.RenameTable(
                name: "AppTypeLicBranch",
                newName: "AppType_Lic_Branch");

            migrationBuilder.RenameTable(
                name: "AppTypeLic",
                newName: "AppType_Lic");

            migrationBuilder.RenameTable(
                name: "AppIdentifierType",
                newName: "AppIdentifier_Type");

            migrationBuilder.RenameTable(
                name: "AppFeeCalcType",
                newName: "AppFee_Calc_Type");

            migrationBuilder.RenameTable(
                name: "AppCollType",
                newName: "AppColl_Type");

            migrationBuilder.RenameTable(
                name: "AppAdmissionKind",
                newName: "AppAdmission_Kind");

            migrationBuilder.RenameIndex(
                name: "IX_AppUnivSection_UnivId",
                table: "AppUniv_Section",
                newName: "IX_AppUniv_Section_UnivId");

            migrationBuilder.RenameIndex(
                name: "IX_AppTypeLicBranch_TypeLicId",
                table: "AppType_Lic_Branch",
                newName: "IX_AppType_Lic_Branch_TypeLicId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUniv_Type",
                table: "AppUniv_Type",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUniv_Section",
                table: "AppUniv_Section",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppType_Lic_Branch",
                table: "AppType_Lic_Branch",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppType_Lic",
                table: "AppType_Lic",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppIdentifier_Type",
                table: "AppIdentifier_Type",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppFee_Calc_Type",
                table: "AppFee_Calc_Type",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppColl_Type",
                table: "AppColl_Type",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppAdmission_Kind",
                table: "AppAdmission_Kind",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppAdmission_AppAdmission_Kind_AdmissionKindId",
                table: "AppAdmission",
                column: "AdmissionKindId",
                principalTable: "AppAdmission_Kind",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppAdmission_AppFee_Calc_Type_FeeCalcTypeId",
                table: "AppAdmission",
                column: "FeeCalcTypeId",
                principalTable: "AppFee_Calc_Type",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppCollage_AppColl_Type_CollTypeId",
                table: "AppCollage",
                column: "CollTypeId",
                principalTable: "AppColl_Type",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppCollage_AppUniv_Section_UnivSectionId",
                table: "AppCollage",
                column: "UnivSectionId",
                principalTable: "AppUniv_Section",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppType_Lic_Branch_AppType_Lic_TypeLicId",
                table: "AppType_Lic_Branch",
                column: "TypeLicId",
                principalTable: "AppType_Lic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUniv_AppUniv_Type_UnivTypeId",
                table: "AppUniv",
                column: "UnivTypeId",
                principalTable: "AppUniv_Type",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUniv_Section_AppUniv_UnivId",
                table: "AppUniv_Section",
                column: "UnivId",
                principalTable: "AppUniv",
                principalColumn: "Id");
        }
    }
}
