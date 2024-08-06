using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs.Domain.Base
{
    public class BaseEncodeTable
    {
        //اسم المدينة بالعربي
        public string NameAr { get; set; }

        //اسم المدينة بالانكليزي
        public string NameEn { get; set; }




        //الترتيب
        public int? Ord { get; set; }


        //رمز المدينة بوزارة التعليم
        public string? Barcode { get; set; }


        //رمز المدينة بوزارة التعليم
        public int? MinistryEncode { get; set; }

    }
}
