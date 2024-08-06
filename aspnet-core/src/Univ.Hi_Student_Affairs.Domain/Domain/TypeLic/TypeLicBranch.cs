using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{

    public class TypeLicBranch : BasicAggregateRoot<int>
    {
        public TypeLicBranch()
        {
            NameAr = "";
            NameEn = "";
        }

        public TypeLicBranch(int id,string name_Ar, string name_En, int? ministry_Encode, string? barcode,int? ord)
        {
            Id = id;
            NameAr = name_Ar ?? throw new ArgumentNullException(nameof(name_Ar));
            NameEn = name_En ?? throw new ArgumentNullException(nameof(name_En));

            MinistryEncode = ministry_Encode;
            Barcode = barcode;
          
            Ord = ord;
        }


        [ForeignKey("TypeLicId")]
        public int? TypeLicId { get; set; }
        public TypeLic? TypeLic { get; set; }


        //فرع الشهادة

        public string NameAr { get; set; }
        public string NameEn { get; set; }



        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }

        public virtual string? Barcode { get; set; }


        public virtual int? Ord { get; set; }

       
    }
}
