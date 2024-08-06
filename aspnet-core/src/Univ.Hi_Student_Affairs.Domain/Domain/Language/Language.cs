using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{

    public class Language : BasicAggregateRoot<int>
    {
        public Language()
        {
            NameAr = "";
        }

        public Language(int id,string nAME_AR, string? nAME_EN, int? mINISTRY_ENCODE, string? bARCODE, int? ord)
        {
            this.Id = id;
            NameAr = nAME_AR ?? throw new ArgumentNullException(nameof(nAME_AR));
            NameEn = nAME_EN;
            MinistryEncode = mINISTRY_ENCODE;
            Barcode = bARCODE;
            Ord = ord;
        }


        //اللغة
        public virtual string NameAr { get; set; }
        public virtual string? NameEn { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }

        public virtual int? Ord { get; set; }
    }
}
