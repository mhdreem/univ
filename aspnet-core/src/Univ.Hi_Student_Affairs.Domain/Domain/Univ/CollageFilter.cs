using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs.Domain.Univ
{
    public class CollageFilter
    {
        //اسم الكلية 
        public string? NameAr { get; set; }

        //اسم الكلية 
        public string? NameEn { get; set; }


        //اسم العميد
        public string? DeanAr { get; set; }
        public string? DeanEn { get; set; }



        //عدد السنوات الدراسية 
        public int? NumYear { get; set; }


        //الترتيب
        public int? Ord { get; set; }




        //اسم الاجازة الممنوحة للطالب
        public string? DegreeNameAr { get; set; }


        //اسم الاجازة الممنوحة للطالب باللغة الانكليزية
        public string? DegreeNameEn { get; set; }



        //رمز الكلية بوزراة التعليم
        public int? MinistryEncode { get; set; }


        //رمز الكلية بوزراة التعليم
        public string? Barcode { get; set; }



        public int UnivSectionId { get; set; }


    }
}
