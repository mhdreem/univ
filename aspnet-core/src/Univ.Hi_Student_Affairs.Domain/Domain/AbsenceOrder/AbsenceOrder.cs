using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public class AbsenceOrder:BasicAggregateRoot<int>
    {
        // اسم الأمر 
        public virtual string? Name { get; set; }

        public virtual AbsenceType? AbsenceType { get; set; }

              
        //الترتيب
        public virtual int? Ord { get; set; }
    }
}
