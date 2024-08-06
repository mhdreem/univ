using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Univ.Hi_Student_Affairs.Dtos.Admission;
using Univ.Hi_Student_Affairs.Dtos.CivilReg;
using Univ.Hi_Student_Affairs.Dtos.Class;
using Univ.Hi_Student_Affairs.Dtos.Continent;
using Univ.Hi_Student_Affairs.Dtos.IdentifierType;
using Univ.Hi_Student_Affairs.Dtos.Jender;
using Univ.Hi_Student_Affairs.Dtos.Military;
using Univ.Hi_Student_Affairs.Dtos.Nationality;
using Univ.Hi_Student_Affairs.Dtos.Semester;
using Univ.Hi_Student_Affairs.Dtos.Status;
using Univ.Hi_Student_Affairs.Dtos.StdAbsence;
using Univ.Hi_Student_Affairs.Dtos.StdAdmission;
using Univ.Hi_Student_Affairs.Dtos.StdCertificate;
using Univ.Hi_Student_Affairs.Dtos.StdChangeCollage;
using Univ.Hi_Student_Affairs.Dtos.StdInstitute;
using Univ.Hi_Student_Affairs.Dtos.StdLife;
using Univ.Hi_Student_Affairs.Dtos.StdNonSyrianUniv;
using Univ.Hi_Student_Affairs.Dtos.StdPhoto;
using Univ.Hi_Student_Affairs.Dtos.StdPunishment;
using Univ.Hi_Student_Affairs.Dtos.StdRegistration;
using Univ.Hi_Student_Affairs.Dtos.StdSeqStudy;
using Univ.Hi_Student_Affairs.Dtos.StdSeqSum;
using Univ.Hi_Student_Affairs.Dtos.StdSymTransform;
using Univ.Hi_Student_Affairs.Dtos.StdTermination;
using Univ.Hi_Student_Affairs.Dtos.StudyPlan;
using Univ.Hi_Student_Affairs.Dtos.Univ;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos
{
    public class StudentDto : FullAuditedEntityDto<Guid>
    {
        //الرقم الوزاري
        public ulong? StdMinistryId { get; set; }

        //الرقم الطالب ضمن الكلية
        public ulong? StdCollageId { get; set; }


        //الرقم الامتحاني
        public string? ExamCollageId { get; set; }



        //بلد الولادة
        
        public int? CountryId { get; set; }
        public virtual CountryDto? Country { get; set; }



        //الجنسية
        
        public int? NationalityId { get; set; }
        public virtual NationalityDto? Nationality { get; set; }


        // الاسم
        [MaxLength(250)]
        public string? FirstNameAR { get; set; }


        [MaxLength(250)]
        public string? FirstNameEn { get; set; }

        // الكنية
        [MaxLength(250)]
        public string? LastNameAr { get; set; }
        // الكنية
        [MaxLength(250)]
        public string? LastNameEn { get; set; }


        // اسم الأب
        [MaxLength(250)]
        public string? FatherNameAr { get; set; }

        // اسم الأب
        [MaxLength(250)]
        public string? FatherNameEn { get; set; }

        // اسم الأم
        [MaxLength(250)]
        public string? MotherNameAr { get; set; }
        // اسم الأم
        [MaxLength(250)]
        public string? MotherNameEn { get; set; }


        //عام الميلاد
        public int? YearBirth { get; set; }
        //شهر الميلاد
        public int? MonthBirth { get; set; }
        //يوم الميلاد
        public int? DayBirth { get; set; }


        //الجنس
        public int? JenderId { get; set; }
        
        public virtual JenderDto? Jender { get; set; }



        //شعبة التجنيد
     
        public int? MilitaryId { get; set; }
        public virtual MilitaryDto? Military { get; set; }





        //الرقم الوطني


        public int? IdentifierTypeId { get; set; }
        public virtual IdentifierTypeDto? IdentifierType { get; set; }


        //الرقم الوطني
        [MaxLength(250)]
        public string? Identifier { get; set; }


        //الهاتف الارضي
        [MaxLength(250)]
        public string? Phone { get; set; }


        //الموبايل
        [MaxLength(250)]
        public string? Mobile { get; set; }



        //قيد النفوس

      
        public string? CivilRegId { get; set; }
        public virtual CivilRegDto? CivilReg { get; set; }



        //العنوان
        [MaxLength(250)]
        public string? Address { get; set; }


        //مكان الميلاد
        public string? BirthPlaceAr { get; set; }
        //مكان الولادة بالانكليزية
        public string? BirthPlaceEn { get; set; }



        //محافظة الولادة
        
        public int? CityBirthId { get; set; }
        public virtual CityDto? CityBirth { get; set; }



        [MaxLength(250)]
        public string? Email { get; set; }



        //ملاحظات
        [MaxLength(250)]
        public string? Note { get; set; }

        public bool? IsForeign { get; set; }

        public bool? IsArab { get; set; }


       
        public Guid? StdPhotoId { get; set; }
        public virtual StdPhotoDto? StdPhoto { get; set; }


        //العام الحالي
        public int? YEAR { get; set; }


        //نوع القبول
       
        public int? AdmissionId { get; set; }
        public virtual AdmissionDto? Admission { get; set; }



        //الكلية
        public int? UnivId { get; set; }
      
        public virtual UnivDto? Univ { get; set; }


        //الكلية
        public int? UnivSectionId { get; set; }
       
        public virtual UnivSectionDto? UnivSection { get; set; }



        //الكلية
        public int? CollageId { get; set; }

        public virtual CollageDto? Collage { get; set; }


        //الاختصاص
        public int? DepartmentId { get; set; }
   
        public virtual DepartmentDto? Department { get; set; }




        //القسم
        public int? BranchId { get; set; }
   
        public virtual BranchDto? Branch { get; set; }


        //السنة الدراسية الحالية
        public int? ClassId { get; set; }
 
        public virtual ClassDto? Class { get; set; }



        //الحالة
        public int? StatusId { get; set; }
       
        public virtual StatusDto? Status { get; set; }


        //الفصل الحالي
        public int? SemesterId { get; set; }
       
        public virtual SemesterDto? Semester { get; set; }








        //نظام الطالب
        public int? StudyPlanId { get; set; }
      
        public virtual StudyPlanDto? StudyPlan { get; set; }











        //مثبت
        public bool? Fixed { get; set; }

        public virtual Collection<StdLifeDto>? StdLife { get; set; }

        public virtual Collection<StdSeqStudyDto>? StdSeqStudies { get; set; }
        public virtual Collection<StdSeqSumDto>? StdSeqSums { get; set; }


        public virtual Collection<StdCertificateDto>? StdCertificates { get; set; }
        public virtual Collection<StdAdmissionDto>? StdAdmissions { get; set; }

        //عقوبات
        public virtual Collection<StdPunishmentDto>? StdPunishments { get; set; }


        //ارتباط
        public virtual Collection<StdAffiliationDto>? StdAffiliations { get; set; }

        //تسجيل
        public virtual Collection<StdRegistrationDto>? StdRegistrations { get; set; }
        //تبرير الغياب
        public virtual Collection<StdAbsenceDto>? StdAbsences { get; set; }

        //فصل لاستنفاذ الفرص
        public virtual Collection<StdTerminationDto>? StdTerminations { get; set; }



        //تحويل متماثل        
        public virtual Collection<StdSymTransformDto>? StdSymTransforms { get; set; }

        //تحويل
        public virtual Collection<StdChangeCollageDto>? StdChangeCollages { get; set; }


        //أوائل معاهد
        public virtual Collection<StdInstituteDto>? StdInstitutes { get; set; }


        //تعادل شهادة
        public virtual Collection<StdNonSyrianUnivDto>? StdNonSyrianUnives { get; set; }



    }

    public class CreateStudentDto 
    {
        //الرقم الوزاري
        public ulong? StdMinistryId { get; set; }

        //الرقم الطالب ضمن الكلية
        public ulong? StdCollageId { get; set; }


        //الرقم الامتحاني
        public string? ExamCollageId { get; set; }



        //بلد الولادة

        public int? CountryId { get; set; }
        public virtual CountryDto? Country { get; set; }



        //الجنسية

        public int? NationalityId { get; set; }
        public virtual NationalityDto? Nationality { get; set; }


        // الاسم
        [MaxLength(250)]
        public string? FirstNameAR { get; set; }


        [MaxLength(250)]
        public string? FirstNameEn { get; set; }

        // الكنية
        [MaxLength(250)]
        public string? LastNameAr { get; set; }
        // الكنية
        [MaxLength(250)]
        public string? LastNameEn { get; set; }


        // اسم الأب
        [MaxLength(250)]
        public string? FatherNameAr { get; set; }

        // اسم الأب
        [MaxLength(250)]
        public string? FatherNameEn { get; set; }

        // اسم الأم
        [MaxLength(250)]
        public string? MotherNameAr { get; set; }
        // اسم الأم
        [MaxLength(250)]
        public string? MotherNameEn { get; set; }


        //عام الميلاد
        public int? YearBirth { get; set; }
        //شهر الميلاد
        public int? MonthBirth { get; set; }
        //يوم الميلاد
        public int? DayBirth { get; set; }


        //الجنس
        public int? JenderId { get; set; }

        public virtual JenderDto? Jender { get; set; }



        //شعبة التجنيد

        public int? MilitaryId { get; set; }
        public virtual MilitaryDto? Military { get; set; }





        //الرقم الوطني


        public int? IdentifierTypeId { get; set; }
        public virtual IdentifierTypeDto? IdentifierType { get; set; }


        //الرقم الوطني
        [MaxLength(250)]
        public string? Identifier { get; set; }


        //الهاتف الارضي
        [MaxLength(250)]
        public string? Phone { get; set; }


        //الموبايل
        [MaxLength(250)]
        public string? Mobile { get; set; }



        //قيد النفوس


        public string? CivilRegId { get; set; }
        public virtual CivilRegDto? CivilReg { get; set; }



        //العنوان
        [MaxLength(250)]
        public string? Address { get; set; }


        //مكان الميلاد
        public string? BirthPlaceAr { get; set; }
        //مكان الولادة بالانكليزية
        public string? BirthPlaceEn { get; set; }



        //محافظة الولادة

        public int? CityBirthId { get; set; }
        public virtual CityDto? CityBirth { get; set; }



        [MaxLength(250)]
        public string? Email { get; set; }



        //ملاحظات
        [MaxLength(250)]
        public string? Note { get; set; }

        public bool? IsForeign { get; set; }

        public bool? IsArab { get; set; }



        public Guid? StdPhotoId { get; set; }
        public virtual StdPhotoDto? StdPhoto { get; set; }


        //العام الحالي
        public int? YEAR { get; set; }


        //نوع القبول

        public int? AdmissionId { get; set; }
        public virtual AdmissionDto? Admission { get; set; }



        //الكلية
        public int? UnivId { get; set; }

        public virtual UnivDto? Univ { get; set; }


        //الكلية
        public int? UnivSectionId { get; set; }

        public virtual UnivSectionDto? UnivSection { get; set; }



        //الكلية
        public int? CollageId { get; set; }

        public virtual CollageDto? Collage { get; set; }


        //الاختصاص
        public int? DepartmentId { get; set; }

        public virtual DepartmentDto? Department { get; set; }




        //القسم
        public int? BranchId { get; set; }

        public virtual BranchDto? Branch { get; set; }


        //السنة الدراسية الحالية
        public int? ClassId { get; set; }

        public virtual ClassDto? Class { get; set; }



        //الحالة
        public int? StatusId { get; set; }

        public virtual StatusDto? Status { get; set; }


        //الفصل الحالي
        public int? SemesterId { get; set; }

        public virtual SemesterDto? Semester { get; set; }








        //نظام الطالب
        public int? StudyPlanId { get; set; }

        public virtual StudyPlanDto? StudyPlan { get; set; }











        //مثبت
        public bool? Fixed { get; set; }




    }

    public class UpdateStudentDto : CreateStudentDto
    {
        public int Id { get; set; }
    }


    public class CheckStudentDto : EntityDto<Guid?>
    {
        //الرقم الوزاري
        public ulong? StdMinistryId { get; set; }

        //الرقم الطالب ضمن الكلية
        public ulong? StdCollageId { get; set; }


        //الرقم الامتحاني
        public string? ExamCollageId { get; set; }



        //بلد الولادة

        public int? CountryId { get; set; }
        public virtual CountryDto? Country { get; set; }



        //الجنسية

        public int? NationalityId { get; set; }
        public virtual NationalityDto? Nationality { get; set; }


        // الاسم
        [MaxLength(250)]
        public string? FirstNameAR { get; set; }


        [MaxLength(250)]
        public string? FirstNameEn { get; set; }

        // الكنية
        [MaxLength(250)]
        public string? LastNameAr { get; set; }
        // الكنية
        [MaxLength(250)]
        public string? LastNameEn { get; set; }


        // اسم الأب
        [MaxLength(250)]
        public string? FatherNameAr { get; set; }

        // اسم الأب
        [MaxLength(250)]
        public string? FatherNameEn { get; set; }

        // اسم الأم
        [MaxLength(250)]
        public string? MotherNameAr { get; set; }
        // اسم الأم
        [MaxLength(250)]
        public string? MotherNameEn { get; set; }


        //عام الميلاد
        public int? YearBirth { get; set; }
        //شهر الميلاد
        public int? MonthBirth { get; set; }
        //يوم الميلاد
        public int? DayBirth { get; set; }


        //الجنس
        public int? JenderId { get; set; }

        public virtual JenderDto? Jender { get; set; }



        //شعبة التجنيد

        public int? MilitaryId { get; set; }
        public virtual MilitaryDto? Military { get; set; }





        //الرقم الوطني


        public int? IdentifierTypeId { get; set; }
        public virtual IdentifierTypeDto? IdentifierType { get; set; }


        //الرقم الوطني
        [MaxLength(250)]
        public string? Identifier { get; set; }


        //الهاتف الارضي
        [MaxLength(250)]
        public string? Phone { get; set; }


        //الموبايل
        [MaxLength(250)]
        public string? Mobile { get; set; }



        //قيد النفوس


        public string? CivilRegId { get; set; }
        public virtual CivilRegDto? CivilReg { get; set; }



        //العنوان
        [MaxLength(250)]
        public string? Address { get; set; }


        //مكان الميلاد
        public string? BirthPlaceAr { get; set; }
        //مكان الولادة بالانكليزية
        public string? BirthPlaceEn { get; set; }



        //محافظة الولادة

        public int? CityBirthId { get; set; }
        public virtual CityDto? CityBirth { get; set; }



        [MaxLength(250)]
        public string? Email { get; set; }



        //ملاحظات
        [MaxLength(250)]
        public string? Note { get; set; }

        public bool? IsForeign { get; set; }

        public bool? IsArab { get; set; }



        public Guid? StdPhotoId { get; set; }
        public virtual StdPhotoDto? StdPhoto { get; set; }


        //العام الحالي
        public int? YEAR { get; set; }


        //نوع القبول

        public int? AdmissionId { get; set; }
        public virtual AdmissionDto? Admission { get; set; }



        //الكلية
        public int? UnivId { get; set; }

        public virtual UnivDto? Univ { get; set; }


        //الكلية
        public int? UnivSectionId { get; set; }

        public virtual UnivSectionDto? UnivSection { get; set; }



        //الكلية
        public int? CollageId { get; set; }

        public virtual CollageDto? Collage { get; set; }


        //الاختصاص
        public int? DepartmentId { get; set; }

        public virtual DepartmentDto? Department { get; set; }




        //القسم
        public int? BranchId { get; set; }

        public virtual BranchDto? Branch { get; set; }


        //السنة الدراسية الحالية
        public int? ClassId { get; set; }

        public virtual ClassDto? Class { get; set; }



        //الحالة
        public int? StatusId { get; set; }

        public virtual StatusDto? Status { get; set; }


        //الفصل الحالي
        public int? SemesterId { get; set; }

        public virtual SemesterDto? Semester { get; set; }








        //نظام الطالب
        public int? StudyPlanId { get; set; }

        public virtual StudyPlanDto? StudyPlan { get; set; }











        //مثبت
        public bool? Fixed { get; set; }




    }



    public class StudentPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public Dictionary<string, object> Filters { get; set; } = new Dictionary<string, object>();

    }




}
