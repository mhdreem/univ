using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs.Domain.Univ
{
    public class DepartmentFilter
    {
        //اسم القسم

        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }




        //الترتيب
        public virtual int? Ord { get; set; }

        //اسم القسم باللغة الانكليزية



        //اسم القسم بالاجازة الممنوحة للطالب

        public virtual string? DegreeNameAr { get; set; }
        public virtual string? DegreeNameEn { get; set; }


        //رمز القسم بوزراة التعليم
        public virtual int? MinistryEncode { get; set; }


        //رمز القسم بوزراة التعليم
        public virtual int? Barcode { get; set; }



        public int? CollageId { get; set; }


      

    }
}
