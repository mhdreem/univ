using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;


namespace Univ.Hi_Student_Affairs
{
    public class Student : FullAuditedAggregateRoot<Guid>
    {
        //الرقم الوزاري
        public ulong? StdMinistryId { get; set; }

        //الرقم الطالب ضمن الكلية
        public ulong? StdCollageId { get; set; }


        //الرقم الامتحاني
        public string? ExamCollageId { get; set; }



        //بلد الولادة
        [ForeignKey("CountryId")]
        public int? CountryId { get; set; }        
        public virtual Country? Country { get; set; }



        //الجنسية
        [ForeignKey("NationalityId")]
        public int? NationalityId { get; set; }        
        public virtual Nationality? Nationality { get; set; }


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
        [ForeignKey("JenderId")]
        public virtual Jender? Jender { get; set; }



        //شعبة التجنيد
        [ForeignKey("MilitaryId")]
        public int? MilitaryId { get; set; }
        public virtual Military? Military { get; set; }



      

        //الرقم الوطني
        
        [ForeignKey("IdentifierTypeId")]
        public int? IdentifierTypeId { get; set; }
        public virtual IdentifierType? IdentifierType { get; set; }


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

        [ForeignKey("CivilRegId")]
        public string? CivilRegId { get; set; }
        public virtual CivilReg? CivilReg { get; set; }



        //العنوان
        [MaxLength(250)]
        public string? Address { get; set; }


        //مكان الميلاد
        public string? BirthPlaceAr { get; set; }
        //مكان الولادة بالانكليزية
        public string? BirthPlaceEn { get; set; }



        //محافظة الولادة
        [ForeignKey("CityBirthId")]
        public int? CityBirthId { get; set; }        
        public virtual City? CityBirth { get; set; }


        
        [MaxLength(250)]
        public string? Email { get; set; }


         
        //ملاحظات
        [MaxLength(250)]
        public string? Note { get; set; }

        public bool? IsForeign { get; set; }

        public bool? IsArab { get; set; }


        [ForeignKey("StdPhotoId")]
        public Guid? StdPhotoId { get; set; }
        public virtual StdPhoto? StdPhoto { get; set; }
       

        //العام الحالي
        public int? YEAR { get; set; }


        //نوع القبول
        [ForeignKey("AdmissionId")]
        public int? AdmissionId { get; set; }
        public virtual Admission? Admission { get; set; }



        //الكلية
        [ForeignKey("UnivId")]
        public int? UnivId { get; set; }        
        public virtual Univ? Univ{ get; set; }


        //الكلية
        [ForeignKey("UnivSectionId")]
        public int? UnivSectionId { get; set; }       
        public virtual UnivSection? UnivSection { get; set; }



        //الكلية
        [ForeignKey("CollageId")]
        public int? CollageId { get; set; }
        
        public virtual Collage? Collage { get; set; }


        //الاختصاص
        [ForeignKey("DepartmentId")]
        public int? DepartmentId { get; set; }
        
        public virtual Department? Department { get; set; }




        //القسم
        [ForeignKey("BranchId")]
        public int? BranchId { get; set; }
        
        public virtual Branch? Branch { get; set; }


        //السنة الدراسية الحالية
        [ForeignKey("ClassId")]
        public int? ClassId { get; set; }
        
        public virtual Class? Class { get; set; }



        //الحالة
        [ForeignKey("StatusId")]
        public int? StatusId { get; set; }        
        public virtual Status? Status { get; set; }


        //الفصل الحالي
        [ForeignKey("SemesterId")]
        public int? SemesterId { get; set; }
        
        public virtual Semester? Semester { get; set; }








        //نظام الطالب
        [ForeignKey("StudyPlanId")]
        public int? StudyPlanId { get; set; }
        
        public virtual StudyPlan? StudyPlan { get; set; }



       
       


       



        //مثبت
        public bool? Fixed { get; set; }

        public virtual Collection<StdLife>? StdLife { get; set; }

        public virtual Collection<StdSeqStudy>? StdSeqStudies { get; set; }
        public virtual Collection<StdSeqSum>? StdSeqSums { get; set; }
        

        public virtual Collection<StdCertificate>? StdCertificates { get; set; }
        public virtual Collection<StdAdmission>? StdAdmissions { get; set; }

        //عقوبات
        public virtual Collection<StdPunishment>? StdPunishments { get; set; }


        //ارتباط
        public virtual Collection<StdAffiliation>? StdAffiliations { get; set; }
      
        //تسجيل
        public virtual Collection<StdRegistration>? StdRegistrations { get; set; }
        //تبرير الغياب
        public virtual Collection<StdAbsence>? StdAbsences { get; set; }

        //فصل لاستنفاذ الفرص
        public virtual Collection<StdTermination>? StdTerminations { get; set; }



        //تحويل متماثل        
        public virtual Collection<StdSymTransform>? StdSymTransforms { get; set; }

        //تحويل
        public virtual Collection<StdChangeCollage>? StdChangeCollages { get; set; }


        //أوائل معاهد
        public virtual Collection<StdInstitute>? StdInstitutes { get; set; }


        //تعادل شهادة
        public virtual Collection<StdNonSyrianUniv>? StdNonSyrianUnives { get; set; }


        
      
    }
}
