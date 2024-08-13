using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.IdentifierType
{

    public class IdentifierTypeDto : EntityDto<int>
    {


        //اسم نوع الهوية

        public string NameAr { get; set; }
        public string NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }


    }

    public class CreateIdentifierTypeDto
    {


        //اسم نوع الهوية

        public string NameAr { get; set; }
        public string NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }


    }

    public class UpdateIdentifierTypeDto
    {
        public int Id { get; set; }
    }

    public class CheckIdentifierTypeDto : EntityDto<int?>
    {
        public int? id { get; set; }
        //اسم نوع الهوية
        public string? nameAr { get; set; }
        public string? nameEn { get; set; }
        //الترتيب
        public int? ord { get; set; }

    }

    public class IdentifierTypePagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        //اسم نوع الهوية

        public string? NameAr { get; set; }
        public string? NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }
    }

}
/*
 
        //رمز المدينة بوزارة التعليم
        public string? CITY_ENCODE { get; set; }


        //رمز المدينة بوزارة التعليم
        public int? MINISTRY_ENCODE { get; set; }


 */
