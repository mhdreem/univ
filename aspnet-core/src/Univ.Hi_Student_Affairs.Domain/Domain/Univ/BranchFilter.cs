using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs.Domain.Univ
{
    public class BranchFilter
    {
        //اسم الاختصاص       
        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }




        //الترتيب
        public virtual int? Ord { get; set; }


        //رمز الاختصاص بوزارة التعليم
        public virtual string? Barcode { get; set; }


        //رمز المدينة بوزارة التعليم
        public int? MinistryEncode { get; set; }


        
        public int DepartmentId { get; set; }
        

    }
}
