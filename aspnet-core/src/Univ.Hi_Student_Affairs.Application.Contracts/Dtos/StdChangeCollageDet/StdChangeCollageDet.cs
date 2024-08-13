using System;
using Univ.Hi_Student_Affairs.Dtos.StdChangeCollage;
using Volo.Abp.Application.Dtos;


namespace Univ.Hi_Student_Affairs.Dtos.StdChangeCollageDet
{
    public class StdChangeCollageDetDto : FullAuditedEntityDto<Guid>
    {

        public Guid? StdChangeCollageId { get; set; }
        public StdChangeCollageDto? StdChangeCollage { get; set; }

    }
}
