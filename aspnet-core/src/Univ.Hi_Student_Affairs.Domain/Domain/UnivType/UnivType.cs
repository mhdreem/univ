using Microsoft.VisualBasic;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{

    public class UnivType : BasicAggregateRoot<int>
    {
        public UnivType()
        {
            NameAr = "";
            
        }

        public UnivType(string nAME_AR, string? nAME_EN, int? ord)
        {
            NameAr = nAME_AR ?? throw new ArgumentNullException(nameof(nAME_AR));
            NameEn = nAME_EN;
            Ord = ord;
            
        }



        //اسم نوع الجامعة

        public virtual string NameAr { get; set; }
        public virtual string? NameEn { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }

      
    }
}
