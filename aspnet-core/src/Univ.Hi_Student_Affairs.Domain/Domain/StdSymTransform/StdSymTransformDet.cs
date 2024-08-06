using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs
{
    public class StdSymTransformDet : FullAuditedAggregateRoot<Guid>
    {
        
        [ForeignKey("StdSymTransformId")]
        public Guid? StdSymTransformId { get; set; }
        public StdSymTransform? StdSymTransform { get; set; }


    }
}
