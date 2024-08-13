using System;
using Univ.Hi_Student_Affairs.Dtos.RegStage;
using Univ.Hi_Student_Affairs.Dtos.StdRegistration;
using Volo.Abp.Application.Dtos;



namespace Univ.Hi_Student_Affairs.Dtos.StdRegStage
{
    public class StdRegStageDto : FullAuditedEntityDto<Guid>
    {


        public Guid? RegStageId { get; set; }
        public RegStageDto? RegStage { get; set; }




        public Guid? StdRegistrationId { get; set; }
        public StdRegistrationDto? StdRegistration { get; set; }



        public string? No { get; set; }
        public DateTime? Date { get; set; }

    }
}
