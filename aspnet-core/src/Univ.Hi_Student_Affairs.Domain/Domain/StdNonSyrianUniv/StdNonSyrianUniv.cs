using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs
{
    public class StdNonSyrianUniv : FullAuditedAggregateRoot<Guid>
    {

        [ForeignKey("StudentId")]
        public Guid? StudentId { get; private set; }

    }
}
