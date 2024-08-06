using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Dtos
{
    public class StdAffiliationStageDto : EntityDto<Guid>
    {
        
        public Guid? StdAffiliationId { get; set; }
        public StdAffiliationDto? StdAffiliation { get; set; }

    }
}

