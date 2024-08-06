using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public  class Operation : BasicAggregateRoot<int>
    {
        public string? Name { get; set; }
        
    }
}
