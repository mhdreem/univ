using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Univ.Hi_Student_Affairs.Migrations
{
    /// <inheritdoc />
    public partial class Init_Table_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppAdmission_Kind",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Name_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAdmission_Kind", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Name_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppColl_Type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ministry_Encode = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppColl_Type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppContinent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Name_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ministry_Encode = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppContinent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppFee_Calc_Type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppFee_Calc_Type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppIdentifier_Type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Name_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppIdentifier_Type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppLanguage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NAME_AR = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NAME_EN = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    MINISTRY_ENCODE = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    BARCODE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppLanguage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppNationality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Name_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ministry_Encode = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppNationality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppSemester",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Name_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Grade_Name_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Grade_Name_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSemester", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppType_Lic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Name_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ministry_Encode = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppType_Lic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUniv_Type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NAME_AR = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NAME_EN = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUniv_Type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppCountry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Name_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Continent_FK = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ministry_Encode = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ContinentId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCountry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCountry_AppContinent_ContinentId",
                        column: x => x.ContinentId,
                        principalTable: "AppContinent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppAdmission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Name_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Adm_Kind_FK = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ministry_Encode = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Fee_Calc_Type_FK = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Admission_KindId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Fee_Calc_TypeId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAdmission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppAdmission_AppAdmission_Kind_Admission_KindId",
                        column: x => x.Admission_KindId,
                        principalTable: "AppAdmission_Kind",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppAdmission_AppFee_Calc_Type_Fee_Calc_TypeId",
                        column: x => x.Fee_Calc_TypeId,
                        principalTable: "AppFee_Calc_Type",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppType_Lic_Branch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Name_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Type_Lic_FK = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ministry_Encode = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Type_LicId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppType_Lic_Branch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppType_Lic_Branch_AppType_Lic_Type_LicId",
                        column: x => x.Type_LicId,
                        principalTable: "AppType_Lic",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppUniv",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Name_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Country_FK = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Univ_Type_FK = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ministry_Encode = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Univ_Encode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Univ_TypeId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUniv", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUniv_AppUniv_Type_Univ_TypeId",
                        column: x => x.Univ_TypeId,
                        principalTable: "AppUniv_Type",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppCity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Name_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Country_FK = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Phone_Code = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ministry_Encode = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CountryId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCity_AppCountry_CountryId",
                        column: x => x.CountryId,
                        principalTable: "AppCountry",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppUniv_Section",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Name_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Univ_FK = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ministry_Encode = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Univ_Sec_Encode = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UnivId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUniv_Section", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUniv_Section_AppUniv_UnivId",
                        column: x => x.UnivId,
                        principalTable: "AppUniv",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppCollage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Name_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Dean_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Dean_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Num_Year = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Coll_Type_FK = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Univ_Section_FK = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Degree_Name_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Degree_Name_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ministry_Encode = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Coll_TypeId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Univ_SectionId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCollage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCollage_AppColl_Type_Coll_TypeId",
                        column: x => x.Coll_TypeId,
                        principalTable: "AppColl_Type",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppCollage_AppUniv_Section_Univ_SectionId",
                        column: x => x.Univ_SectionId,
                        principalTable: "AppUniv_Section",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppDepartment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Name_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Collage_FK = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Degree_Name_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Degree_Name_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ministry_Encode = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CollageId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDepartment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppDepartment_AppCollage_CollageId",
                        column: x => x.CollageId,
                        principalTable: "AppCollage",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppBranch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name_Ar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Name_En = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Department_FK = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ord = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Barcode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ministry_Encode = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    DepartmentId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBranch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppBranch_AppDepartment_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "AppDepartment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppAdmission_Admission_KindId",
                table: "AppAdmission",
                column: "Admission_KindId");

            migrationBuilder.CreateIndex(
                name: "IX_AppAdmission_Fee_Calc_TypeId",
                table: "AppAdmission",
                column: "Fee_Calc_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppBranch_DepartmentId",
                table: "AppBranch",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCity_CountryId",
                table: "AppCity",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCollage_Coll_TypeId",
                table: "AppCollage",
                column: "Coll_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCollage_Univ_SectionId",
                table: "AppCollage",
                column: "Univ_SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCountry_ContinentId",
                table: "AppCountry",
                column: "ContinentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppDepartment_CollageId",
                table: "AppDepartment",
                column: "CollageId");

            migrationBuilder.CreateIndex(
                name: "IX_AppType_Lic_Branch_Type_LicId",
                table: "AppType_Lic_Branch",
                column: "Type_LicId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUniv_Univ_TypeId",
                table: "AppUniv",
                column: "Univ_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUniv_Section_UnivId",
                table: "AppUniv_Section",
                column: "UnivId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppAdmission");

            migrationBuilder.DropTable(
                name: "AppBranch");

            migrationBuilder.DropTable(
                name: "AppCity");

            migrationBuilder.DropTable(
                name: "AppClass");

            migrationBuilder.DropTable(
                name: "AppIdentifier_Type");

            migrationBuilder.DropTable(
                name: "AppLanguage");

            migrationBuilder.DropTable(
                name: "AppNationality");

            migrationBuilder.DropTable(
                name: "AppSemester");

            migrationBuilder.DropTable(
                name: "AppType_Lic_Branch");

            migrationBuilder.DropTable(
                name: "AppAdmission_Kind");

            migrationBuilder.DropTable(
                name: "AppFee_Calc_Type");

            migrationBuilder.DropTable(
                name: "AppDepartment");

            migrationBuilder.DropTable(
                name: "AppCountry");

            migrationBuilder.DropTable(
                name: "AppType_Lic");

            migrationBuilder.DropTable(
                name: "AppCollage");

            migrationBuilder.DropTable(
                name: "AppContinent");

            migrationBuilder.DropTable(
                name: "AppColl_Type");

            migrationBuilder.DropTable(
                name: "AppUniv_Section");

            migrationBuilder.DropTable(
                name: "AppUniv");

            migrationBuilder.DropTable(
                name: "AppUniv_Type");
        }
    }
}
