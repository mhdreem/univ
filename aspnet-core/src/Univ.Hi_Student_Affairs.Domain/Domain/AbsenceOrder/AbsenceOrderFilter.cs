using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs
{
    public class AbsenceOrderFilter
    {
        public virtual int? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual AbsenceType? AbsenceType { get; set; }


    }
}
