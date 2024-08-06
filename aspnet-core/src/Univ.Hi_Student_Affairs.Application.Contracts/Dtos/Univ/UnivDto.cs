using System.Collections.ObjectModel;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Dtos.Univ
{
    public class UnivDto : EntityDto<int>
    {


        //اسم الجامعة        
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }




        //الترتيب
        public int? Ord { get; set; }




        //رمز الجامعة بوزرارة التعليم
        public virtual int? MinistryEncode { get; set; }

        public virtual string? UnivEncode { get; set; }

        public virtual Collection<UnivSectionDto>? UnivSections { get;  set; } //Sub collection


       
    }


    public class CreateUnivDto 
    {


        //اسم الجامعة        
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }




        //الترتيب
        public int? Ord { get; set; }




        //رمز الجامعة بوزرارة التعليم
        public virtual int? MinistryEncode { get; set; }

        public virtual string? UnivEncode { get; set; }

        public virtual Collection<UnivSectionDto>? UnivSections { get; set; } //Sub collection



    }

    public class UpdateUnivDto : CreateUnivDto
    {
        public int Id { get; set; }
    }


    public class CheckUnivDto:EntityDto<int?>
    {
        //اسم الجامعة        
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }




        //الترتيب
        public int? Ord { get; set; }




        //رمز الجامعة بوزرارة التعليم
        public virtual int? MinistryEncode { get; set; }

        public virtual string? UnivEncode { get; set; }

      

    }


    public class UnivPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {

        public int? UnivId { get; set; }
        public int? UnivSectionId { get; set; }
        public int? CollageId { get; set; }
        public int? DepartmentId { get; set; }



        public virtual int? Id { get; set; }
        //اسم الجامعة        
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }




        //الترتيب
        public int? Ord { get; set; }




        //رمز الجامعة بوزرارة التعليم
        public virtual int? MinistryEncode { get; set; }

        public virtual string? UnivEncode { get; set; }

    }

}
