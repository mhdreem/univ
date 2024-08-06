using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public  class Grade : BasicAggregateRoot<int>
    {
        public Grade()
        {
            NameAr = "";
            NameEn = "";
        }

        public Grade(int id,string nameAr, string nameEn, int? ord, int? from, int? to)
        {
            this.Id = id;
            NameAr = nameAr;
            NameEn = nameEn;
            Ord = ord;
            From = from;
            To = to;
        }


        //اسم الدرجة بالعربي        
        public string NameAr { get; set; }



        //اسم الدرجة بالانكليزي        
        public string NameEn { get; set; }


        // الترتيب
        public int? Ord { get; set; }


        //الحد الأدنى
        public int? From { get; set; }


        //الحد الاعلى
        public int? To { get; set; }

    }
}
