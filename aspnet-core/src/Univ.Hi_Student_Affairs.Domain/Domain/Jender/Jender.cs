using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public  class Jender : BasicAggregateRoot<int>
    {
        public Jender()
        {
            NameAr = "";
            NameEn = "";
        }

        public Jender(int id ,string nameAr, string nameEn, int? ministryEncode, string? barcode,int? ord)
        {
            this.Id = id;
            NameAr = nameAr;
            NameEn = nameEn;
            MinistryEncode = ministryEncode;
            Barcode = barcode;
            Ord = ord;
        }

        //الجنس

        public string NameAr { get; set; }
        public string NameEn { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }

        public int? Ord { get; set; }


    }
}
