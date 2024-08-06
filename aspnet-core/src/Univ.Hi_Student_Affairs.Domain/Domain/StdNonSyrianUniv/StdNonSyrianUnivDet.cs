using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs.Domain
{
    public class StdNonSyrianUnivDet : FullAuditedAggregateRoot<Guid>
    {
        [ForeignKey("StdNonSyrianUnivId")]
        public Guid? StdNonSyrianUnivId { get; set; }
        public StdNonSyrianUniv? StdNonSyrianUniv { get; set; }
    }
}
