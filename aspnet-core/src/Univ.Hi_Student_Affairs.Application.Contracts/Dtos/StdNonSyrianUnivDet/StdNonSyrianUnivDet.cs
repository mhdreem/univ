using System;
using Univ.Hi_Student_Affairs.Dtos.StdNonSyrianUniv;
using Volo.Abp.Application.Dtos;


namespace Univ.Hi_Student_Affairs.Dtos.StdNonSyrianUnivDet
{
    public class StdNonSyrianUnivDetDto : FullAuditedEntityDto<Guid>
    {

        public Guid? StdNonSyrianUnivId { get; set; }
        public StdNonSyrianUnivDto? StdNonSyrianUniv { get; set; }
    }
}
