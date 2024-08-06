using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{

    public class IdentifierType : BasicAggregateRoot<int>
    {
        public IdentifierType()
        {
            NameAr = "";
            NameEn = "";
        }

        public IdentifierType(int id,string name_Ar, string name_En, int? ord)
        {
            this.Id = id;
            NameAr = name_Ar ?? throw new ArgumentNullException(nameof(name_Ar));
            NameEn = name_En;
            Ord = ord;
        }




        //اسم نوع الهوية
        public string NameAr { get; set; }
        public string NameEn { get; set; }


        //الترتيب
        public int? Ord { get; set; }


    }
}
