using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs
{
    public class GradeFilter
    {

        //اسم الدرجة بالعربي        
        public string? NameAr { get; set; }



        //اسم الدرجة بالانكليزي        
        public string? NameEn { get; set; }


        // الترتيب
        public int Ord { get; set; }


        //الحد الأدنى
        public int? From { get; set; }


        //الحد الاعلى
        public int? To { get; set; }


    }
}
