using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain.Student;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs.Domain.StdAbsence
{
    public class StdAbsence : FullAuditedAggregateRoot<Guid>
    {



        public AbsenceState? AbsenceState { get; private set; }



        [ForeignKey("StudentId")]
        public Guid? StudentId { get; private set; }




        [ForeignKey("AbsenceOrderId")]
        public Guid? AbsenceOrderId { get; private set; }
        public AbsenceOrder? AbsenceOrder { get; private set; }


        //سبب التبرير
        public string? Reason { get; private set; }


        public int? YearFrom { get; private set; }
        public int? YearTo { get; private set; }

        //الفصل الحالي
        public int? SemesterFromId { get; private set; }
        [ForeignKey("SemesterFromId")]
        public virtual Semester? SemesterFrom { get; private set; }

        //الفصل الحالي
        public int? SemesterToId { get; private set; }
        [ForeignKey("SemesterToId")]
        public virtual Semester? SemesterTo { get; private set; }



        //الوكيل
        public string? Agent { get; private set; }
        //رقم الوكيل
        public string? AgentNo { get; private set; }
        //تاريخ الوكالة
        public string? AgentDate { get; private set; }
        //مصدر الوكالة
        public string? AgentSource { get; private set; }


        public string? Note { get; private set; }


        public Collection<StdAbsenceStage>? StdAbsenceStages { get; private set; }

    }
}

