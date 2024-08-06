using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs
{
    public class StdRegStage : FullAuditedAggregateRoot<Guid>
    {

        [ForeignKey("RegStageId")]
        public Guid? RegStageId { get; set; }
        public RegStage? RegStage { get; set; }



        [ForeignKey("StdRegistrationId")]        
        public Guid? StdRegistrationId { get; set; }
        public StdRegistration? StdRegistration { get; set; }



        public string? No {  get; set; }
        public DateTime? Date{ get; set; }

    }
}
