using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.Deprivation
{
    public class DeprivationDto : EntityDto<int>
    {
        public string? Name { get; set; }

        public int? Number { get; set; }

        public DeprivationType? DeprivationType { get; set; }
    }

    public class CreateDeprivationDto 
    {
        public string? Name { get; set; }

        public int? Number { get; set; }

        public DeprivationType? DeprivationType { get; set; }
    }

    public class UpdateDeprivationDto: CreateDeprivationDto
    {
        public int Id { get; set; }

    }

    public class DeprivationPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        public string? Name { get; set; }

        public int? Number { get; set; }

        public DeprivationType? DeprivationType { get; set; }

    }

    public class CheckDeprivationDto : EntityDto<int>
    {
        public string? Name { get; set; }

        public int? Number { get; set; }

        public DeprivationType? DeprivationType { get; set; }


    }

}
