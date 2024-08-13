using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.Degree
{
    public class DegreeDto : EntityDto<int>
    {
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }
        public int? Ord { get; set; }

    }


    public class CreateDegreeDto
    {
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }
        public int? Ord { get; set; }

    }


    public class UpdateDegreeDto : CreateDegreeDto
    {

        public int Id { get; set; }

    }



    public class CheckDegreeDto : EntityDto<int?>
    {
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }

        public int? Ord { get; set; }





    }

    public class DegreePagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }

        public int? Ord { get; set; }


    }
}
