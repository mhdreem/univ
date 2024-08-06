using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs
{
    public class NationalityFilter
    {

        public int? Id { get; set; }
        //اسم الجنسية

        public string? NameAr { get; set; }


        //اسم الجنسية باللغة الانكليزية

        public string? NameEn { get; set; }




        //الترتيب
        public int? Ord { get; set; }


        //رمز الجنسية بوزارة التعليم
        public int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }


    }
}
