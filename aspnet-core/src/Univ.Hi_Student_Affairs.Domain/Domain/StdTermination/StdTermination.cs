using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs
{
    public class StdTermination :FullAuditedAggregateRoot<Guid>
    {
        public TerminationState? TerminationState { get; set; }



        [ForeignKey("StudentId")]
        public Guid? StudentId { get; set; }
        public Student? Student { get; set; }



        [ForeignKey("TerminationOrderId")]
        public Guid? TerminationOrderId { get; set; }
        public TerminationOrder? TerminationOrder { get; set; }




        public string? No { get; set; }
        public DateTime? Date { get; set; }




        public int Year { get; set; }



        //الفصل الحالي
        public int? SemesterId { get; set; }
        [ForeignKey("SemesterId")]
        public virtual Semester? Semester { get; set; }


        [ForeignKey("PrevAdmissionId ")]
        public int? PrevAdmissionId { get; set; }
        public Admission? PrevAdmission{ get; set; }


        public string? Agent { get; set; }
        public string? AgentNo { get; set; }
        public string? AgentDate { get; set; }
        public string? AgentSource { get; set; }

        public Collection<StdTerminateStage>? StdTerminateStages { get; set; }

    }
}
