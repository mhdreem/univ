using System;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain.Student.Admission;
using Univ.Hi_Student_Affairs.enums;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs.Domain.StdAdmission
{
    public class StdAdmission : FullAuditedAggregateRoot<Guid>
    {



        [ForeignKey("StudentId")]
        public Guid? StudentId { get; private set; }




        [ForeignKey("AdmissionID")]
        public int? AdmissionID { get; private set; }
        public virtual Admission? Admission { get; private set; }


        public int? Ord { get; private set; }


        //قبول حسب مجموع.اختصاص
        public Acceptance Acceptance { get; private set; }






        //رقم القبول بالمفاضلة
        public int? No { get; private set; }


        //تاريخ القبول
        [Column(TypeName = "Date")]
        public DateTime? Date { get; private set; }


        //المجموع الصافي
        public int? TotalMarkNet { get; private set; }

        //المجموع النهائي
        public int? TotalMark { get; private set; }


        //لغة التفاضيل

        public virtual Language? AdmissionLanguage { get; private set; }



        //لغة المختارة

        public virtual Language? Language { get; private set; }



        //علامة الاختصاص
        public uint? SubectMark { get; private set; }


        //علامة اللغة
        public int? LanguageMark { get; private set; }



        public string? Note { get; private set; }









    }
}

