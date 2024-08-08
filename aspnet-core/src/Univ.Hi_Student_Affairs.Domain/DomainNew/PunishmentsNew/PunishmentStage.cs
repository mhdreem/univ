using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs.Punishments
{
    public class PunishmentStage :FullAuditedEntity<int>
    {
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Order { get; set; }
    }
}
