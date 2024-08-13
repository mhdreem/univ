using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Domain.StdTermination
{
    public class StdTerminateStage : Entity<int>
    {
        [ForeignKey("StdTerminationId")]
        public Guid? StdTerminationId { get; private set; }


    }
}

