using System.Collections.ObjectModel;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.Univ
{

    public class UnivSectionDto : EntityDto<int>
    {
        //اسم فرع الجامعة        
        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }

        public virtual int? UnivId { get; set; }

        //الترتيب
        public virtual int? Ord { get; set; }



        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }

        public virtual Collection<CollageDto>? Collages { get; set; } //Sub collection

    }



    public class CreateUnivSectionDto
    {
        //اسم فرع الجامعة        
        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }

        public virtual int? UnivId { get; set; }

        //الترتيب
        public virtual int? Ord { get; set; }



        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }

        public virtual Collection<CollageDto>? Collages { get; set; } //Sub collection

    }

    public class UpdateUnivSectionDto : CreateUnivSectionDto
    {
        public int Id { get; set; }
    }


    public class CheckUnivSectionDtoDto : EntityDto<int?>
    {

        //اسم فرع الجامعة        
        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }

        public virtual int? UnivId { get; set; }

        //الترتيب
        public virtual int? Ord { get; set; }



        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }





    }


    public class UnivSectionPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {

        public int? UnivId { get; set; }
        public int? UnivSectionId { get; set; }
        public int? CollageId { get; set; }
        public int? DepartmentId { get; set; }



        public virtual int? Id { get; set; }
        //اسم فرع الجامعة        
        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }





        //الترتيب
        public virtual int? Ord { get; set; }



        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }


    }
}
