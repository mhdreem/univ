
using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain.ValueObj;
using Univ.Hi_Student_Affairs.enums;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs.Domain.StdSeqStudy
{
    public class StdSeqSum : FullAuditedAggregateRoot<Guid>
    {


        [ForeignKey("StudentId")]
        public Guid? StudentId { get; private set; }


        public UniveInfo UniveInfo { get; private set; }



        //الحالة

        public virtual Status? Status { get; private set; }



        //منيجة الطالب
        [ForeignKey("SeqResultId")]
        public int? SeqResultId { get; private set; }

        public virtual SeqResult? SeqResult { get; private set; }







        [ForeignKey("SeqStatusId")]
        public int? SeqStatusId { get; private set; }

        public virtual SeqStatus? SeqStatus { get; private set; }



        //مثبت
        public bool? Fixed { get; private set; }


        public Collection<StdSeqStudy>? StdSeqStudies { get; private set; }


    }
}
