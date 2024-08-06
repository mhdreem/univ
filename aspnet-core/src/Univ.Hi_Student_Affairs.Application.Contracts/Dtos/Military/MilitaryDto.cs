using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.Military
{
    public class MilitaryDto : EntityDto<int>
    {
        public string? Name { get; set; }





        public int? CityId { get; set; }

    }

    public class CreateMilitaryDto 
    {
        public string? Name { get; set; }
        public int? CityId { get; set; }

    }

    public class UpdateMilitaryDto
    {
        public int Id { get; set; }
    }


    public class CheckMilitaryDto : EntityDto<int>
    {
        public string? Name { get; set; }
        public int? CityId { get; set; }
    }


    public class MilitaryPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }

        public int? CityId { get; set; }

    }
}
