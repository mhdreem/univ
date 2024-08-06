using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs
{
    public class SemesterFilter
    {
        public virtual int? Id { get; set; }
        //الفصل الدراسي
        public virtual string? NameAr { get; set; }


        //الفصل باللغة الانكليزية
        public virtual string? NameEn { get; set; }



        //فصل الشهادة
        public virtual string? GradeNameAr { get; set; }
        public virtual string? GradeNameEn { get; set; }



        //الترتيب
        public virtual int? Ord { get; set; }

    }
}
