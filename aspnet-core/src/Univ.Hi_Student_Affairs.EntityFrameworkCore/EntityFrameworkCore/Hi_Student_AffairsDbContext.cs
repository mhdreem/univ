using Microsoft.EntityFrameworkCore;
using Univ.Hi_Student_Affairs.Domain;
using Univ.Hi_Student_Affairs.Domain.Country;
using Univ.Hi_Student_Affairs.Domain.StdAbsence;
using Univ.Hi_Student_Affairs.Domain.StdAdmission;
using Univ.Hi_Student_Affairs.Domain.StdAffiliation;
using Univ.Hi_Student_Affairs.Domain.StdCertificate;
using Univ.Hi_Student_Affairs.Domain.StdChangeCollage;
using Univ.Hi_Student_Affairs.Domain.StdInstitute;
using Univ.Hi_Student_Affairs.Domain.StdLife;
using Univ.Hi_Student_Affairs.Domain.StdPunishment;
using Univ.Hi_Student_Affairs.Domain.StdRegistration;
using Univ.Hi_Student_Affairs.Domain.StdSeqStudy;
using Univ.Hi_Student_Affairs.Domain.StdSymTransform;
using Univ.Hi_Student_Affairs.Domain.StdTermination;
using Univ.Hi_Student_Affairs.Domain.Student;
using Univ.Hi_Student_Affairs.Domain.Student.Admission;
using Univ.Hi_Student_Affairs.Domain.TypeLic;
using Univ.Hi_Student_Affairs.Domain.Univ;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Univ.Hi_Student_Affairs.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class Hi_Student_AffairsDbContext :
    AbpDbContext<Hi_Student_AffairsDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }


    //القبول الجامعي
    public DbSet<Admission> Admissions { get; set; }
    //الشهادات
    public DbSet<TypeLic> Type_Lics { get; set; }
    //فروع الشهادات
    public DbSet<TypeLicBranch> Type_Lic_Branchs { get; set; }
    //المدن
    public DbSet<City> Cities { get; set; }
    //الدول
    public DbSet<Country> Countries { get; set; }
    //نوع الهويات
    public DbSet<IdentifierType> Identifier_Types { get; set; }
    //الفصول الدراسية
    public DbSet<Semester> Semesters { get; set; }
    //الاختصاص من القسم
    public DbSet<Branch> Branchs { get; set; }
    //السنوات الدراسية
    public DbSet<Class> Classes { get; set; }
    //الكليات
    public DbSet<Collage> Collages { get; set; }
    //الاقسام
    public DbSet<Department> Departments { get; set; }
    public DbSet<Univ.Hi_Student_Affairs.Domain.Univ.Univ> Univs { get; set; }
    public DbSet<UnivSection> Univ_Sections { get; set; }


    public DbSet<Student> Students { get; set; }
    public DbSet<StdSeqSum> StdSeqSums { get; set; }
    public DbSet<StdSeqStudy> StdSeqStudies { get; set; }



    //الحياة الجامعية
    public DbSet<StdLife> StdLifes { get; set; }
    //الشهادات الثانوية
    public DbSet<StdCertificate> StdCertificates { get; set; }
    //القبولات الجامعية
    public DbSet<StdAdmission> StdAdmissions { get; set; }




    //شعب التجنيد
    public DbSet<Military> Militaries { get; set; }


    //شعب النفوس بكل محافظة
    public DbSet<CivilReg> CivilRegs { get; set; }



    //العقوبات
    //سبب العقوبة
    public DbSet<PunishmentReason> PunishmentReasons { get; set; }
    //العقوبة
    public DbSet<Punishment> Punishments { get; set; }
    //مراحل العقوبة
    public DbSet<PunishmentStage> PunishmentStages { get; set; }
    //مراحل العقوبة التي اخذها الطالب
    public DbSet<StdPunishmentStage> StdPunishmentStages { get; set; }
    //عقوبات الطلاب
    public DbSet<StdPunishment> StdPunishments { get; set; }
    //إلغاء العقوبة
    public DbSet<StdAbolition> StdAbolitions { get; set; }
    //الحرمات
    public DbSet<Deprivation> Deprivations { get; set; }



    //تسجيل
    public DbSet<StdRegistration> StdRegistrations { get; set; }
    public DbSet<StdRegStage>? StdRegStages { get; set; }
    public DbSet<RegOrder>? RegOrders { get; set; }
    public DbSet<RegStage>? RegStages { get; set; }



    //ارتباط
    public DbSet<StdAffiliation>? StdAffiliations { get; set; }
    public DbSet<StdAffiliationStage>? StdAffiliationStages { get; set; }
    public DbSet<AffiliationOrder>? AffiliationOrders { get; set; }
    public DbSet<AffiliationStage>? AffiliationStages { get; set; }



    //تبرير الغياب
    public DbSet<StdAbsence>? StdAbsences { get; set; }
    public DbSet<StdAbsenceStage>? StdAbsenceStages { get; set; }
    public DbSet<AbsenceOrder>? AbsenceOrders { get; set; }
    public DbSet<AbsenceStage>? AbsenceStages { get; set; }


    //فصل لاستنفاذ الفرص
    public DbSet<StdTermination>? StdTerminations { get; set; }
    public DbSet<StdTerminateStage>? StdTerminateStages { get; set; }
    public DbSet<TerminationOrder>? TerminationOrders { get; set; }
    public DbSet<TerminationStage>? TerminationStages { get; set; }



    //تحويل متماثل        
    public DbSet<StdSymTransform>? StdSymTransforms { get; set; }
    public DbSet<StdSymTransformDet>? StdSymTransformDets { get; set; }

    //تحويل
    public DbSet<StdChangeCollage>? StdChangeCollages { get; set; }
    public DbSet<StdChangeCollageDet>? StdChangeCollageDets { get; set; }


    //أوائل معاهد
    public DbSet<StdInstitute>? StdInstitutes { get; set; }



    //تعادل شهادة
    public DbSet<StdNonSyrianUniv>? StdNonSyrianUnives { get; set; }
    public DbSet<StdNonSyrianUnivDet>? StdNonSyrianUnivDets { get; set; }



    #endregion

    public Hi_Student_AffairsDbContext(DbContextOptions<Hi_Student_AffairsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */


        builder.Entity<Admission>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "Admission", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });



        builder.Entity<TypeLic>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "TypeLic", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });



        builder.Entity<TypeLicBranch>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "TypeLicBranch", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<City>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "City", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
            b.Property(x => x.NameAr).IsRequired().HasMaxLength(256);
            b.Property(x => x.NameEn).IsRequired().HasMaxLength(256);
            // b.HasOne<Country>().WithMany().HasForeignKey(x => x.CountryId).IsRequired();

        });




        builder.Entity<Country>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "Country", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           

            b.Property(x => x.NameAr).IsRequired().HasMaxLength(256);
            b.Property(x => x.NameEn).IsRequired().HasMaxLength(256);


        });

        builder.Entity<IdentifierType>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "IdentifierType", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });





        builder.Entity<Semester>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "Semester", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<Univ.Hi_Student_Affairs.Domain.Univ.Univ>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "Univ", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           

            b.Property(x => x.NameAr).IsRequired().HasMaxLength(256);
            b.Property(x => x.NameEn).IsRequired().HasMaxLength(256);


        });

        builder.Entity<UnivSection>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "UnivSection", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           

            b.Property(x => x.NameAr).IsRequired().HasMaxLength(256);
            b.Property(x => x.NameEn).IsRequired().HasMaxLength(256);


        });


        builder.Entity<Collage>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "Collage", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           


            b.Property(x => x.NameAr).IsRequired().HasMaxLength(256);
            b.Property(x => x.NameEn).IsRequired().HasMaxLength(256);



        });

        builder.Entity<Department>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "Department", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           

            b.Property(x => x.NameAr).IsRequired().HasMaxLength(256);
            b.Property(x => x.NameEn).IsRequired().HasMaxLength(256);



        });


        builder.Entity<Branch>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "Branch", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<Class>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "Class", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });


        builder.Entity<CivilReg>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "CivilReg", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });




        builder.Entity<Deprivation>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "Deprivation", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });


        builder.Entity<Punishment>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "Punishment", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });


        builder.Entity<PunishmentStage>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "PunishmentStage", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });



        builder.Entity<PunishmentReason>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "PunishmentReason", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });




        builder.Entity<Military>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "Military", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });







        builder.Entity<StdSeqSum>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdSeqSum", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           


            // Configuring StudentProfile as an owned entity
            b.OwnsOne(s => s.UniveInfo, profile =>
            {
                profile.Property(o => o.UnivId)
                  .HasColumnName("UnivId");
                profile.Property(o => o.UnivSectionId)
                  .HasColumnName("UnivSectionId");
                profile.Property(o => o.CollageId)
                  .HasColumnName("CollageId");
                profile.Property(o => o.DepartmentId)
                  .HasColumnName("DepartmentId");
                profile.Property(o => o.SemesterId)
                  .HasColumnName("SemesterId");
                profile.Property(o => o.BranchId)
                  .HasColumnName("BranchId");
                profile.Property(o => o.ClassId)
                  .HasColumnName("ClassId");
                profile.Property(o => o.AdmissionId)
                  .HasColumnName("AdmissionId");





            });

        });

        builder.Entity<StdSeqStudy>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdSeqStudy", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
                                       //

            // Configuring StudentProfile as an owned entity
            b.OwnsOne(s => s.UniveInfo, profile =>
            {
                profile.Property(o => o.UnivId)
                  .HasColumnName("UnivId");
                profile.Property(o => o.UnivSectionId)
                  .HasColumnName("UnivSectionId");
                profile.Property(o => o.CollageId)
                  .HasColumnName("CollageId");
                profile.Property(o => o.DepartmentId)
                  .HasColumnName("DepartmentId");
                profile.Property(o => o.SemesterId)
                  .HasColumnName("SemesterId");
                profile.Property(o => o.BranchId)
                  .HasColumnName("BranchId");
                profile.Property(o => o.ClassId)
                  .HasColumnName("ClassId");
                profile.Property(o => o.AdmissionId)
                  .HasColumnName("AdmissionId");





            });
        });

        builder.Entity<StdRegistration>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdRegistration", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });


        builder.Entity<StdPunishment>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdPunishment", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<StdAbolition>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdAbolition", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });
        builder.Entity<StdAdmission>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdAdmission", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });
        builder.Entity<StdCertificate>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdCertificate", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<StdLife>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdLife", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });





        builder.Entity<PunishmentStage>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "PunishmentStage", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });


        builder.Entity<StdPunishment>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdPunishment", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });




        builder.Entity<StdRegistration>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdRegistration", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });


        builder.Entity<StdRegStage>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdRegStage", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<RegOrder>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "RegOrder", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<RegStage>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "RegStage", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<StdAffiliation>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdAffiliation", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<StdAffiliationStage>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdAffiliationStage", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<AffiliationOrder>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "AffiliationOrder", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<AffiliationStage>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "AffiliationStage", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<StdAbsence>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdAbsence", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<StdAbsenceStage>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdAbsenceStage", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<AbsenceOrder>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "AbsenceOrder", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<AbsenceStage>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "AbsenceStage", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<StdTermination>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdTermination", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<StdTerminateStage>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdTerminateStage", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });


        builder.Entity<TerminationOrder>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "TerminationOrder", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<TerminationStage>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "TerminationStage", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<StdSymTransform>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdSymTransform", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<StdSymTransformDet>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdSymTransformDet", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<StdChangeCollage>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdChangeCollage", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<StdChangeCollageDet>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdChangeCollageDet", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<StdInstitute>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdInstitute", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });


        builder.Entity<StdNonSyrianUniv>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdNonSyrianUniv", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<StdNonSyrianUnivDet>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdNonSyrianUnivDet", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<StdNonSyrianUnivDet>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "StdNonSyrianUnivDet", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           
        });

        builder.Entity<Student>(b =>
        {
            b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "Student", Hi_Student_AffairsConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props           


            // Configuring StudentProfile as an owned entity
            b.OwnsOne(s => s.studnetProfile, profile =>
            {
                // Configuring nested complex properties if necessary
                profile.Property(p => p.FirstNameAR).HasMaxLength(250);
                profile.Property(p => p.LastNameAr).HasMaxLength(250);
                profile.Property(p => p.FatherNameAr).HasMaxLength(250);
                profile.Property(p => p.MotherNameAr).HasMaxLength(250);
                profile.Property(p => p.Identifier).HasMaxLength(250);

                // Continue configuring other properties as needed

                profile.Property(o => o.FirstNameAR)
                .HasColumnName("FirstNameAR");
                profile.Property(o => o.LastNameAr)
                 .HasColumnName("LastNameAr");
                profile.Property(o => o.FatherNameAr)
                 .HasColumnName("FatherNameAr");
                profile.Property(o => o.MotherNameAr)
                .HasColumnName("MotherNameAr");
                profile.Property(o => o.Identifier)
               .HasColumnName("Identifier");
                profile.Property(o => o.IdentifierTypeId)
                 .HasColumnName("IdentifierTypeId");
                profile.Property(o => o.Jender)
               .HasColumnName("Jender");
                profile.Property(o => o.CountryId)
                .HasColumnName("CountryId");
                profile.Property(o => o.DayBirth)
                .HasColumnName("DayBirth");
                profile.Property(o => o.MonthBirth)
                .HasColumnName("MonthBirth");
                profile.Property(o => o.YearBirth)
                .HasColumnName("YearBirth");
                profile.Property(o => o.Nationality)
                .HasColumnName("Nationality");
                profile.Property(o => o.FirstNameEn)
                .HasColumnName("FirstNameEn");
                profile.Property(o => o.LastNameEn)
                .HasColumnName("LastNameEn");
                profile.Property(o => o.MotherNameEn)
                .HasColumnName("MotherNameEn");
                profile.Property(o => o.FatherNameEn)
                .HasColumnName("FatherNameEn"); ;

                // Ensure the Enum is stored as a byte
                profile.Property(e => e.Jender)
                 .HasConversion<byte>();




            });


            // Configuring StudentProfile as an owned entity
            b.OwnsOne(s => s.StdNo, profile =>
            {
                profile.Property(o => o.StdMinistryId)
                 .HasColumnName("StdMinistryId");
                profile.Property(o => o.ExamCollageId)
                 .HasColumnName("ExamCollageId");
                profile.Property(o => o.StdCollageId)
                 .HasColumnName("StdCollageId");

                // Continue configuring other properties as needed
            });

            // Configuring StudentProfile as an owned entity
            b.OwnsOne(s => s.UniveInfo, profile =>
            {
                profile.Property(o => o.UnivId)
                  .HasColumnName("UnivId");
                profile.Property(o => o.UnivSectionId)
                  .HasColumnName("UnivSectionId");
                profile.Property(o => o.CollageId)
                  .HasColumnName("CollageId");
                profile.Property(o => o.DepartmentId)
                  .HasColumnName("DepartmentId");
                profile.Property(o => o.SemesterId)
                  .HasColumnName("SemesterId");
                profile.Property(o => o.BranchId)
                  .HasColumnName("BranchId");
                profile.Property(o => o.ClassId)
                  .HasColumnName("ClassId");
                profile.Property(o => o.AdmissionId)
                  .HasColumnName("AdmissionId");





            });
        });


        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(Hi_Student_AffairsConsts.DbTablePrefix + "YourEntities", Hi_Student_AffairsConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});
    }
}
