using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Dtos.StdTermination;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Dtos.StdTerminateStage
{
    public class StdTerminateStageDto : EntityDto<Guid>
    {

        public Guid? StdTerminationId { get; set; }
        public StdTerminationDto? StdTermination { get; set; }

    }
}

