using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.RegStage
{
    public class RegStageDto : EntityDto<int>
    {
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }
    }

    public class CreateRegStageDto
    {
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }
    }

    public class UpdateRegStageDto : CreateRegStageDto
    {
        public int Id { get; set;}

    }


    public class CheckRegStageDto : EntityDto<int>
    {

        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }



    }
    public class RegStagePagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }

    }

}
