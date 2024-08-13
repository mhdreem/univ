using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Domain.StdAffiliation
{
    public class StdAffiliationStage : Entity<Guid>
    {
        [ForeignKey("StdAffiliationId")]
        public Guid? StdAffiliationId { get; private set; }


    }
}

