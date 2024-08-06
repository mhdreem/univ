using System;
using System.Collections.ObjectModel;
using Univ.Hi_Student_Affairs.Dtos.RegOrder;
using Univ.Hi_Student_Affairs.Dtos.Semester;
using Univ.Hi_Student_Affairs.Dtos.StdRegStage;
using Volo.Abp.Application.Dtos;


namespace Univ.Hi_Student_Affairs.Dtos.StdRegistration
{
    public class StdRegistrationDto : FullAuditedEntityDto<Guid>
    {


        public RegistrationState? RegistrationState { get; set; }



        public Guid? StudentId { get; set; }
        public StudentDto? Student { get; set; }




        public Guid? RegOrderId { get; set; }
        public RegOrderDto? RegOrder { get; set; }




        public string? No { get; set; }
        public DateTime? Date { get; set; }

        public int Year { get; set; }



        //الفصل الحالي
        public int? SemesterId { get; set; }
        public virtual SemesterDto? Semester { get; set; }



        public string? Agent { get; set; }
        public string? AgentNo { get; set; }
        public string? AgentDate { get; set; }
        public string? AgentSource { get; set; }


        public Collection<StdRegStageDto>? StdRegStages { get; set; }

    }
}
