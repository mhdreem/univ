using System;
using System.Collections.ObjectModel;
using Univ.Hi_Student_Affairs.Dtos.Admission;
using Univ.Hi_Student_Affairs.Dtos.Semester;
using Univ.Hi_Student_Affairs.Dtos.StdTerminateStage;
using Univ.Hi_Student_Affairs.Dtos.TerminationOrder;
using Volo.Abp.Application.Dtos;


namespace Univ.Hi_Student_Affairs.Dtos.StdTermination
{
    public class StdTerminationDto : FullAuditedEntityDto<Guid>
    {
        public TerminationState? TerminationState { get; set; }




        public Guid? StudentId { get; set; }
        public StudentDto? Student { get; set; }




        public Guid? TerminationOrderId { get; set; }
        public TerminationOrderDto? TerminationOrder { get; set; }




        public string? No { get; set; }
        public DateTime? Date { get; set; }




        public int Year { get; set; }



        //الفصل الحالي
        public int? SemesterId { get; set; }

        public virtual SemesterDto? Semester { get; set; }



        public int? PrevAdmissionId { get; set; }
        public AdmissionDto? PrevAdmission { get; set; }


        public string? Agent { get; set; }
        public string? AgentNo { get; set; }
        public string? AgentDate { get; set; }
        public string? AgentSource { get; set; }

        public Collection<StdTerminateStageDto>? StdTerminateStages { get; set; }

    }
}
