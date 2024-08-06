using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs
{
    public class AffiliationOrderFilter
    {
        public int Id { get; set; }

        // اسم الأمر 
        public virtual string? Name { get; set; }

        public virtual AffiliationType? AffiliationType { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }


    }
}
