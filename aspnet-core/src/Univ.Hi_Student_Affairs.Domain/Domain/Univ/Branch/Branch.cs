using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public class Branch : BasicAggregateRoot<int>
    {
      

        //اسم الاختصاص       
        public virtual string NameAr { get; set; }
        public virtual string NameEn { get; set; }




        //الترتيب
        public virtual int? Ord { get; set; }


        //رمز الاختصاص بوزارة التعليم
        public virtual string? Barcode { get; set; }


        //رمز المدينة بوزارة التعليم
        public int? MinistryEncode { get; set; }


        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        public virtual Department? Department { get; set; }



        public Branch()
        {
            NameAr = "";
            NameEn = "";

        }

        public Branch(string name_Ar, string name_En, int? ord, string? barcode, int? ministry_Encode, int departmentId)
        {
            this.NameAr = name_Ar ?? throw new ArgumentNullException(nameof(name_Ar));
            this.NameEn = name_En;
            this.Ord = ord;
            this.Barcode = barcode;
            this.MinistryEncode = ministry_Encode;
            this.DepartmentId = departmentId;

        }

    }
}
