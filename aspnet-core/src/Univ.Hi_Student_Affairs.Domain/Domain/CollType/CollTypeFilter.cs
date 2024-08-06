using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs
{
    public class CollTypeFilter
    {
        //نوع الكلية
        public virtual string Name { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }


        //رمز الكلية بوزراة التعليم
        public virtual int? MinistryEncode { get; set; }

        public virtual string? Barcode { get; set; }
    }
}
