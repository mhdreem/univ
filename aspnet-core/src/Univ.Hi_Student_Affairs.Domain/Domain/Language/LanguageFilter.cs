using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs
{
    public class LanguageFilter
    {
        public int? Id { get; set; }
        //اللغة
        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }

    }
}
