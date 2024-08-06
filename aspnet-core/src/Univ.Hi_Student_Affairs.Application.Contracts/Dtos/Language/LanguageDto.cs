using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Dtos.Language
{

    public class LanguageDto : EntityDto<int>
    {
        //اللغة
        public virtual string NameAr { get; set; }
        public virtual string? NameEn { get; set; }

        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }

        public virtual string? Barcode { get; set; }

        public virtual int? Ord { get; set; }
    }

    public class CreateLanguageDto 
    {
        //اللغة
        public virtual string NameAr { get; set; }
        public virtual string? NameEn { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }

        public virtual int? Ord { get; set; }
    }

    public class UpdateLanguageDto :CreateLanguageDto{
     
        public int Id { get; set; }
    }

    public class CheckLanguageDto
    {
        public int? id { get; set; }

        //اللغة
        public virtual string nameAr { get; set; }
        public virtual string? nameEn { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? ministryEncode { get; set; }


        public virtual string? barcode { get; set; }

        public virtual int? ord { get; set; }




    }

    public class LanguagePagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        //اللغة
        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }

        public virtual int? Ord { get; set; }

    }
}
