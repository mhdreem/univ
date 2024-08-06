using System.Collections.ObjectModel;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.Continent
{
    public class ContinentDto :  EntityDto<int>
    {
        //اسم القارة
        public string? NameAr { get; set; }


        //اسم القارة
        public string? NameEn { get; set; }


        //الترتيب
        public int? Ord { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }


    }


    public class CreateContinentDto 
    {
        //اسم القارة
        public string NameAr { get; set; }


        //اسم القارة
        public string? NameEn { get; set; }


        //الترتيب
        public int? Ord { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }

    }


    public class UpdateContinentDto : CreateContinentDto
    {
        public int Id { get; set; }
    }


    public class CheckContinentDto: EntityDto<int?>
    {
        //اسم القارة
        public string? NameAr { get; set; }


        //اسم القارة
        public string? NameEn { get; set; }


        //الترتيب
        public int? Ord { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }




    }


    public class ContinentPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        //اسم القارة
        public string? NameAr { get; set; }


        //اسم القارة
        public string? NameEn { get; set; }


        //الترتيب
        public int? Ord { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }



    }
}
