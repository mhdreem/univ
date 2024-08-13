using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.Class
{

    public class ClassDto : EntityDto<int>
    {

        //الاسم بالعربي
        public string NameAr { get; set; }

        //الاسم بالإنكليري
        public string? NameEn { get; set; }


        //الترتيب
        public int? Ord { get; set; }


    }


    public class CreateClassDto
    {

        //الاسم بالعربي
        public string NameAr { get; set; }

        //الاسم بالإنكليري
        public string? NameEn { get; set; }


        //الترتيب
        public int? Ord { get; set; }


    }



    public class UpdateClassDto : CreateClassDto
    {
        public int? Id { get; set; }
    }


    public class CheckClassDto : EntityDto<int?>
    {

        //الاسم بالعربي
        public string? NameAr { get; set; }

        //الاسم بالإنكليري
        public string? NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }



    }


    public class ClassPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        //الاسم بالعربي

        public string? NameAr { get; set; }

        //الاسم بالإنكليري
        public string? NameEn { get; set; }


        //الترتيب
        public int? Ord { get; set; }

    }

}
