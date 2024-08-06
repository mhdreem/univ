using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public class AffiliationStage:BasicAggregateRoot<int>
    {
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }
    }
}
