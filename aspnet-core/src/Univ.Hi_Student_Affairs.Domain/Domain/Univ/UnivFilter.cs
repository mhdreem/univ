using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs.Domain.Univ
{
    public class UnivFilter
    {
        //اسم الجامعة        
        public string NameAr { get; set; }
        public string? NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }


        //رمز الجامعة بوزرارة التعليم
        public virtual int? MinistryEncode { get; set; }

        public virtual string? Barcode { get; set; }

        public virtual ICollection<UnivSection>? UnivSections { get; protected set; } //Sub collection


    }
}
