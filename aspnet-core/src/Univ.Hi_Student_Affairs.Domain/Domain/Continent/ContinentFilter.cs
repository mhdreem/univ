using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs
{
    public class ContinentFilter
    {
        //اسم القارة
        public string? NameAr { get; set; }

        //اسم القارة
        public string? NameEn { get; set; }


        //الترتيب
        public int? Ord { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }




    }
}
