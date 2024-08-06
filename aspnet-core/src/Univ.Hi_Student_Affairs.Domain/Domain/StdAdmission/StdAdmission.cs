using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs
{
    public class StdAdmission : FullAuditedAggregateRoot<Guid>
    {

        [ForeignKey("StudentId")]
        public Guid? StudentId { get; set; }
        public virtual Student? Student { get; set; }



        [ForeignKey("AdmissionID")]
        public int? AdmissionID { get; set; }
        public virtual Admission? Admission { get; set; }


        public int? Ord { get; set; }

        //قبول حسب مجموع.اختصاص
        public bool? AdmissionType { get; set; }




       

        //رقم القبول بالمفاضلة
        public int? No { get; set; }


        //تاريخ القبول
        [Column(TypeName = "Date")]
        public DateTime? Date{ get; set; }


        //المجموع الصافي
        public int? TotalMarkNet { get; set; }

        //المجموع النهائي
        public int? TotalMark { get; set; }


        //لغة التفاضيل
        [ForeignKey("AdmissionLanguageId")]
        public int? AdmissionLanguageId { get; set; }
        public virtual Language? AdmissionLanguage { get; set; }



        //لغة المختارة
        [ForeignKey("LanguageId")]
        public int? LanguageId { get; set; }
        public virtual Language? Language { get; set; }



        //علامة الاختصاص
        public uint? SubectMark{ get; set; }


        //علامة اللغة
        public int? LanguageMark { get; set; }

      

        public string? Note { get; set; }


    }
}

