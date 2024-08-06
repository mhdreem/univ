using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public class Degree : BasicAggregateRoot<int>
    {
        public string? NameAr {  get; set; }
        public string? NameEn { get; set; }

        public int? Ord{ get; set; }

    }
}
