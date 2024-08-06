using System;
using System.Collections.Generic;
using System.Text;

namespace Univ.Hi_Student_Affairs.Dtos.UnivType
{
    public class UnivTypeFilter
    {
        //اسم نوع الجامعة

        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }
    }
}
