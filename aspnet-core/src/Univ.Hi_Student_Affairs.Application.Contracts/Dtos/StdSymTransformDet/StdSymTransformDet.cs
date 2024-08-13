using System;
using Univ.Hi_Student_Affairs.Dtos.StdSymTransform;
using Volo.Abp.Application.Dtos;


namespace Univ.Hi_Student_Affairs.Dtos.StdSymTransformDet
{
    public class StdSymTransformDetDto : FullAuditedEntityDto<Guid>
    {

        public Guid? StdSymTransformId { get; set; }
        public StdSymTransformDto? StdSymTransform { get; set; }


    }
}
