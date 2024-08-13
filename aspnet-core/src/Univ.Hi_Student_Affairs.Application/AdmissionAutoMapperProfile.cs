using AutoMapper;
using Univ.Hi_Student_Affairs.Domain.Country;
using Univ.Hi_Student_Affairs.Domain.StdAbsence;
using Univ.Hi_Student_Affairs.Domain.StdAffiliation;
using Univ.Hi_Student_Affairs.Domain.StdPunishment;
using Univ.Hi_Student_Affairs.Domain.StdRegistration;
using Univ.Hi_Student_Affairs.Domain.StdTermination;
using Univ.Hi_Student_Affairs.Domain.Student;
using Univ.Hi_Student_Affairs.Domain.Student.Admission;
using Univ.Hi_Student_Affairs.Domain.TypeLic;
using Univ.Hi_Student_Affairs.Domain.Univ;
using Univ.Hi_Student_Affairs.Dtos;
using Univ.Hi_Student_Affairs.Dtos.AbsenceOrder;
using Univ.Hi_Student_Affairs.Dtos.AbsenceStage;
using Univ.Hi_Student_Affairs.Dtos.Admission;
using Univ.Hi_Student_Affairs.Dtos.AffiliationOrder;
using Univ.Hi_Student_Affairs.Dtos.AffiliationStage;
using Univ.Hi_Student_Affairs.Dtos.CivilReg;
using Univ.Hi_Student_Affairs.Dtos.Class;
using Univ.Hi_Student_Affairs.Dtos.DomainCountry;
using Univ.Hi_Student_Affairs.Dtos.DomainPunishment;
using Univ.Hi_Student_Affairs.Dtos.Grade;
using Univ.Hi_Student_Affairs.Dtos.IdentifierType;
using Univ.Hi_Student_Affairs.Dtos.Military;
using Univ.Hi_Student_Affairs.Dtos.Ministry;
using Univ.Hi_Student_Affairs.Dtos.Operation;
using Univ.Hi_Student_Affairs.Dtos.RegOrder;
using Univ.Hi_Student_Affairs.Dtos.RegStage;
using Univ.Hi_Student_Affairs.Dtos.Semester;
using Univ.Hi_Student_Affairs.Dtos.Status;
using Univ.Hi_Student_Affairs.Dtos.StudyPlan;
using Univ.Hi_Student_Affairs.Dtos.TerminationOrder;
using Univ.Hi_Student_Affairs.Dtos.TerminationStage;
using Univ.Hi_Student_Affairs.Dtos.TypeLic;
using Univ.Hi_Student_Affairs.Dtos.Univ;
using Univ.Hi_Student_Affairs.Dtos.UnivType;
using Univ.Hi_Student_Affairs.enums;

namespace Univ.Hi_Student_Affairs
{
    public class AdmissionAutoMapperProfile : Profile
    {
        public AdmissionAutoMapperProfile()
        {

            CreateMap<Admission, AdmissionDto>();
            CreateMap<AdmissionDto, Admission>();




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







            //Class
            CreateMap<Class, ClassDto>();
            CreateMap<ClassDto, Class>();



            //Grade
            CreateMap<Grade, GradeDto>();
            CreateMap<GradeDto, Grade>();


            //IdentifierType
            CreateMap<IdentifierType, IdentifierTypeDto>();
            CreateMap<IdentifierTypeDto, IdentifierType>();









            //Semester
            CreateMap<Semester, SemesterDto>();
            CreateMap<SemesterDto, Semester>();



            //Semester
            CreateMap<StudyPlan, StudyPlanDto>();
            CreateMap<StudyPlanDto, StudyPlan>();



            //TypeLic
            CreateMap<TypeLic, StudyPlanDto>();
            CreateMap<TypeLicDto, TypeLic>();



            //TypeLicBranch
            CreateMap<TypeLicBranch, TypeLicBranchDto>();
            CreateMap<TypeLicDto, TypeLicBranch>();


            //UnivType
            CreateMap<UnivType, UnivTypeDto>();
            CreateMap<UnivTypeDto, UnivType>();
            CreateMap<UnivTypePagedAndSortedResultRequestDto, UnivTypeFilter>();

            //Univ
            CreateMap<UnivDto, Univ.Hi_Student_Affairs.Domain.Univ.Univ>();
            CreateMap<Univ.Hi_Student_Affairs.Domain.Univ.Univ, UnivDto>();
            


            //UnivSection
            CreateMap<UnivSectionDto, UnivSection>();
            CreateMap<UnivSection, UnivSectionDto>();
            

            //UnivSection
            CreateMap<CollageDto, Collage>();
            CreateMap<Collage, CollageDto>();
            



            //Department
            CreateMap<DepartmentDto, Department>();
            CreateMap<Department, DepartmentDto>();
            

            //Branch
            CreateMap<BranchDto, Branch>();
            CreateMap<Branch, BranchDto>();
            



            //TerminationStage
            CreateMap<TerminationStageDto, TerminationStage>();
            CreateMap<TerminationStage, TerminationStageDto>();


            //TerminationOrder
            CreateMap<TerminationOrderDto, TerminationOrder>();
            CreateMap<TerminationOrder, TerminationOrderDto>();



            //AbsenceStage
            CreateMap<AbsenceStageDto, AbsenceStage>();
            CreateMap<AbsenceStage, AbsenceStageDto>();


            //AbsenceOrder
            CreateMap<AbsenceOrderDto, AbsenceOrder>();
            CreateMap<AbsenceOrder, AbsenceOrderDto>();
            CreateMap<UpdateAbsenceOrderDto, AbsenceOrder>();




            //AffiliationStage
            CreateMap<AffiliationStageDto, AffiliationStage>();
            CreateMap<UpdateAffiliationStageDto, AffiliationStage>();
            CreateMap<AffiliationStage, AffiliationStageDto>();


            //AffiliationOrder
            CreateMap<AffiliationOrderDto, AffiliationOrder>();
            CreateMap<AffiliationOrder, AffiliationOrderDto>();

            //RegStage
            CreateMap<RegStageDto, RegStage>();
            CreateMap<RegStage, RegStageDto>();

            //RegOrder
            CreateMap<RegOrderDto, RegOrder>();
            CreateMap<RegOrder, RegOrderDto>();


            //PunishmentStage
            CreateMap<PunishmentStageDto, PunishmentStage>();
            CreateMap<PunishmentStage, PunishmentStageDto>();


            //Punishment
            CreateMap<PunishmentDto, Punishment>();
            CreateMap<Punishment, PunishmentDto>();

            //PunishmentReason
            CreateMap<PunishmentReasonDto, PunishmentReason>();
            CreateMap<PunishmentReason, PunishmentReasonDto>();

            //CivilReg
            CreateMap<CivilRegDto, CivilReg>();
            CreateMap<CivilReg, CivilRegDto>();



            //Military
            CreateMap<MilitaryDto, Military>();
            CreateMap<Military, MilitaryDto>();

            //Ministry
            CreateMap<MinistryDto, Ministry>();
            CreateMap<Ministry, MinistryDto>();


            //Operation
            CreateMap<OperationDto, Operation>();
            CreateMap<Operation, OperationDto>();

            //Deprivation
            CreateMap<DeprivationDto, Deprivation>();
            CreateMap<Deprivation, DeprivationDto>();





            CreateMap<StudentDto, Student>();
            CreateMap<Student, StudentDto>();
            CreateMap<CreateStudentDto, Student>();
            CreateMap<UpdateStatusDto, Student>();
            CreateMap<Student, UpdateStatusDto>();














        }
    }
}
