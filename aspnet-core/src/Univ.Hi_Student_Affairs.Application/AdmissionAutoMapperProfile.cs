using AutoMapper;
using Univ.Hi_Student_Affairs.Domain.IdentifierType;
using Univ.Hi_Student_Affairs.Domain.StudyPlan;
using Univ.Hi_Student_Affairs.Domain.Univ;
using Univ.Hi_Student_Affairs.Dtos;
using Univ.Hi_Student_Affairs.Dtos.AbsenceOrder;
using Univ.Hi_Student_Affairs.Dtos.AbsenceStage;
using Univ.Hi_Student_Affairs.Dtos.Admission;
using Univ.Hi_Student_Affairs.Dtos.AdmissionKind;
using Univ.Hi_Student_Affairs.Dtos.AffiliationOrder;
using Univ.Hi_Student_Affairs.Dtos.AffiliationStage;
using Univ.Hi_Student_Affairs.Dtos.AverageCalc;
using Univ.Hi_Student_Affairs.Dtos.CivilReg;
using Univ.Hi_Student_Affairs.Dtos.Class;
using Univ.Hi_Student_Affairs.Dtos.CollType;
using Univ.Hi_Student_Affairs.Dtos.Continent;
using Univ.Hi_Student_Affairs.Dtos.Degree;
using Univ.Hi_Student_Affairs.Dtos.Deprivation;
using Univ.Hi_Student_Affairs.Dtos.Grade;
using Univ.Hi_Student_Affairs.Dtos.IdentifierType;
using Univ.Hi_Student_Affairs.Dtos.Jender;
using Univ.Hi_Student_Affairs.Dtos.Language;
using Univ.Hi_Student_Affairs.Dtos.Military;
using Univ.Hi_Student_Affairs.Dtos.Ministry;
using Univ.Hi_Student_Affairs.Dtos.Nationality;
using Univ.Hi_Student_Affairs.Dtos.Operation;
using Univ.Hi_Student_Affairs.Dtos.Punishment;
using Univ.Hi_Student_Affairs.Dtos.PunishmentReason;
using Univ.Hi_Student_Affairs.Dtos.PunishmentStage;
using Univ.Hi_Student_Affairs.Dtos.RegOrder;
using Univ.Hi_Student_Affairs.Dtos.RegStage;
using Univ.Hi_Student_Affairs.Dtos.Semester;
using Univ.Hi_Student_Affairs.Dtos.SeqResult;
using Univ.Hi_Student_Affairs.Dtos.SeqStatus;
using Univ.Hi_Student_Affairs.Dtos.Status;
using Univ.Hi_Student_Affairs.Dtos.StudyPlan;
using Univ.Hi_Student_Affairs.Dtos.TerminationOrder;
using Univ.Hi_Student_Affairs.Dtos.TerminationStage;
using Univ.Hi_Student_Affairs.Dtos.TypeLic;
using Univ.Hi_Student_Affairs.Dtos.Univ;
using Univ.Hi_Student_Affairs.Dtos.UnivType;

namespace Univ.Hi_Student_Affairs
{
    public  class AdmissionAutoMapperProfile : Profile 
    {
        public AdmissionAutoMapperProfile() {

            CreateMap<Admission, AdmissionDto>();
            CreateMap<AdmissionDto , Admission>();
            CreateMap<AdmissionPagedAndSortedResultRequestDto, AdmissionFilter>();
            //AdmissionKind
            CreateMap<AdmissionKind, AdmissionKindDto>();
            CreateMap<AdmissionKindDto, AdmissionKind>();
            CreateMap<AdmissionKindPagedAndSortedResultRequestDto, AdmissionKindFilter>();

            //CollType
            CreateMap<Continent, ContinentDto>();
            CreateMap<ContinentDto, Continent>();
            CreateMap<ContinentPagedAndSortedResultRequestDto, ContinentFilter>();


            //Country
            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();
            CreateMap<CountryPagedAndSortedResultRequestDto, CountryFilter>();

            //City
            CreateMap<City, CityDto>();
            CreateMap<CityDto, City>();
            CreateMap<UpdateCityDto, City>();

            //Semeseter
            CreateMap<Semester, SemesterDto>();
            CreateMap<SemesterDto, Semester>();
            CreateMap<SemesterPagedAndSortedResultRequestDto, SemesterFilter>();


            //CollType
            CreateMap<CollType, CollTypeDto>();
            CreateMap<CollTypeDto, CollType>();
            CreateMap<CollTypePagedAndSortedResultRequestDto, CollTypeFilter>();

           

            //AverageCalc
            CreateMap<AverageCalc, AverageCalcDto>();
            CreateMap<AverageCalcDto, AverageCalc>();
            CreateMap<AverageCalcPagedAndSortedResultRequestDto, AverageCalcFilter>();


            //Class
            CreateMap<Class, ClassDto>();
            CreateMap<ClassDto, Class>();
            CreateMap<ClassPagedAndSortedResultRequestDto, ClassFilter>();

           
            //Grade
            CreateMap<Grade, GradeDto>();
            CreateMap<GradeDto, Grade>();
            CreateMap<GradePagedAndSortedResultRequestDto, GradeFilter>();

            //IdentifierType
            CreateMap<IdentifierType, IdentifierTypeDto>();
            CreateMap<IdentifierTypeDto, IdentifierType>();
            CreateMap<IdentifierTypePagedAndSortedResultRequestDto, IdentifierTypeFilter>();


            //Jender
            CreateMap<Jender, JenderDto>();
            CreateMap<JenderDto, Jender>();
            CreateMap<JenderPagedAndSortedResultRequestDto, JenderFilter>();


            //Language
            CreateMap<Language, LanguageDto>();
            CreateMap<LanguageDto, Language>();
            CreateMap<LanguagePagedAndSortedResultRequestDto, LanguageFilter>();


            //Nationality
            CreateMap<Nationality, NationalityDto>();
            CreateMap<NationalityDto, Nationality>();
            CreateMap<NationalityPagedAndSortedResultRequestDto, NationalityFilter>();


            //Semester
            CreateMap<Semester, SemesterDto>();
            CreateMap<SemesterDto, Semester>();
            CreateMap<SemesterPagedAndSortedResultRequestDto, SemesterFilter>();


            //Semester
            CreateMap<StudyPlan, StudyPlanDto>();
            CreateMap<StudyPlanDto, StudyPlan>();
            CreateMap<StudyPlanPagedAndSortedResultRequestDto, StudyPlanFilter>();


            //TypeLic
            CreateMap<TypeLic, StudyPlanDto>();
            CreateMap<TypeLicDto, TypeLic>();
            CreateMap<TypeLicPagedAndSortedResultRequestDto, StudyPlanFilter>();


            //TypeLicBranch
            CreateMap<TypeLicBranch, TypeLicBranchDto>();
            CreateMap<TypeLicDto, TypeLicBranch>();
            CreateMap<TypeLicPagedAndSortedResultRequestDto, TypeLicFilter>();

            //UnivType
            CreateMap<UnivType, UnivTypeDto>();
            CreateMap<UnivTypeDto, UnivType>();
            CreateMap<UnivTypePagedAndSortedResultRequestDto, UnivTypeFilter>();

            //Univ
            CreateMap<UnivDto, Univ>();
            CreateMap<Univ, UnivDto>();
            CreateMap<UnivPagedAndSortedResultRequestDto, UnivFilter>();


            //UnivSection
            CreateMap<UnivSectionDto, UnivSection>();
            CreateMap<UnivSection, UnivSectionDto>();
            CreateMap<UnivSectionPagedAndSortedResultRequestDto, UnivSectionFilter>();

            //UnivSection
            CreateMap<CollageDto, Collage>();
            CreateMap<Collage, CollageDto>();
            CreateMap<CollagePagedAndSortedResultRequestDto, CollageFilter>();



            //Department
            CreateMap<DepartmentDto, Department>();
            CreateMap<Department, DepartmentDto>();
            CreateMap<DepartmentPagedAndSortedResultRequestDto, DepartmentFilter>();

            //Branch
            CreateMap<BranchDto, Branch>();
            CreateMap<Branch, BranchDto>();
            CreateMap<BranchPagedAndSortedResultRequestDto, BranchFilter>();



            //TerminationStage
            CreateMap<TerminationStageDto, TerminationStage>();
            CreateMap<TerminationStage, TerminationStageDto>();
            CreateMap<TerminationStagePagedAndSortedResultRequestDto, TerminationStageFilter>();

            //TerminationOrder
            CreateMap<TerminationOrderDto, TerminationOrder>();
            CreateMap<TerminationOrder, TerminationOrderDto>();
            CreateMap<TerminationOrderPagedAndSortedResultRequestDto, TerminationOrderFilter>();


            //AbsenceStage
            CreateMap<AbsenceStageDto, AbsenceStage>();
            CreateMap<AbsenceStage, AbsenceStageDto>();
            CreateMap<AbsenceStagePagedAndSortedResultRequestDto, AbsenceStageFilter>();

            //AbsenceOrder
            CreateMap<AbsenceOrderDto, AbsenceOrder>();
            CreateMap<AbsenceOrder, AbsenceOrderDto>();
            CreateMap<UpdateAbsenceOrderDto, AbsenceOrder>();
            CreateMap<AbsenceOrderPagedAndSortedResultRequestDto, AbsenceOrderFilter>();



            //AffiliationStage
            CreateMap<AffiliationStageDto, AffiliationStage>();            
            CreateMap<UpdateAffiliationStageDto, AffiliationStage>();
            CreateMap<AffiliationStage, AffiliationStageDto>();
            CreateMap<AffiliationStagePagedAndSortedResultRequestDto, AffiliationStageFilter>();


            //AffiliationOrder
            CreateMap<AffiliationOrderDto, AffiliationOrder>();
            CreateMap<AffiliationOrder, AffiliationOrderDto>();
            CreateMap<AffiliationOrderPagedAndSortedResultRequestDto, AffiliationOrderFilter>();

            //RegStage
            CreateMap<RegStageDto, RegStage>();
            CreateMap<RegStage, RegStageDto>();
            CreateMap<RegStagePagedAndSortedResultRequestDto, RegStageFilter>();

            //RegOrder
            CreateMap<RegOrderDto, RegOrder>();
            CreateMap<RegOrder, RegOrderDto>();
            CreateMap<RegOrderPagedAndSortedResultRequestDto, RegOrderFilter>();

            //PunishmentStage
            CreateMap<PunishmentStageDto, PunishmentStage>();
            CreateMap<PunishmentStage, PunishmentStageDto>();
            CreateMap<PunishmentStagePagedAndSortedResultRequestDto, PunishmentStageFilter>();


            //Punishment
            CreateMap<PunishmentDto, Punishment>();
            CreateMap<Punishment, PunishmentDto>();
            CreateMap<PunishmentPagedAndSortedResultRequestDto, PunishmentFilter>();

            //PunishmentReason
            CreateMap<PunishmentReasonDto, PunishmentReason>();
            CreateMap<PunishmentReason, PunishmentReasonDto>();
            CreateMap<PunishmentReasonPagedAndSortedResultRequestDto, PunishmentReasonFilter>();

            //SeqResult
            CreateMap<SeqResultDto, SeqResult>();
            CreateMap<SeqResult, SeqResultDto>();
            CreateMap<SeqResultPagedAndSortedResultRequestDto, SeqResultFilter>();


            //SeqStatus
            CreateMap<SeqStatusDto, SeqStatus>();
            CreateMap<SeqStatus, SeqStatusDto>();
            CreateMap<SeqStatusPagedAndSortedResultRequestDto, SeqStatusFilter>();

            //CivilReg
            CreateMap<CivilRegDto, CivilReg>();
            CreateMap<CivilReg, CivilRegDto>();
            CreateMap<CivilRegPagedAndSortedResultRequestDto, CivilRegFilter>();


            //Degree
            CreateMap<DegreeDto, Degree>();
            CreateMap<Degree, DegreeDto>();
            CreateMap<DegreePagedAndSortedResultRequestDto, DegreeFilter>();

            //Military
            CreateMap<MilitaryDto, Military>();
            CreateMap<Military, MilitaryDto>();
            CreateMap<MilitaryPagedAndSortedResultRequestDto, MilitaryFilter>();

            //Ministry
            CreateMap<MinistryDto, Ministry>();
            CreateMap<Ministry, MinistryDto>();
            CreateMap<MinistryPagedAndSortedResultRequestDto, MinistryFilter>();


            //Operation
            CreateMap<OperationDto, Operation>();
            CreateMap<Operation, OperationDto>();
            CreateMap<OperationPagedAndSortedResultRequestDto, OperationFilter>();

            //Deprivation
            CreateMap<DeprivationDto, Deprivation>();
            CreateMap<Deprivation, DeprivationDto>();
            CreateMap<DeprivationPagedAndSortedResultRequestDto, DeprivationFilter>();


            //Status
            CreateMap<StatusDto, Status>();
            CreateMap<Status, StatusDto>();
            CreateMap<StatusPagedAndSortedResultRequestDto, StatusFilter>();



            CreateMap<StudentDto, Student>();
            CreateMap<Student, StudentDto>();
            CreateMap<CreateStudentDto, Student>();
            CreateMap<UpdateStatusDto, Student>();
            CreateMap<Student, UpdateStatusDto>();














        }
    }
}
