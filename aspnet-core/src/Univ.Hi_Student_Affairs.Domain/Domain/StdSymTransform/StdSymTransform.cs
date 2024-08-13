using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs.Domain.StdSymTransform
{
    public class StdSymTransform : FullAuditedAggregateRoot<Guid>
    {
        [ForeignKey("StudentId")]
        public Guid? StudentId { get; private set; }



    }
}
