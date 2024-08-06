using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public class Deprivation : BasicAggregateRoot<int>
    {
        public string? Name { get; set; }

        public int? Number { get; set; }

        public DeprivationType? DeprivationType { get; set; }

    }
}
