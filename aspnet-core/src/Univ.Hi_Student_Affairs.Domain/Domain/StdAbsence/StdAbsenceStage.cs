using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs
{
    public class StdAbsenceStage : FullAuditedAggregateRoot<Guid>
    {
        [ForeignKey("StdAbsenceId")]
        public Guid? StdAbsenceId { get; set; }
        public StdAbsence? StdAbsence { get; set; }

    }
}
