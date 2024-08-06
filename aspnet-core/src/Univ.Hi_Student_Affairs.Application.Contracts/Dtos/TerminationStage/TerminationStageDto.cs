using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.TerminationStage
{
    public class TerminationStageDto : EntityDto<int>
    {
      
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }
    }

    public class CreateTerminationStageDto 
    {

        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }
    }

    public class UpdateTerminationStageDto: CreateTerminationStageDto
    {
        public int Id { get; set; }
    }


    public class CheckTerminationStageDto:EntityDto<int?>
    {

        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }
    }


    public class TerminationStagePagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }

    }

}
