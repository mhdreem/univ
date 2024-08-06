using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.Jender
{
    public  class JenderDto : EntityDto<int>
    {

        //الجنس

        public string NameAr { get; set; }
        public string NameEn { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }

        public int? Ord { get; set; }


    }

    public class CreateJenderDto 
    {

        //الجنس

        public string NameAr { get; set; }
        public string NameEn { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }

        public int? Ord { get; set; }


    }


    public class UpdateJenderDto : CreateJenderDto
    {
        public int Id { get; set; }

    }

    public class JenderPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }

        public int? Ord { get; set; }
    }


    public class CheckJenderDto : EntityDto<int?>
    {

        //الجنس

        public string NameAr { get; set; }
        public string NameEn { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }

        public int? Ord { get; set; }


    }

}
