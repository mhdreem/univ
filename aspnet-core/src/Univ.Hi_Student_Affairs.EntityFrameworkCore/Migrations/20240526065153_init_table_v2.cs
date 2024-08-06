using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Univ.Hi_Student_Affairs.Migrations
{
    /// <inheritdoc />
    public partial class init_table_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppAdmission_AppAdmission_Kind_Admission_KindId",
                table: "AppAdmission");

            migrationBuilder.DropForeignKey(
                name: "FK_AppAdmission_AppFee_Calc_Type_Fee_Calc_TypeId",
                table: "AppAdmission");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCollage_AppColl_Type_Coll_TypeId",
                table: "AppCollage");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCollage_AppUniv_Section_Univ_SectionId",
                table: "AppCollage");

            migrationBuilder.DropForeignKey(
                name: "FK_AppType_Lic_Branch_AppType_Lic_Type_LicId",
                table: "AppType_Lic_Branch");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUniv_AppUniv_Type_Univ_TypeId",
                table: "AppUniv");

            migrationBuilder.DropIndex(
                name: "IX_AppUniv_Univ_TypeId",
                table: "AppUniv");

            migrationBuilder.DropIndex(
                name: "IX_AppType_Lic_Branch_Type_LicId",
                table: "AppType_Lic_Branch");

            migrationBuilder.DropIndex(
                name: "IX_AppCollage_Coll_TypeId",
                table: "AppCollage");

            migrationBuilder.DropIndex(
                name: "IX_AppCollage_Univ_SectionId",
                table: "AppCollage");

            migrationBuilder.DropIndex(
                name: "IX_AppAdmission_Admission_KindId",
                table: "AppAdmission");

            migrationBuilder.DropColumn(
                name: "Ministry_Encode",
                table: "AppUniv_Section");

            migrationBuilder.DropColumn(
                name: "Univ_FK",
                table: "AppUniv_Section");

            migrationBuilder.DropColumn(
                name: "Country_FK",
                table: "AppUniv");

            migrationBuilder.DropColumn(
                name: "Ministry_Encode",
                table: "AppUniv");

            migrationBuilder.DropColumn(
                name: "Ministry_Encode",
                table: "AppType_Lic_Branch");

            migrationBuilder.DropColumn(
                name: "Collage_FK",
                table: "AppDepartment");

            migrationBuilder.DropColumn(
                name: "Continent_FK",
                table: "AppCountry");

            migrationBuilder.DropColumn(
                name: "Coll_TypeId",
                table: "AppCollage");

            migrationBuilder.DropColumn(
                name: "Coll_Type_FK",
                table: "AppCollage");

            migrationBuilder.DropColumn(
                name: "Country_FK",
                table: "AppCity");

            migrationBuilder.DropColumn(
                name: "Department_FK",
                table: "AppBranch");

            migrationBuilder.DropColumn(
                name: "Adm_Kind_FK",
                table: "AppAdmission");

            migrationBuilder.DropColumn(
                name: "Admission_KindId",
                table: "AppAdmission");

            migrationBuilder.RenameColumn(
                name: "NAME_EN",
                table: "AppUniv_Type",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "NAME_AR",
                table: "AppUniv_Type",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "Univ_Sec_Encode",
                table: "AppUniv_Section",
                newName: "MinistryEncode");

            migrationBuilder.RenameColumn(
                name: "Name_En",
                table: "AppUniv_Section",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "Name_Ar",
                table: "AppUniv_Section",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "Univ_Type_FK",
                table: "AppUniv",
                newName: "UnivTypeId");

            migrationBuilder.RenameColumn(
                name: "Univ_TypeId",
                table: "AppUniv",
                newName: "MinistryEncode");

            migrationBuilder.RenameColumn(
                name: "Univ_Encode",
                table: "AppUniv",
                newName: "UnivEncode");

            migrationBuilder.RenameColumn(
                name: "Name_En",
                table: "AppUniv",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "Name_Ar",
                table: "AppUniv",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "Type_Lic_FK",
                table: "AppType_Lic_Branch",
                newName: "TypeLicId");

            migrationBuilder.RenameColumn(
                name: "Type_LicId",
                table: "AppType_Lic_Branch",
                newName: "MinistryEncode");

            migrationBuilder.RenameColumn(
                name: "Name_En",
                table: "AppType_Lic_Branch",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "Name_Ar",
                table: "AppType_Lic_Branch",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "Name_En",
                table: "AppType_Lic",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "Name_Ar",
                table: "AppType_Lic",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "Ministry_Encode",
                table: "AppType_Lic",
                newName: "MinistryEncode");

            migrationBuilder.RenameColumn(
                name: "Name_En",
                table: "AppSemester",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "Name_Ar",
                table: "AppSemester",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "Grade_Name_En",
                table: "AppSemester",
                newName: "GradeNameEn");

            migrationBuilder.RenameColumn(
                name: "Grade_Name_Ar",
                table: "AppSemester",
                newName: "GradeNameAr");

            migrationBuilder.RenameColumn(
                name: "Name_En",
                table: "AppNationality",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "Name_Ar",
                table: "AppNationality",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "Ministry_Encode",
                table: "AppNationality",
                newName: "MinistryEncode");

            migrationBuilder.RenameColumn(
                name: "BARCODE",
                table: "AppLanguage",
                newName: "Barcode");

            migrationBuilder.RenameColumn(
                name: "NAME_EN",
                table: "AppLanguage",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "NAME_AR",
                table: "AppLanguage",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "MINISTRY_ENCODE",
                table: "AppLanguage",
                newName: "MinistryEncode");

            migrationBuilder.RenameColumn(
                name: "Name_En",
                table: "AppIdentifier_Type",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "Name_Ar",
                table: "AppIdentifier_Type",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "Name_En",
                table: "AppDepartment",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "Name_Ar",
                table: "AppDepartment",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "Ministry_Encode",
                table: "AppDepartment",
                newName: "MinistryEncode");

            migrationBuilder.RenameColumn(
                name: "Degree_Name_En",
                table: "AppDepartment",
                newName: "DegreeNameEn");

            migrationBuilder.RenameColumn(
                name: "Degree_Name_Ar",
                table: "AppDepartment",
                newName: "DegreeNameAr");

            migrationBuilder.RenameColumn(
                name: "Name_En",
                table: "AppCountry",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "Name_Ar",
                table: "AppCountry",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "Ministry_Encode",
                table: "AppCountry",
                newName: "MinistryEncode");

            migrationBuilder.RenameColumn(
                name: "Name_En",
                table: "AppContinent",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "Name_Ar",
                table: "AppContinent",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "Ministry_Encode",
                table: "AppContinent",
                newName: "MinistryEncode");

            migrationBuilder.RenameColumn(
                name: "Univ_Section_FK",
                table: "AppCollage",
                newName: "UnivSectionId");

            migrationBuilder.RenameColumn(
                name: "Univ_SectionId",
                table: "AppCollage",
                newName: "NumYear");

            migrationBuilder.RenameColumn(
                name: "Num_Year",
                table: "AppCollage",
                newName: "MinistryEncode");

            migrationBuilder.RenameColumn(
                name: "Name_En",
                table: "AppCollage",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "Name_Ar",
                table: "AppCollage",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "Ministry_Encode",
                table: "AppCollage",
                newName: "CollTypeId");

            migrationBuilder.RenameColumn(
                name: "Degree_Name_En",
                table: "AppCollage",
                newName: "DegreeNameEn");

            migrationBuilder.RenameColumn(
                name: "Degree_Name_Ar",
                table: "AppCollage",
                newName: "DegreeNameAr");

            migrationBuilder.RenameColumn(
                name: "Dean_En",
                table: "AppCollage",
                newName: "DeanEn");

            migrationBuilder.RenameColumn(
                name: "Dean_Ar",
                table: "AppCollage",
                newName: "DeanAr");

            migrationBuilder.RenameColumn(
                name: "Ministry_Encode",
                table: "AppColl_Type",
                newName: "MinistryEncode");

            migrationBuilder.RenameColumn(
                name: "Name_En",
                table: "AppClass",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "Name_Ar",
                table: "AppClass",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "Phone_Code",
                table: "AppCity",
                newName: "PhoneCode");

            migrationBuilder.RenameColumn(
                name: "Name_En",
                table: "AppCity",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "Name_Ar",
                table: "AppCity",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "Ministry_Encode",
                table: "AppCity",
                newName: "MinistryEncode");

            migrationBuilder.RenameColumn(
                name: "Name_En",
                table: "AppBranch",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "Name_Ar",
                table: "AppBranch",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "Ministry_Encode",
                table: "AppBranch",
                newName: "MinistryEncode");

            migrationBuilder.RenameColumn(
                name: "Name_En",
                table: "AppAdmission_Kind",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "Name_Ar",
                table: "AppAdmission_Kind",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "Name_En",
                table: "AppAdmission",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "Name_Ar",
                table: "AppAdmission",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "Ministry_Encode",
                table: "AppAdmission",
                newName: "MinistryEncode");

            migrationBuilder.RenameColumn(
                name: "Fee_Calc_Type_FK",
                table: "AppAdmission",
                newName: "FeeCalcTypeId");

            migrationBuilder.RenameColumn(
                name: "Fee_Calc_TypeId",
                table: "AppAdmission",
                newName: "AdmissionKindId");

            migrationBuilder.RenameIndex(
                name: "IX_AppAdmission_Fee_Calc_TypeId",
                table: "AppAdmission",
                newName: "IX_AppAdmission_AdmissionKindId");

            migrationBuilder.AddColumn<string>(
                name: "Barcode",
                table: "AppUniv_Section",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUniv_UnivTypeId",
                table: "AppUniv",
                column: "UnivTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppType_Lic_Branch_TypeLicId",
                table: "AppType_Lic_Branch",
                column: "TypeLicId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCollage_CollTypeId",
                table: "AppCollage",
                column: "CollTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCollage_UnivSectionId",
                table: "AppCollage",
                column: "UnivSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppAdmission_FeeCalcTypeId",
                table: "AppAdmission",
                column: "FeeCalcTypeId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_AppUniv_UnivTypeId",
                table: "AppUniv");

            migrationBuilder.DropIndex(
                name: "IX_AppType_Lic_Branch_TypeLicId",
                table: "AppType_Lic_Branch");

            migrationBuilder.DropIndex(
                name: "IX_AppCollage_CollTypeId",
                table: "AppCollage");

            migrationBuilder.DropIndex(
                name: "IX_AppCollage_UnivSectionId",
                table: "AppCollage");

            migrationBuilder.DropIndex(
                name: "IX_AppAdmission_FeeCalcTypeId",
                table: "AppAdmission");

            migrationBuilder.DropColumn(
                name: "Barcode",
                table: "AppUniv_Section");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "AppUniv_Type",
                newName: "NAME_EN");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "AppUniv_Type",
                newName: "NAME_AR");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "AppUniv_Section",
                newName: "Name_En");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "AppUniv_Section",
                newName: "Name_Ar");

            migrationBuilder.RenameColumn(
                name: "MinistryEncode",
                table: "AppUniv_Section",
                newName: "Univ_Sec_Encode");

            migrationBuilder.RenameColumn(
                name: "UnivTypeId",
                table: "AppUniv",
                newName: "Univ_Type_FK");

            migrationBuilder.RenameColumn(
                name: "UnivEncode",
                table: "AppUniv",
                newName: "Univ_Encode");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "AppUniv",
                newName: "Name_En");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "AppUniv",
                newName: "Name_Ar");

            migrationBuilder.RenameColumn(
                name: "MinistryEncode",
                table: "AppUniv",
                newName: "Univ_TypeId");

            migrationBuilder.RenameColumn(
                name: "TypeLicId",
                table: "AppType_Lic_Branch",
                newName: "Type_Lic_FK");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "AppType_Lic_Branch",
                newName: "Name_En");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "AppType_Lic_Branch",
                newName: "Name_Ar");

            migrationBuilder.RenameColumn(
                name: "MinistryEncode",
                table: "AppType_Lic_Branch",
                newName: "Type_LicId");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "AppType_Lic",
                newName: "Name_En");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "AppType_Lic",
                newName: "Name_Ar");

            migrationBuilder.RenameColumn(
                name: "MinistryEncode",
                table: "AppType_Lic",
                newName: "Ministry_Encode");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "AppSemester",
                newName: "Name_En");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "AppSemester",
                newName: "Name_Ar");

            migrationBuilder.RenameColumn(
                name: "GradeNameEn",
                table: "AppSemester",
                newName: "Grade_Name_En");

            migrationBuilder.RenameColumn(
                name: "GradeNameAr",
                table: "AppSemester",
                newName: "Grade_Name_Ar");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "AppNationality",
                newName: "Name_En");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "AppNationality",
                newName: "Name_Ar");

            migrationBuilder.RenameColumn(
                name: "MinistryEncode",
                table: "AppNationality",
                newName: "Ministry_Encode");

            migrationBuilder.RenameColumn(
                name: "Barcode",
                table: "AppLanguage",
                newName: "BARCODE");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "AppLanguage",
                newName: "NAME_EN");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "AppLanguage",
                newName: "NAME_AR");

            migrationBuilder.RenameColumn(
                name: "MinistryEncode",
                table: "AppLanguage",
                newName: "MINISTRY_ENCODE");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "AppIdentifier_Type",
                newName: "Name_En");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "AppIdentifier_Type",
                newName: "Name_Ar");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "AppDepartment",
                newName: "Name_En");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "AppDepartment",
                newName: "Name_Ar");

            migrationBuilder.RenameColumn(
                name: "MinistryEncode",
                table: "AppDepartment",
                newName: "Ministry_Encode");

            migrationBuilder.RenameColumn(
                name: "DegreeNameEn",
                table: "AppDepartment",
                newName: "Degree_Name_En");

            migrationBuilder.RenameColumn(
                name: "DegreeNameAr",
                table: "AppDepartment",
                newName: "Degree_Name_Ar");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "AppCountry",
                newName: "Name_En");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "AppCountry",
                newName: "Name_Ar");

            migrationBuilder.RenameColumn(
                name: "MinistryEncode",
                table: "AppCountry",
                newName: "Ministry_Encode");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "AppContinent",
                newName: "Name_En");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "AppContinent",
                newName: "Name_Ar");

            migrationBuilder.RenameColumn(
                name: "MinistryEncode",
                table: "AppContinent",
                newName: "Ministry_Encode");

            migrationBuilder.RenameColumn(
                name: "UnivSectionId",
                table: "AppCollage",
                newName: "Univ_Section_FK");

            migrationBuilder.RenameColumn(
                name: "NumYear",
                table: "AppCollage",
                newName: "Univ_SectionId");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "AppCollage",
                newName: "Name_En");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "AppCollage",
                newName: "Name_Ar");

            migrationBuilder.RenameColumn(
                name: "MinistryEncode",
                table: "AppCollage",
                newName: "Num_Year");

            migrationBuilder.RenameColumn(
                name: "DegreeNameEn",
                table: "AppCollage",
                newName: "Degree_Name_En");

            migrationBuilder.RenameColumn(
                name: "DegreeNameAr",
                table: "AppCollage",
                newName: "Degree_Name_Ar");

            migrationBuilder.RenameColumn(
                name: "DeanEn",
                table: "AppCollage",
                newName: "Dean_En");

            migrationBuilder.RenameColumn(
                name: "DeanAr",
                table: "AppCollage",
                newName: "Dean_Ar");

            migrationBuilder.RenameColumn(
                name: "CollTypeId",
                table: "AppCollage",
                newName: "Ministry_Encode");

            migrationBuilder.RenameColumn(
                name: "MinistryEncode",
                table: "AppColl_Type",
                newName: "Ministry_Encode");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "AppClass",
                newName: "Name_En");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "AppClass",
                newName: "Name_Ar");

            migrationBuilder.RenameColumn(
                name: "PhoneCode",
                table: "AppCity",
                newName: "Phone_Code");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "AppCity",
                newName: "Name_En");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "AppCity",
                newName: "Name_Ar");

            migrationBuilder.RenameColumn(
                name: "MinistryEncode",
                table: "AppCity",
                newName: "Ministry_Encode");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "AppBranch",
                newName: "Name_En");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "AppBranch",
                newName: "Name_Ar");

            migrationBuilder.RenameColumn(
                name: "MinistryEncode",
                table: "AppBranch",
                newName: "Ministry_Encode");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "AppAdmission_Kind",
                newName: "Name_En");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "AppAdmission_Kind",
                newName: "Name_Ar");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "AppAdmission",
                newName: "Name_En");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "AppAdmission",
                newName: "Name_Ar");

            migrationBuilder.RenameColumn(
                name: "MinistryEncode",
                table: "AppAdmission",
                newName: "Ministry_Encode");

            migrationBuilder.RenameColumn(
                name: "FeeCalcTypeId",
                table: "AppAdmission",
                newName: "Fee_Calc_Type_FK");

            migrationBuilder.RenameColumn(
                name: "AdmissionKindId",
                table: "AppAdmission",
                newName: "Fee_Calc_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AppAdmission_AdmissionKindId",
                table: "AppAdmission",
                newName: "IX_AppAdmission_Fee_Calc_TypeId");

            migrationBuilder.AddColumn<int>(
                name: "Ministry_Encode",
                table: "AppUniv_Section",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Univ_FK",
                table: "AppUniv_Section",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Country_FK",
                table: "AppUniv",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ministry_Encode",
                table: "AppUniv",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ministry_Encode",
                table: "AppType_Lic_Branch",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Collage_FK",
                table: "AppDepartment",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Continent_FK",
                table: "AppCountry",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Coll_TypeId",
                table: "AppCollage",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Coll_Type_FK",
                table: "AppCollage",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Country_FK",
                table: "AppCity",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Department_FK",
                table: "AppBranch",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Adm_Kind_FK",
                table: "AppAdmission",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Admission_KindId",
                table: "AppAdmission",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUniv_Univ_TypeId",
                table: "AppUniv",
                column: "Univ_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppType_Lic_Branch_Type_LicId",
                table: "AppType_Lic_Branch",
                column: "Type_LicId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCollage_Coll_TypeId",
                table: "AppCollage",
                column: "Coll_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCollage_Univ_SectionId",
                table: "AppCollage",
                column: "Univ_SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppAdmission_Admission_KindId",
                table: "AppAdmission",
                column: "Admission_KindId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppAdmission_AppAdmission_Kind_Admission_KindId",
                table: "AppAdmission",
                column: "Admission_KindId",
                principalTable: "AppAdmission_Kind",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppAdmission_AppFee_Calc_Type_Fee_Calc_TypeId",
                table: "AppAdmission",
                column: "Fee_Calc_TypeId",
                principalTable: "AppFee_Calc_Type",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppCollage_AppColl_Type_Coll_TypeId",
                table: "AppCollage",
                column: "Coll_TypeId",
                principalTable: "AppColl_Type",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppCollage_AppUniv_Section_Univ_SectionId",
                table: "AppCollage",
                column: "Univ_SectionId",
                principalTable: "AppUniv_Section",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppType_Lic_Branch_AppType_Lic_Type_LicId",
                table: "AppType_Lic_Branch",
                column: "Type_LicId",
                principalTable: "AppType_Lic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUniv_AppUniv_Type_Univ_TypeId",
                table: "AppUniv",
                column: "Univ_TypeId",
                principalTable: "AppUniv_Type",
                principalColumn: "Id");
        }
    }
}
