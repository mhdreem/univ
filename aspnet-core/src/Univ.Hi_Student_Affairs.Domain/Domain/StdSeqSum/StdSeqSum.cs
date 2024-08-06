
using Microsoft.VisualBasic;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs
{
    public class StdSeqSum : FullAuditedAggregateRoot<Guid>
    {


        [ForeignKey("StudentId")]
        public Guid? StudentId { get; set; }
        public Student? Student { get; set; }



        //العام
        public uint? Year { get; set; }


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

        //الفصل الحالي
        [ForeignKey("SemesterId")]
        public int? SemesterId { get; set; }

        public virtual Semester? Semester { get; set; }




        //الحالة
        [ForeignKey("StatusId")]
        public int? StatusId { get; set; }

        public virtual Status? Status { get; set; }



        //منيجة الطالب
        [ForeignKey("SeqResultId")]
        public int? SeqResultId { get; set; }

        public virtual SeqResult? SeqResult { get; set; }







        [ForeignKey("SeqStatusId")]
        public int? SeqStatusId { get; set; }
        
        public virtual SeqStatus? SeqStatus { get; set; }

   

        //مثبت
        public bool? Fixed { get; set; }


        public Collection<StdSeqStudy>? StdSeqStudies { get; set; }


    }
}
