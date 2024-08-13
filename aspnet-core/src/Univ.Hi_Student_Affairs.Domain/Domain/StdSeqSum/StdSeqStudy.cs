
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain.ValueObj;
using Univ.Hi_Student_Affairs.enums;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs.Domain.StdSeqStudy
{
    public class StdSeqStudy : FullAuditedAggregateRoot<Guid>
    {
        [ForeignKey("StudentId")]
        public Guid? StudentId { get; private set; }


        public UniveInfo? UniveInfo { get; private set; }




        //الحالة

        public virtual Status? Status { get; private set; }



        //منيجة الطالب
        [ForeignKey("SeqResultId")]
        public int? SeqResultId { get; private set; }

        public virtual SeqResult? SeqResult { get; private set; }





        //مشترك بالامتحان ام لا
        public bool? TakeSemesterExam { get; private set; }


        //ملاحظات
        [MaxLength(250)]
        public string? Note { get; private set; }

        //الفصل محتسب ام لا
        public bool? IsSemesterCounted { get; private set; }




        //مثبت
        public bool? SEQ_CANCEL_CHEK { get; private set; }


    }
}
