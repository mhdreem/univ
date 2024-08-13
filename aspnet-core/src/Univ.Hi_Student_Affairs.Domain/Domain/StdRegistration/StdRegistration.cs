using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain.Student;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs.Domain.StdRegistration
{
    public class StdRegistration : FullAuditedAggregateRoot<Guid>
    {


        public RegistrationState? RegistrationState { get; private set; }


        [ForeignKey("StudentId")]
        public Guid? StudentId { get; private set; }




        [ForeignKey("RegOrderId")]
        public Guid? RegOrderId { get; private set; }
        public RegOrder? RegOrder { get; private set; }




        public string? No { get; private set; }
        public DateTime? Date { get; private set; }

        public int Year { get; private set; }



        //الفصل الحالي
        [ForeignKey("SemesterId")]
        public int? SemesterId { get; private set; }

        public virtual Semester? Semester { get; private set; }



        public string? Agent { get; private set; }
        public string? AgentNo { get; private set; }
        public string? AgentDate { get; private set; }
        public string? AgentSource { get; private set; }


        public Collection<StdRegStage>? StdRegStages { get; private set; }

    }
}
