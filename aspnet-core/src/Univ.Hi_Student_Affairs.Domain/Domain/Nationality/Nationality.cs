using System;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{

    public class Nationality : BasicAggregateRoot<int>
    {
        public Nationality()
        {
            NameAr = "";
            NameEn = "";
        }

        public Nationality(int id,string name_Ar, string name_En, int? ord, int? ministry_Encode, string? barcode)
        {
            Id = id;
            NameAr = name_Ar ?? throw new ArgumentNullException(nameof(name_Ar));
            NameEn = name_En ?? throw new ArgumentNullException(nameof(name_En));
            Ord = ord;
            MinistryEncode = ministry_Encode;
            Barcode = barcode;
        }



        //اسم الجنسية

        public string NameAr { get; set; }


        //اسم الجنسية باللغة الانكليزية

        public string NameEn { get; set; }




        //الترتيب
        public int? Ord { get; set; }


        //رمز الجنسية بوزارة التعليم
        public int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }


    }
}
