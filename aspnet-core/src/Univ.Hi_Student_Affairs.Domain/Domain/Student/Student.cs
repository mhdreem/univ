using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain.StdSeqStudy;
using Univ.Hi_Student_Affairs.Domain.ValueObj;
using Univ.Hi_Student_Affairs.enums;
using Volo.Abp.Domain.Entities.Auditing;



namespace Univ.Hi_Student_Affairs.Domain.Student
{
    public class Student : FullAuditedAggregateRoot<Guid>
    {
        //جميع معلومات الارقام الجامعية هنا
        public StdNo StdNo { get; private set; }

        //جميع ذاتية الطالب هنا
        public StudentProfile studnetProfile { get; private set; }

        //جميع معلومات انتمائه للجامعة والكلية والقسم والسنة هنا
        public UniveInfo UniveInfo { get; private set; }


        //ملاحظات
        [MaxLength(250)]
        public string? Note { get; private set; }

        public bool? IsForeign { get; private set; }

        public bool? IsArab { get; private set; }

        public virtual Status? Status { get; private set; }


        //نظام الطالب
        [ForeignKey("StudyPlanId")]
        public int? StudyPlanId { get; private set; }











        //مثبت
        public bool? Fixed { get; private set; }

        public virtual Collection<StdLife.StdLife>? StdLife { get; private set; }

        public virtual Collection<StdSeqStudy.StdSeqStudy>? StdSeqStudies { get; private set; }
        public virtual Collection<StdSeqSum>? StdSeqSums { get; private set; }


        public virtual Collection<StdCertificate.StdCertificate>? StdCertificates { get; private set; }
        public virtual Collection<StdAdmission.StdAdmission>? StdAdmissions { get; private set; }

        //عقوبات
        public virtual Collection<StdPunishment.StdPunishment>? StdPunishments { get; private set; }


        //ارتباط
        public virtual Collection<StdAffiliation.StdAffiliation>? StdAffiliations { get; private set; }

        //تسجيل
        public virtual Collection<StdRegistration.StdRegistration>? StdRegistrations { get; private set; }
        //تبرير الغياب
        public virtual Collection<StdAbsence.StdAbsence>? StdAbsences { get; private set; }

        //فصل لاستنفاذ الفرص
        public virtual Collection<StdTermination.StdTermination>? StdTerminations { get; private set; }



        //تحويل متماثل        
        public virtual Collection<StdSymTransform.StdSymTransform>? StdSymTransforms { get; private set; }

        //تحويل
        public virtual Collection<StdChangeCollage.StdChangeCollage>? StdChangeCollages { get; private set; }


        //أوائل معاهد
        public virtual Collection<StdInstitute.StdInstitute>? StdInstitutes { get; private set; }


        //تعادل شهادة
        public virtual Collection<StdNonSyrianUniv>? StdNonSyrianUnives { get; private set; }




    }
}
