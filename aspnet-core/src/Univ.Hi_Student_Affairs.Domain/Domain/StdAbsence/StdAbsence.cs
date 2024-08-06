using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs
{
    public class StdAbsence : FullAuditedAggregateRoot<Guid>
    {

       
      
        public AbsenceState? AbsenceState { get; set; }



        [ForeignKey("StudentId")]
        public Guid? StudentId { get; set; }
        public Student? Student { get; set; }



        [ForeignKey("AbsenceOrderId")]
        public Guid? AbsenceOrderId { get; set; }
        public AbsenceOrder? AbsenceOrder { get; set; }


        //سبب التبرير
        public string? Reason { get; set; }


        public int? YearFrom { get; set; }
        public int? YearTo { get; set; }

        //الفصل الحالي
        public int? SemesterFromId { get; set; }
        [ForeignKey("SemesterFromId")]
        public virtual Semester? SemesterFrom { get; set; }

        //الفصل الحالي
        public int? SemesterToId { get; set; }
        [ForeignKey("SemesterToId")]
        public virtual Semester? SemesterTo { get; set; }




        public string? Agent { get; set; }
        public string? AgentNo { get; set; }
        public string? AgentDate { get; set; }
        public string? AgentSource { get; set; }


        public string? Note { get; set; }


        public Collection<StdAbsenceStage>? StdAbsenceStages { get; set; }

    }
}

