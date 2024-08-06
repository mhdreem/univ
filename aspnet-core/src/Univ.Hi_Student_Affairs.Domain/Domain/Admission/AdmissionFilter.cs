using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs
{
    public class AdmissionFilter
    {
        public virtual int? Id { get; set; }
        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }
        public virtual int? MinistryEncode { get; set; }
        public virtual string? Barcode { get; set; }
        public virtual int? Ord { get; set; }
    }
}
