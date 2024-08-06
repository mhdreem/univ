using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs.Domain.Univ
{
    public class UnivSectionFilter
    {
        //اسم فرع الجامعة        
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }

        //رمز الفرع بوزارة التعليم
        public int? MinistryEncode { get; set; }


        public string? Barcode { get; set; }


        public int UnivId { get; set; }


    }
}
