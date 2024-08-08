using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.enums;
using Volo.Abp.Domain.Entities.Auditing;
using Univ.Hi_Student_Affairs.ValueObjects;

namespace Univ.Hi_Student_Affairs.Students
{
    public class StudentNew : FullAuditedAggregateRoot<int>
    {
        //الرقم الوزاري
        public string? StdMinistryId { get; set; }

        //الرقم الطالب ضمن الكلية
        public string? StdCollageId { get; set; }


        //الرقم الامتحاني
        public string? ExamCollageId { get; set; }
        //معلومات شخصية 
        public StudentInfo? StudentInfo { get; set; }
        //بلد الولادة
        [ForeignKey("CountryId")]
        public int? CountryId { get; set; }
        public virtual Country? Country { get; set; }



        //الجنسية
        [ForeignKey("NationalityId")]
        public int? NationalityId { get; set; }
        public virtual Nationality? Nationality { get; set; }

        //قيد النفوس

        [ForeignKey("CivilRegId")]
        public int? CivilRegId { get; set; }
        public virtual CivilReg? CivilReg { get; set; }


        //محافظة الولادة
        [ForeignKey("CityBirthId")]
        public int? CityBirthId { get; set; }
        public virtual City? CityBirth { get; set; }

        //العام الحالي
        public int? Year { get; set; }


        //نوع القبول
        [ForeignKey("AdmissionId")]
        public int? AdmissionId { get; set; }
        public virtual Admission? Admission { get; set; }



        //الكلية
        [ForeignKey("UnivId")]
        public int? UnivId { get; set; }
        public virtual Univ? Univ { get; set; }


        //الكلية
        [ForeignKey("UnivSectionId")]
        public int? UnivSectionId { get; set; }
        public virtual UnivSection? UnivSection { get; set; }



        //الكلية
        [ForeignKey("CollageId")]
        public int? CollageId { get; set; }

        public virtual Collage? Collage { get; set; }
        //ملاحظات
        [MaxLength(250)]
        public string? Note { get; set; }
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

        public virtual ICollection<StdLife>? StdLife { get; set; }

        public virtual ICollection<StdSeqStudy>? StdSeqStudies { get; set; }
        public virtual ICollection<StdSeqSum>? StdSeqSums { get; set; }


        public virtual ICollection<StdCertificate>? StdCertificates { get; set; }
        public virtual ICollection<StdAdmission>? StdAdmissions { get; set; }

        //عقوبات
        public virtual ICollection<PunishmentStudent>? PunishmentStudents { get; set; }


        //ارتباط
        public virtual ICollection<StdAffiliation>? StdAffiliations { get; set; }

        //تسجيل
        public virtual ICollection<StdRegistration>? StdRegistrations { get; set; }
        //تبرير الغياب
        public virtual ICollection<StdAbsence>? StdAbsences { get; set; }

        //فصل لاستنفاذ الفرص
        public virtual ICollection<StdTermination>? StdTerminations { get; set; }

        //تحويل متماثل        
        public virtual ICollection<StdSymTransform>? StdSymTransforms { get; set; }

        //تحويل
        public virtual ICollection<StdChangeCollage>? StdChangeCollages { get; set; }


        //أوائل معاهد
        public virtual ICollection<StdInstitute>? StdInstitutes { get; set; }


        //تعادل شهادة
        public virtual Collection<StdNonSyrianUniv>? StdNonSyrianUnives { get; set; }
        public StudentNew()
        {
            
        }

        private StudentNew(string stdMinistryId, string stdCollageId, string examCollageId,
            string firstNameAR, string firstNameEn, string lastNameAr, string lastNameEn,
            string fatherNameAr, string fatherNameEn, string motherNameAr, string motherNameEn,
           DateTime birthDate, Gender gender, int militaryId, int identifierTypeId, string identifier,
            string phone, string mobile, string address, string birthPlaceAr, string birthPlaceEn,
             string email, bool isForeign, bool isArab, byte[] photoData, int countryId, int nationalityId
             ,int civilRegId, int cityBirthId, int year, int admissionId, int univId, int univSectionId,
            int collageId, string note, int departmentId, int branchId, int classId, int statusId
            , int semesterId, int studyPlanId, bool fxed)
        {
            StdMinistryId = stdMinistryId;
            StdCollageId = stdCollageId;
            ExamCollageId = examCollageId;
            StudentInfo = StudentInfo.create(firstNameAR,
               firstNameEn, lastNameAr, lastNameEn, fatherNameAr, fatherNameEn, motherNameAr,
              motherNameEn, birthDate, gender, militaryId, identifierTypeId, identifier,
             phone, mobile, address, birthPlaceAr, birthPlaceEn, email,
             isForeign, isArab, photoData);

          CountryId= countryId;
            NationalityId= nationalityId;
            CivilRegId=civilRegId;
            CityBirthId = cityBirthId;
            Year = year;
            AdmissionId = admissionId;
            UnivId = univId;
            UnivSectionId= univSectionId;
            CollageId = collageId;
            Note = note;
            DepartmentId = departmentId;
            BranchId = branchId;
            ClassId = classId;
            StatusId = statusId;
            SemesterId = semesterId;
            StudyPlanId = studyPlanId;
            Fixed = fxed;
            PunishmentStudents = new List<PunishmentStudent>();
            StdLife = new List<StdLife>();
            StdSeqStudies = new List<StdSeqStudy>();
            StdSeqSums = new List<StdSeqSum>();
            StdCertificates = new List<StdCertificate>();
            StdAdmissions = new List<StdAdmission>();
            StdAffiliations = new List<StdAffiliation>();
            StdRegistrations = new List<StdRegistration>();

        }
        public static StudentNew create(string stdMinistryId, string stdCollageId, string examCollageId,
            string firstNameAR, string firstNameEn, string lastNameAr, string lastNameEn,
            string fatherNameAr, string fatherNameEn, string motherNameAr, string motherNameEn,
           DateTime birthDate, Gender gender, int militaryId, int identifierTypeId, string identifier,
            string phone, string mobile, string address, string birthPlaceAr, string birthPlaceEn,
             string email, bool isForeign, bool isArab, byte[] photoData, int countryId, int nationalityId
             , int civilRegId, int cityBirthId, int year, int admissionId, int univId, int univSectionId,
            int collageId, string note, int departmentId, int branchId, int classId, int statusId
            , int semesterId, int studyPlanId, bool fxed)
        {
            return new StudentNew( stdMinistryId,  stdCollageId,  examCollageId,
             firstNameAR,  firstNameEn,  lastNameAr,  lastNameEn,
             fatherNameAr,  fatherNameEn,  motherNameAr,  motherNameEn,
            birthDate,  gender,  militaryId,  identifierTypeId,  identifier,
             phone,  mobile,  address,  birthPlaceAr,  birthPlaceEn,
              email,  isForeign,  isArab,  photoData,  countryId,  nationalityId
             ,  civilRegId,  cityBirthId,  year,  admissionId,  univId,  univSectionId,
             collageId,  note,  departmentId,  branchId,  classId,  statusId
            ,  semesterId,  studyPlanId,  fxed);
        }
        public void update(string stdMinistryId, string stdCollageId, string examCollageId,
            string firstNameAR, string firstNameEn, string lastNameAr, string lastNameEn,
            string fatherNameAr, string fatherNameEn, string motherNameAr, string motherNameEn,
           DateTime birthDate, Gender gender, int militaryId, int identifierTypeId, string identifier,
            string phone, string mobile, string address, string birthPlaceAr, string birthPlaceEn,
             string email, bool isForeign, bool isArab, byte[] photoData, int countryId, int nationalityId
             , int civilRegId, int cityBirthId, int year, int admissionId, int univId, int univSectionId,
            int collageId, string note, int departmentId, int branchId, int classId, int statusId
            , int semesterId, int studyPlanId, bool fxed)
        {
            StdMinistryId = stdMinistryId;
            StdCollageId = stdCollageId;
            ExamCollageId = examCollageId;
            StudentInfo?.update(firstNameAR,
             firstNameEn, lastNameAr, lastNameEn, fatherNameAr, fatherNameEn, motherNameAr,
            motherNameEn, birthDate, gender, militaryId, identifierTypeId, identifier,
           phone, mobile, address, birthPlaceAr, birthPlaceEn, email,
           isForeign, isArab, photoData);
            CountryId = countryId;
            NationalityId = nationalityId;
            CivilRegId = civilRegId;
            CityBirthId = cityBirthId;
            Year = year;
            AdmissionId = admissionId;
            UnivId = univId;
            UnivSectionId = univSectionId;
            CollageId = collageId;
            Note = note;
            DepartmentId = departmentId;
            BranchId = branchId;
            ClassId = classId;
            StatusId = statusId;
            SemesterId = semesterId;
            StudyPlanId = studyPlanId;
            Fixed = fxed;
        }
        public  void addPunishment(PunishmentState punishmentState, int punishmentId, int stdAbolitionId,
             PunishmentReasonEnum punishmentReason, int year, int classId, int semesterId, int yearEnd,
              int semesterEndId, string note)
        {
             PunishmentStudents?.Add(PunishmentStudent.create(punishmentState, punishmentId, stdAbolitionId, punishmentReason,
                year, classId, semesterId, yearEnd, semesterEndId, note));
        }
        public void updatePunishment(int punishmentStdId, PunishmentState punishmentState, int punishmentId, int stdAbolitionId,
             PunishmentReasonEnum punishmentReason, int year, int classId, int semesterId, int yearEnd,
              int semesterEndId, string note)
            {
                var punishmentStd = PunishmentStudents?.FirstOrDefault(ps => ps.Id == punishmentStdId);
                if (punishmentStd != null)
                {
                    punishmentStd.update(punishmentState, punishmentId, stdAbolitionId, punishmentReason,
                    year, classId, semesterId, yearEnd, semesterEndId, note);
                }
            }
    }
   
}
