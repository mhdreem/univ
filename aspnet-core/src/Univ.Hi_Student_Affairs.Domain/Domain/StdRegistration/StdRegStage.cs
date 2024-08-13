using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Domain.StdRegistration
{
    public class StdRegStage : Entity<Guid>
    {

        [ForeignKey("RegStageId")]
        public Guid? RegStageId { get; private set; }
        public RegStage? RegStage { get; private set; }



        [ForeignKey("StdRegistrationId")]
        public Guid? StdRegistrationId { get; private set; }



        public string? No { get; private set; }
        public DateTime? Date { get; private set; }

    }
}
