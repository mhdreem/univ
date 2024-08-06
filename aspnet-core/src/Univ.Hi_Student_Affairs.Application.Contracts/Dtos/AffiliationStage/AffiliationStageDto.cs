using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.AffiliationStage
{


    public class AffiliationStageDto:EntityDto<int>
    {
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }


    }


    public class CreateAffiliationStageDto 
    {
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }


    }

    public class UpdateAffiliationStageDto : CreateAffiliationStageDto
    {
        public int Id { get; set; }
    }

    public class CheckAffiliationStageDto : EntityDto<int?>
    {
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }

    }


    public class AffiliationStagePagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }

    }
}