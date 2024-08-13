using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain.Student;
using Univ.Hi_Student_Affairs.Domain.Student.Admission;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs.Domain.StdTermination
{
    public class StdTermination : FullAuditedAggregateRoot<Guid>
    {
        public TerminationState? TerminationState { get; private set; }



        [ForeignKey("StudentId")]
        public Guid? StudentId { get; private set; }




        [ForeignKey("TerminationOrderId")]
        public Guid? TerminationOrderId { get; private set; }
        public TerminationOrder? TerminationOrder { get; private set; }




        public string? No { get; private set; }
        public DateTime? Date { get; private set; }




        public int Year { get; private set; }



        //الفصل الحالي
        public int? SemesterId { get; private set; }
        [ForeignKey("SemesterId")]
        public virtual Semester? Semester { get; private set; }


        [ForeignKey("PrevAdmissionId ")]
        public int? PrevAdmissionId { get; private set; }
        public Admission? PrevAdmission { get; private set; }


        public string? Agent { get; private set; }
        public string? AgentNo { get; private set; }
        public string? AgentDate { get; private set; }
        public string? AgentSource { get; private set; }

        public Collection<StdTerminateStage>? StdTerminateStages { get; private set; }

    }
}
