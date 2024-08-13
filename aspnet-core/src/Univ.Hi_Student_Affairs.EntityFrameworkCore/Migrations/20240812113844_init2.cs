using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Univ.Hi_Student_Affairs.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqStudy_AppAdmission_UniveInfo_AdmissionId",
                table: "AppStdSeqStudy");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqStudy_AppBranch_UniveInfo_BranchId",
                table: "AppStdSeqStudy");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqStudy_AppClass_UniveInfo_ClassId",
                table: "AppStdSeqStudy");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqStudy_AppCollage_UniveInfo_CollageId",
                table: "AppStdSeqStudy");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqStudy_AppDepartment_UniveInfo_DepartmentId",
                table: "AppStdSeqStudy");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqStudy_AppSemester_UniveInfo_SemesterId",
                table: "AppStdSeqStudy");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqStudy_AppUnivSection_UniveInfo_UnivSectionId",
                table: "AppStdSeqStudy");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqStudy_AppUniv_UniveInfo_UnivId",
                table: "AppStdSeqStudy");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqSum_AppAdmission_UniveInfo_AdmissionId",
                table: "AppStdSeqSum");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqSum_AppBranch_UniveInfo_BranchId",
                table: "AppStdSeqSum");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqSum_AppClass_UniveInfo_ClassId",
                table: "AppStdSeqSum");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqSum_AppCollage_UniveInfo_CollageId",
                table: "AppStdSeqSum");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqSum_AppDepartment_UniveInfo_DepartmentId",
                table: "AppStdSeqSum");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqSum_AppSemester_UniveInfo_SemesterId",
                table: "AppStdSeqSum");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqSum_AppUnivSection_UniveInfo_UnivSectionId",
                table: "AppStdSeqSum");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqSum_AppUniv_UniveInfo_UnivId",
                table: "AppStdSeqSum");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppAdmission_UniveInfo_AdmissionId",
                table: "AppStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppBranch_UniveInfo_BranchId",
                table: "AppStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppClass_UniveInfo_ClassId",
                table: "AppStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppCollage_UniveInfo_CollageId",
                table: "AppStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppCountry_studnetProfile_CountryId",
                table: "AppStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppDepartment_UniveInfo_DepartmentId",
                table: "AppStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppIdentifierType_studnetProfile_IdentifierTypeId",
                table: "AppStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppSemester_UniveInfo_SemesterId",
                table: "AppStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppUnivSection_UniveInfo_UnivSectionId",
                table: "AppStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppUniv_UniveInfo_UnivId",
                table: "AppStudent");

            migrationBuilder.DropColumn(
                name: "studnetProfile_NationalityId",
                table: "AppStudent");

            migrationBuilder.RenameColumn(
                name: "studnetProfile_YearBirth",
                table: "AppStudent",
                newName: "YearBirth");

            migrationBuilder.RenameColumn(
                name: "studnetProfile_Nationality",
                table: "AppStudent",
                newName: "Nationality");

            migrationBuilder.RenameColumn(
                name: "studnetProfile_MotherNameAr",
                table: "AppStudent",
                newName: "MotherNameAr");

            migrationBuilder.RenameColumn(
                name: "studnetProfile_MonthBirth",
                table: "AppStudent",
                newName: "MonthBirth");

            migrationBuilder.RenameColumn(
                name: "studnetProfile_LastNameAr",
                table: "AppStudent",
                newName: "LastNameAr");

            migrationBuilder.RenameColumn(
                name: "studnetProfile_Jender",
                table: "AppStudent",
                newName: "Jender");

            migrationBuilder.RenameColumn(
                name: "studnetProfile_IdentifierTypeId",
                table: "AppStudent",
                newName: "IdentifierTypeId");

            migrationBuilder.RenameColumn(
                name: "studnetProfile_Identifier",
                table: "AppStudent",
                newName: "Identifier");

            migrationBuilder.RenameColumn(
                name: "studnetProfile_FirstNameAR",
                table: "AppStudent",
                newName: "FirstNameAR");

            migrationBuilder.RenameColumn(
                name: "studnetProfile_FatherNameAr",
                table: "AppStudent",
                newName: "FatherNameAr");

            migrationBuilder.RenameColumn(
                name: "studnetProfile_DayBirth",
                table: "AppStudent",
                newName: "DayBirth");

            migrationBuilder.RenameColumn(
                name: "studnetProfile_CountryId",
                table: "AppStudent",
                newName: "CountryId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_UnivSectionId",
                table: "AppStudent",
                newName: "UnivSectionId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_UnivId",
                table: "AppStudent",
                newName: "UnivId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_SemesterId",
                table: "AppStudent",
                newName: "SemesterId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_DepartmentId",
                table: "AppStudent",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_CollageId",
                table: "AppStudent",
                newName: "CollageId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_ClassId",
                table: "AppStudent",
                newName: "ClassId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_BranchId",
                table: "AppStudent",
                newName: "BranchId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_AdmissionId",
                table: "AppStudent",
                newName: "AdmissionId");

            migrationBuilder.RenameColumn(
                name: "StdNo_StdMinistryId",
                table: "AppStudent",
                newName: "StdMinistryId");

            migrationBuilder.RenameColumn(
                name: "StdNo_StdCollageId",
                table: "AppStudent",
                newName: "StdCollageId");

            migrationBuilder.RenameColumn(
                name: "StdNo_ExamCollageId",
                table: "AppStudent",
                newName: "ExamCollageId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_UniveInfo_UnivSectionId",
                table: "AppStudent",
                newName: "IX_AppStudent_UnivSectionId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_UniveInfo_UnivId",
                table: "AppStudent",
                newName: "IX_AppStudent_UnivId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_UniveInfo_SemesterId",
                table: "AppStudent",
                newName: "IX_AppStudent_SemesterId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_UniveInfo_DepartmentId",
                table: "AppStudent",
                newName: "IX_AppStudent_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_UniveInfo_CollageId",
                table: "AppStudent",
                newName: "IX_AppStudent_CollageId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_UniveInfo_ClassId",
                table: "AppStudent",
                newName: "IX_AppStudent_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_UniveInfo_BranchId",
                table: "AppStudent",
                newName: "IX_AppStudent_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_UniveInfo_AdmissionId",
                table: "AppStudent",
                newName: "IX_AppStudent_AdmissionId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_studnetProfile_IdentifierTypeId",
                table: "AppStudent",
                newName: "IX_AppStudent_IdentifierTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_studnetProfile_CountryId",
                table: "AppStudent",
                newName: "IX_AppStudent_CountryId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_UnivSectionId",
                table: "AppStdSeqSum",
                newName: "UnivSectionId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_UnivId",
                table: "AppStdSeqSum",
                newName: "UnivId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_SemesterId",
                table: "AppStdSeqSum",
                newName: "SemesterId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_DepartmentId",
                table: "AppStdSeqSum",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_CollageId",
                table: "AppStdSeqSum",
                newName: "CollageId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_ClassId",
                table: "AppStdSeqSum",
                newName: "ClassId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_BranchId",
                table: "AppStdSeqSum",
                newName: "BranchId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_AdmissionId",
                table: "AppStdSeqSum",
                newName: "AdmissionId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqSum_UniveInfo_UnivSectionId",
                table: "AppStdSeqSum",
                newName: "IX_AppStdSeqSum_UnivSectionId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqSum_UniveInfo_UnivId",
                table: "AppStdSeqSum",
                newName: "IX_AppStdSeqSum_UnivId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqSum_UniveInfo_SemesterId",
                table: "AppStdSeqSum",
                newName: "IX_AppStdSeqSum_SemesterId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqSum_UniveInfo_DepartmentId",
                table: "AppStdSeqSum",
                newName: "IX_AppStdSeqSum_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqSum_UniveInfo_CollageId",
                table: "AppStdSeqSum",
                newName: "IX_AppStdSeqSum_CollageId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqSum_UniveInfo_ClassId",
                table: "AppStdSeqSum",
                newName: "IX_AppStdSeqSum_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqSum_UniveInfo_BranchId",
                table: "AppStdSeqSum",
                newName: "IX_AppStdSeqSum_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqSum_UniveInfo_AdmissionId",
                table: "AppStdSeqSum",
                newName: "IX_AppStdSeqSum_AdmissionId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_UnivSectionId",
                table: "AppStdSeqStudy",
                newName: "UnivSectionId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_UnivId",
                table: "AppStdSeqStudy",
                newName: "UnivId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_SemesterId",
                table: "AppStdSeqStudy",
                newName: "SemesterId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_DepartmentId",
                table: "AppStdSeqStudy",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_CollageId",
                table: "AppStdSeqStudy",
                newName: "CollageId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_ClassId",
                table: "AppStdSeqStudy",
                newName: "ClassId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_BranchId",
                table: "AppStdSeqStudy",
                newName: "BranchId");

            migrationBuilder.RenameColumn(
                name: "UniveInfo_AdmissionId",
                table: "AppStdSeqStudy",
                newName: "AdmissionId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqStudy_UniveInfo_UnivSectionId",
                table: "AppStdSeqStudy",
                newName: "IX_AppStdSeqStudy_UnivSectionId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqStudy_UniveInfo_UnivId",
                table: "AppStdSeqStudy",
                newName: "IX_AppStdSeqStudy_UnivId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqStudy_UniveInfo_SemesterId",
                table: "AppStdSeqStudy",
                newName: "IX_AppStdSeqStudy_SemesterId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqStudy_UniveInfo_DepartmentId",
                table: "AppStdSeqStudy",
                newName: "IX_AppStdSeqStudy_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqStudy_UniveInfo_CollageId",
                table: "AppStdSeqStudy",
                newName: "IX_AppStdSeqStudy_CollageId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqStudy_UniveInfo_ClassId",
                table: "AppStdSeqStudy",
                newName: "IX_AppStdSeqStudy_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqStudy_UniveInfo_BranchId",
                table: "AppStdSeqStudy",
                newName: "IX_AppStdSeqStudy_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqStudy_UniveInfo_AdmissionId",
                table: "AppStdSeqStudy",
                newName: "IX_AppStdSeqStudy_AdmissionId");

            migrationBuilder.AlterColumn<byte>(
                name: "UnivType",
                table: "AppUniv",
                type: "NUMBER(3)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AlterColumn<byte>(
                name: "Language",
                table: "AppStdAdmission",
                type: "NUMBER(3)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "AdmissionLanguage",
                table: "AppStdAdmission",
                type: "NUMBER(3)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Continent",
                table: "AppCountry",
                type: "NUMBER(3)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AlterColumn<byte>(
                name: "Degree",
                table: "AppCollage",
                type: "NUMBER(3)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AlterColumn<byte>(
                name: "ColType",
                table: "AppCollage",
                type: "NUMBER(3)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AlterColumn<byte>(
                name: "Ministry",
                table: "AppAdmission",
                type: "NUMBER(3)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqStudy_AppAdmission_AdmissionId",
                table: "AppStdSeqStudy",
                column: "AdmissionId",
                principalTable: "AppAdmission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqStudy_AppBranch_BranchId",
                table: "AppStdSeqStudy",
                column: "BranchId",
                principalTable: "AppBranch",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqStudy_AppClass_ClassId",
                table: "AppStdSeqStudy",
                column: "ClassId",
                principalTable: "AppClass",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqStudy_AppCollage_CollageId",
                table: "AppStdSeqStudy",
                column: "CollageId",
                principalTable: "AppCollage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqStudy_AppDepartment_DepartmentId",
                table: "AppStdSeqStudy",
                column: "DepartmentId",
                principalTable: "AppDepartment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqStudy_AppSemester_SemesterId",
                table: "AppStdSeqStudy",
                column: "SemesterId",
                principalTable: "AppSemester",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqStudy_AppUnivSection_UnivSectionId",
                table: "AppStdSeqStudy",
                column: "UnivSectionId",
                principalTable: "AppUnivSection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqStudy_AppUniv_UnivId",
                table: "AppStdSeqStudy",
                column: "UnivId",
                principalTable: "AppUniv",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqSum_AppAdmission_AdmissionId",
                table: "AppStdSeqSum",
                column: "AdmissionId",
                principalTable: "AppAdmission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqSum_AppBranch_BranchId",
                table: "AppStdSeqSum",
                column: "BranchId",
                principalTable: "AppBranch",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqSum_AppClass_ClassId",
                table: "AppStdSeqSum",
                column: "ClassId",
                principalTable: "AppClass",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqSum_AppCollage_CollageId",
                table: "AppStdSeqSum",
                column: "CollageId",
                principalTable: "AppCollage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqSum_AppDepartment_DepartmentId",
                table: "AppStdSeqSum",
                column: "DepartmentId",
                principalTable: "AppDepartment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqSum_AppSemester_SemesterId",
                table: "AppStdSeqSum",
                column: "SemesterId",
                principalTable: "AppSemester",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqSum_AppUnivSection_UnivSectionId",
                table: "AppStdSeqSum",
                column: "UnivSectionId",
                principalTable: "AppUnivSection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqSum_AppUniv_UnivId",
                table: "AppStdSeqSum",
                column: "UnivId",
                principalTable: "AppUniv",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppAdmission_AdmissionId",
                table: "AppStudent",
                column: "AdmissionId",
                principalTable: "AppAdmission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppBranch_BranchId",
                table: "AppStudent",
                column: "BranchId",
                principalTable: "AppBranch",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppClass_ClassId",
                table: "AppStudent",
                column: "ClassId",
                principalTable: "AppClass",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppCollage_CollageId",
                table: "AppStudent",
                column: "CollageId",
                principalTable: "AppCollage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppCountry_CountryId",
                table: "AppStudent",
                column: "CountryId",
                principalTable: "AppCountry",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppDepartment_DepartmentId",
                table: "AppStudent",
                column: "DepartmentId",
                principalTable: "AppDepartment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppIdentifierType_IdentifierTypeId",
                table: "AppStudent",
                column: "IdentifierTypeId",
                principalTable: "AppIdentifierType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppSemester_SemesterId",
                table: "AppStudent",
                column: "SemesterId",
                principalTable: "AppSemester",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppUnivSection_UnivSectionId",
                table: "AppStudent",
                column: "UnivSectionId",
                principalTable: "AppUnivSection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppUniv_UnivId",
                table: "AppStudent",
                column: "UnivId",
                principalTable: "AppUniv",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqStudy_AppAdmission_AdmissionId",
                table: "AppStdSeqStudy");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqStudy_AppBranch_BranchId",
                table: "AppStdSeqStudy");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqStudy_AppClass_ClassId",
                table: "AppStdSeqStudy");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqStudy_AppCollage_CollageId",
                table: "AppStdSeqStudy");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqStudy_AppDepartment_DepartmentId",
                table: "AppStdSeqStudy");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqStudy_AppSemester_SemesterId",
                table: "AppStdSeqStudy");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqStudy_AppUnivSection_UnivSectionId",
                table: "AppStdSeqStudy");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqStudy_AppUniv_UnivId",
                table: "AppStdSeqStudy");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqSum_AppAdmission_AdmissionId",
                table: "AppStdSeqSum");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqSum_AppBranch_BranchId",
                table: "AppStdSeqSum");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqSum_AppClass_ClassId",
                table: "AppStdSeqSum");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqSum_AppCollage_CollageId",
                table: "AppStdSeqSum");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqSum_AppDepartment_DepartmentId",
                table: "AppStdSeqSum");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqSum_AppSemester_SemesterId",
                table: "AppStdSeqSum");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqSum_AppUnivSection_UnivSectionId",
                table: "AppStdSeqSum");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStdSeqSum_AppUniv_UnivId",
                table: "AppStdSeqSum");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppAdmission_AdmissionId",
                table: "AppStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppBranch_BranchId",
                table: "AppStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppClass_ClassId",
                table: "AppStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppCollage_CollageId",
                table: "AppStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppCountry_CountryId",
                table: "AppStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppDepartment_DepartmentId",
                table: "AppStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppIdentifierType_IdentifierTypeId",
                table: "AppStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppSemester_SemesterId",
                table: "AppStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppUnivSection_UnivSectionId",
                table: "AppStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AppStudent_AppUniv_UnivId",
                table: "AppStudent");

            migrationBuilder.RenameColumn(
                name: "YearBirth",
                table: "AppStudent",
                newName: "studnetProfile_YearBirth");

            migrationBuilder.RenameColumn(
                name: "UnivSectionId",
                table: "AppStudent",
                newName: "UniveInfo_UnivSectionId");

            migrationBuilder.RenameColumn(
                name: "UnivId",
                table: "AppStudent",
                newName: "UniveInfo_UnivId");

            migrationBuilder.RenameColumn(
                name: "StdMinistryId",
                table: "AppStudent",
                newName: "StdNo_StdMinistryId");

            migrationBuilder.RenameColumn(
                name: "StdCollageId",
                table: "AppStudent",
                newName: "StdNo_StdCollageId");

            migrationBuilder.RenameColumn(
                name: "SemesterId",
                table: "AppStudent",
                newName: "UniveInfo_SemesterId");

            migrationBuilder.RenameColumn(
                name: "Nationality",
                table: "AppStudent",
                newName: "studnetProfile_Nationality");

            migrationBuilder.RenameColumn(
                name: "MotherNameAr",
                table: "AppStudent",
                newName: "studnetProfile_MotherNameAr");

            migrationBuilder.RenameColumn(
                name: "MonthBirth",
                table: "AppStudent",
                newName: "studnetProfile_MonthBirth");

            migrationBuilder.RenameColumn(
                name: "LastNameAr",
                table: "AppStudent",
                newName: "studnetProfile_LastNameAr");

            migrationBuilder.RenameColumn(
                name: "Jender",
                table: "AppStudent",
                newName: "studnetProfile_Jender");

            migrationBuilder.RenameColumn(
                name: "IdentifierTypeId",
                table: "AppStudent",
                newName: "studnetProfile_IdentifierTypeId");

            migrationBuilder.RenameColumn(
                name: "Identifier",
                table: "AppStudent",
                newName: "studnetProfile_Identifier");

            migrationBuilder.RenameColumn(
                name: "FirstNameAR",
                table: "AppStudent",
                newName: "studnetProfile_FirstNameAR");

            migrationBuilder.RenameColumn(
                name: "FatherNameAr",
                table: "AppStudent",
                newName: "studnetProfile_FatherNameAr");

            migrationBuilder.RenameColumn(
                name: "ExamCollageId",
                table: "AppStudent",
                newName: "StdNo_ExamCollageId");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "AppStudent",
                newName: "UniveInfo_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "DayBirth",
                table: "AppStudent",
                newName: "studnetProfile_DayBirth");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "AppStudent",
                newName: "studnetProfile_CountryId");

            migrationBuilder.RenameColumn(
                name: "CollageId",
                table: "AppStudent",
                newName: "UniveInfo_CollageId");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "AppStudent",
                newName: "UniveInfo_ClassId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "AppStudent",
                newName: "UniveInfo_BranchId");

            migrationBuilder.RenameColumn(
                name: "AdmissionId",
                table: "AppStudent",
                newName: "UniveInfo_AdmissionId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_UnivSectionId",
                table: "AppStudent",
                newName: "IX_AppStudent_UniveInfo_UnivSectionId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_UnivId",
                table: "AppStudent",
                newName: "IX_AppStudent_UniveInfo_UnivId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_SemesterId",
                table: "AppStudent",
                newName: "IX_AppStudent_UniveInfo_SemesterId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_IdentifierTypeId",
                table: "AppStudent",
                newName: "IX_AppStudent_studnetProfile_IdentifierTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_DepartmentId",
                table: "AppStudent",
                newName: "IX_AppStudent_UniveInfo_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_CountryId",
                table: "AppStudent",
                newName: "IX_AppStudent_studnetProfile_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_CollageId",
                table: "AppStudent",
                newName: "IX_AppStudent_UniveInfo_CollageId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_ClassId",
                table: "AppStudent",
                newName: "IX_AppStudent_UniveInfo_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_BranchId",
                table: "AppStudent",
                newName: "IX_AppStudent_UniveInfo_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStudent_AdmissionId",
                table: "AppStudent",
                newName: "IX_AppStudent_UniveInfo_AdmissionId");

            migrationBuilder.RenameColumn(
                name: "UnivSectionId",
                table: "AppStdSeqSum",
                newName: "UniveInfo_UnivSectionId");

            migrationBuilder.RenameColumn(
                name: "UnivId",
                table: "AppStdSeqSum",
                newName: "UniveInfo_UnivId");

            migrationBuilder.RenameColumn(
                name: "SemesterId",
                table: "AppStdSeqSum",
                newName: "UniveInfo_SemesterId");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "AppStdSeqSum",
                newName: "UniveInfo_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "CollageId",
                table: "AppStdSeqSum",
                newName: "UniveInfo_CollageId");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "AppStdSeqSum",
                newName: "UniveInfo_ClassId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "AppStdSeqSum",
                newName: "UniveInfo_BranchId");

            migrationBuilder.RenameColumn(
                name: "AdmissionId",
                table: "AppStdSeqSum",
                newName: "UniveInfo_AdmissionId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqSum_UnivSectionId",
                table: "AppStdSeqSum",
                newName: "IX_AppStdSeqSum_UniveInfo_UnivSectionId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqSum_UnivId",
                table: "AppStdSeqSum",
                newName: "IX_AppStdSeqSum_UniveInfo_UnivId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqSum_SemesterId",
                table: "AppStdSeqSum",
                newName: "IX_AppStdSeqSum_UniveInfo_SemesterId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqSum_DepartmentId",
                table: "AppStdSeqSum",
                newName: "IX_AppStdSeqSum_UniveInfo_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqSum_CollageId",
                table: "AppStdSeqSum",
                newName: "IX_AppStdSeqSum_UniveInfo_CollageId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqSum_ClassId",
                table: "AppStdSeqSum",
                newName: "IX_AppStdSeqSum_UniveInfo_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqSum_BranchId",
                table: "AppStdSeqSum",
                newName: "IX_AppStdSeqSum_UniveInfo_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqSum_AdmissionId",
                table: "AppStdSeqSum",
                newName: "IX_AppStdSeqSum_UniveInfo_AdmissionId");

            migrationBuilder.RenameColumn(
                name: "UnivSectionId",
                table: "AppStdSeqStudy",
                newName: "UniveInfo_UnivSectionId");

            migrationBuilder.RenameColumn(
                name: "UnivId",
                table: "AppStdSeqStudy",
                newName: "UniveInfo_UnivId");

            migrationBuilder.RenameColumn(
                name: "SemesterId",
                table: "AppStdSeqStudy",
                newName: "UniveInfo_SemesterId");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "AppStdSeqStudy",
                newName: "UniveInfo_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "CollageId",
                table: "AppStdSeqStudy",
                newName: "UniveInfo_CollageId");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "AppStdSeqStudy",
                newName: "UniveInfo_ClassId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "AppStdSeqStudy",
                newName: "UniveInfo_BranchId");

            migrationBuilder.RenameColumn(
                name: "AdmissionId",
                table: "AppStdSeqStudy",
                newName: "UniveInfo_AdmissionId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqStudy_UnivSectionId",
                table: "AppStdSeqStudy",
                newName: "IX_AppStdSeqStudy_UniveInfo_UnivSectionId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqStudy_UnivId",
                table: "AppStdSeqStudy",
                newName: "IX_AppStdSeqStudy_UniveInfo_UnivId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqStudy_SemesterId",
                table: "AppStdSeqStudy",
                newName: "IX_AppStdSeqStudy_UniveInfo_SemesterId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqStudy_DepartmentId",
                table: "AppStdSeqStudy",
                newName: "IX_AppStdSeqStudy_UniveInfo_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqStudy_CollageId",
                table: "AppStdSeqStudy",
                newName: "IX_AppStdSeqStudy_UniveInfo_CollageId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqStudy_ClassId",
                table: "AppStdSeqStudy",
                newName: "IX_AppStdSeqStudy_UniveInfo_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqStudy_BranchId",
                table: "AppStdSeqStudy",
                newName: "IX_AppStdSeqStudy_UniveInfo_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_AppStdSeqStudy_AdmissionId",
                table: "AppStdSeqStudy",
                newName: "IX_AppStdSeqStudy_UniveInfo_AdmissionId");

            migrationBuilder.AlterColumn<int>(
                name: "UnivType",
                table: "AppUniv",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "NUMBER(3)");

            migrationBuilder.AddColumn<int>(
                name: "studnetProfile_NationalityId",
                table: "AppStudent",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Language",
                table: "AppStdAdmission",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "NUMBER(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdmissionLanguage",
                table: "AppStdAdmission",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "NUMBER(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Continent",
                table: "AppCountry",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "NUMBER(3)");

            migrationBuilder.AlterColumn<int>(
                name: "Degree",
                table: "AppCollage",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "NUMBER(3)");

            migrationBuilder.AlterColumn<int>(
                name: "ColType",
                table: "AppCollage",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "NUMBER(3)");

            migrationBuilder.AlterColumn<int>(
                name: "Ministry",
                table: "AppAdmission",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "NUMBER(3)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqStudy_AppAdmission_UniveInfo_AdmissionId",
                table: "AppStdSeqStudy",
                column: "UniveInfo_AdmissionId",
                principalTable: "AppAdmission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqStudy_AppBranch_UniveInfo_BranchId",
                table: "AppStdSeqStudy",
                column: "UniveInfo_BranchId",
                principalTable: "AppBranch",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqStudy_AppClass_UniveInfo_ClassId",
                table: "AppStdSeqStudy",
                column: "UniveInfo_ClassId",
                principalTable: "AppClass",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqStudy_AppCollage_UniveInfo_CollageId",
                table: "AppStdSeqStudy",
                column: "UniveInfo_CollageId",
                principalTable: "AppCollage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqStudy_AppDepartment_UniveInfo_DepartmentId",
                table: "AppStdSeqStudy",
                column: "UniveInfo_DepartmentId",
                principalTable: "AppDepartment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqStudy_AppSemester_UniveInfo_SemesterId",
                table: "AppStdSeqStudy",
                column: "UniveInfo_SemesterId",
                principalTable: "AppSemester",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqStudy_AppUnivSection_UniveInfo_UnivSectionId",
                table: "AppStdSeqStudy",
                column: "UniveInfo_UnivSectionId",
                principalTable: "AppUnivSection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqStudy_AppUniv_UniveInfo_UnivId",
                table: "AppStdSeqStudy",
                column: "UniveInfo_UnivId",
                principalTable: "AppUniv",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqSum_AppAdmission_UniveInfo_AdmissionId",
                table: "AppStdSeqSum",
                column: "UniveInfo_AdmissionId",
                principalTable: "AppAdmission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqSum_AppBranch_UniveInfo_BranchId",
                table: "AppStdSeqSum",
                column: "UniveInfo_BranchId",
                principalTable: "AppBranch",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqSum_AppClass_UniveInfo_ClassId",
                table: "AppStdSeqSum",
                column: "UniveInfo_ClassId",
                principalTable: "AppClass",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqSum_AppCollage_UniveInfo_CollageId",
                table: "AppStdSeqSum",
                column: "UniveInfo_CollageId",
                principalTable: "AppCollage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqSum_AppDepartment_UniveInfo_DepartmentId",
                table: "AppStdSeqSum",
                column: "UniveInfo_DepartmentId",
                principalTable: "AppDepartment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqSum_AppSemester_UniveInfo_SemesterId",
                table: "AppStdSeqSum",
                column: "UniveInfo_SemesterId",
                principalTable: "AppSemester",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqSum_AppUnivSection_UniveInfo_UnivSectionId",
                table: "AppStdSeqSum",
                column: "UniveInfo_UnivSectionId",
                principalTable: "AppUnivSection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStdSeqSum_AppUniv_UniveInfo_UnivId",
                table: "AppStdSeqSum",
                column: "UniveInfo_UnivId",
                principalTable: "AppUniv",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppAdmission_UniveInfo_AdmissionId",
                table: "AppStudent",
                column: "UniveInfo_AdmissionId",
                principalTable: "AppAdmission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppBranch_UniveInfo_BranchId",
                table: "AppStudent",
                column: "UniveInfo_BranchId",
                principalTable: "AppBranch",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppClass_UniveInfo_ClassId",
                table: "AppStudent",
                column: "UniveInfo_ClassId",
                principalTable: "AppClass",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppCollage_UniveInfo_CollageId",
                table: "AppStudent",
                column: "UniveInfo_CollageId",
                principalTable: "AppCollage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppCountry_studnetProfile_CountryId",
                table: "AppStudent",
                column: "studnetProfile_CountryId",
                principalTable: "AppCountry",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppDepartment_UniveInfo_DepartmentId",
                table: "AppStudent",
                column: "UniveInfo_DepartmentId",
                principalTable: "AppDepartment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppIdentifierType_studnetProfile_IdentifierTypeId",
                table: "AppStudent",
                column: "studnetProfile_IdentifierTypeId",
                principalTable: "AppIdentifierType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppSemester_UniveInfo_SemesterId",
                table: "AppStudent",
                column: "UniveInfo_SemesterId",
                principalTable: "AppSemester",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppUnivSection_UniveInfo_UnivSectionId",
                table: "AppStudent",
                column: "UniveInfo_UnivSectionId",
                principalTable: "AppUnivSection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppStudent_AppUniv_UniveInfo_UnivId",
                table: "AppStudent",
                column: "UniveInfo_UnivId",
                principalTable: "AppUniv",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
