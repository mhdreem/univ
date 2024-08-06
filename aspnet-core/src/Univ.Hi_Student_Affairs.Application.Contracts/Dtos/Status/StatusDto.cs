using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.Status
{
    public class StatusDto : EntityDto<int>
    {
        //حالة الطالب
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }
        //الترتيب
        public int? Ord { get; set; }
    }

    public class CreateStatusDto : EntityDto<int>
    {
        //حالة الطالب
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }
        //الترتيب
        public int? Ord { get; set; }
    }

    public class UpdateStatusDto : CreateStatusDto
    {
        public int Id { get; set; }
    }


    public class CheckStatusDto : EntityDto<int>
    {
        //حالة الطالب
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }
        //الترتيب
        public int? Ord { get; set; }



    }

    public class StatusPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public int? Id { get; set; }
        //حالة الطالب
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }
        //الترتيب
        public int? Ord { get; set; }

    }

}
