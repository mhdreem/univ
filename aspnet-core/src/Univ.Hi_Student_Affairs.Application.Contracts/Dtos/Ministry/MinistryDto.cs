using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.Ministry
{
    public class MinistryDto : EntityDto<int>
    {
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }
    }


    public class CreateMinistryDto
    {
        public string NameAr { get; set; }
        public string? NameEn { get; set; }
    }


    public class UpdateMinistryDto : CreateMinistryDto
    {
        public int Id { get; set; }
    }




    public class CheckMinistryDto : EntityDto<int>
    {
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }

    }


    public class MinistryPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public int? Id { get; set; }
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }

    }


}
