using System;
using Univ.Hi_Student_Affairs.Dtos.StdTermination;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.StdTerminateStage
{
    public class StdTerminateStageDto : EntityDto<Guid>
    {

        public Guid? StdTerminationId { get; set; }
        public StdTerminationDto? StdTermination { get; set; }

    }
}

