using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs
{
    public class SeqResultFilter
    {
        public int? Id { get; set; }

        //حالة الطالب
        [MaxLength(250)]
        public string? NameAr { get; set; }

        //حالة الطالب
        [MaxLength(250)]
        public string? NameEn { get; set; }


        //الترتيب
        public int? Ord { get; set; }



    }
}
