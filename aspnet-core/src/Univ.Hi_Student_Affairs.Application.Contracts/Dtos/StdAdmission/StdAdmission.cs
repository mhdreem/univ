using System;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Dtos.Admission;
using Univ.Hi_Student_Affairs.Dtos.Language;
using Volo.Abp.Application.Dtos;


namespace Univ.Hi_Student_Affairs.Dtos.StdAdmission
{
    public class StdAdmissionDto : FullAuditedEntityDto<Guid>
    {

       
        public Guid? StudentId { get; set; }
        public virtual StudentDto? Student { get; set; }



       
        public int? AdmissionID { get; set; }
        public virtual AdmissionDto? Admission { get; set; }


        public int? Ord { get; set; }

        //قبول حسب مجموع.اختصاص
        public bool? AdmissionType { get; set; }






        //رقم القبول بالمفاضلة
        public int? No { get; set; }


        //تاريخ القبول
        [Column(TypeName = "Date")]
        public DateTime? Date { get; set; }


        //المجموع الصافي
        public int? TotalMarkNet { get; set; }

        //المجموع النهائي
        public int? TotalMark { get; set; }


        //لغة التفاضيل
       
        public int? AdmissionLanguageId { get; set; }
        public virtual LanguageDto? AdmissionLanguage { get; set; }



        //لغة المختارة

        public int? LanguageId { get; set; }
        public virtual LanguageDto? Language { get; set; }



        //علامة الاختصاص
        public uint? SubectMark { get; set; }


        //علامة اللغة
        public int? LanguageMark { get; set; }



        public string? Note { get; set; }


    }
}

