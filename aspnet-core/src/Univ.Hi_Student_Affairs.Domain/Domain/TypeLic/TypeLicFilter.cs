using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs
{
    public class TypeLicFilter
    {
        //الشهادة الثانوية
        public virtual string? NameAr { get; set; }


        //الشهادة باللغة الاجنبية
        public virtual string? NameEn { get; set; }




        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }



    }
}
