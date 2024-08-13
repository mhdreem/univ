using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain.Student;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs.Domain.StdAffiliation
{
    public class StdAffiliation : FullAuditedAggregateRoot<Guid>
    {

        public AffiliationState? AffiliationState { get; private set; }


        [ForeignKey("StudentId")]
        public Guid? StudentId { get; private set; }




        [ForeignKey("AffiliationOrderId")]
        public Guid? AffiliationOrderId { get; private set; }
        public AffiliationOrder? AffiliationOrder { get; private set; }



        public int? Year { get; private set; }


        //الفصل الحالي
        public int? SemesterId { get; private set; }
        [ForeignKey("SemesterId")]
        public virtual Semester? Semester { get; private set; }


        public string? Note { get; private set; }


        public Collection<StdAffiliationStage>? StdAffiliationStages { get; private set; }

    }
}
