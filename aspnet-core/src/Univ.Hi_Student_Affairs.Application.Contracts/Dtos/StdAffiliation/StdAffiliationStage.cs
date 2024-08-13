using System;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.StdAffiliation
{
    public class StdAffiliationStageDto : EntityDto<Guid>
    {

        public Guid? StdAffiliationId { get; set; }
        public StdAffiliationDto? StdAffiliation { get; set; }

    }
}

