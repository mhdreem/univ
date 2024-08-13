using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Domain.StdAbsence
{
    public class StdAbsenceStage : Entity<Guid>
    {
        [ForeignKey("StdAbsenceId")]
        public Guid? StdAbsenceId { get; private set; }


    }
}
