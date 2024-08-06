using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
namespace Univ.Hi_Student_Affairs
{
    public class StdAffiliation : FullAuditedAggregateRoot<Guid>
    {


        public AffiliationState? AffiliationState { get; set; }


        [ForeignKey("StudentId")]
        public Guid? StudentId { get; set; }
        public Student? Student { get; set; }



        [ForeignKey("AffiliationOrderId")]
        public Guid? AffiliationOrderId { get; set; }
        public AffiliationOrder? AffiliationOrder { get; set; }



        public int? Year { get; set; }


        //الفصل الحالي
        public int? SemesterId { get; set; }
        [ForeignKey("SemesterId")]
        public virtual Semester? Semester { get; set; }


        public string? Note { get; set; }


        public Collection<StdAffiliationStage>? StdAffiliationStages { get; set; }

    }
}
