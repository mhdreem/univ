using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.SubExamStatus
{
    public class SubExamStatusDto : EntityDto<int>
    {
        //حالة المادة

        public string? NameAr { get; set; }
        public string? NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }
    }

    public class CreateSubExamStatusDto
    {
        //حالة المادة

        public string? NameAr { get; set; }
        public string? NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }
    }


    public class UpdateSubExamStatusDto : CreateSubExamStatusDto
    {
        public int Id { get; set; }
    }



    public class CheckSubExamStatusDto : EntityDto<int?>
    {
        //حالة المادة
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }

    }

    public class SubExamStatusPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        //حالة المادة

        public string? NameAr { get; set; }
        public string? NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }

    }
}
