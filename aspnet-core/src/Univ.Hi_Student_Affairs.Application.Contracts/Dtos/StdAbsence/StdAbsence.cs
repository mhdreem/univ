using System;
using System.Collections.ObjectModel;
using Univ.Hi_Student_Affairs.Dtos.AbsenceOrder;
using Univ.Hi_Student_Affairs.Dtos.Semester;
using Univ.Hi_Student_Affairs.Dtos.StdAbsenceStage;
using Volo.Abp.Application.Dtos;


namespace Univ.Hi_Student_Affairs.Dtos.StdAbsence
{
    public class StdAbsenceDto : FullAuditedEntityDto<Guid>
    {



        public AbsenceState? AbsenceState { get; set; }




        public Guid? StudentId { get; set; }
        public StudentDto? Student { get; set; }



        public Guid? AbsenceOrderId { get; set; }
        public AbsenceOrderDto? AbsenceOrder { get; set; }


        //سبب التبرير
        public string? Reason { get; set; }


        public int? YearFrom { get; set; }
        public int? YearTo { get; set; }

        //الفصل الحالي
        public int? SemesterFromId { get; set; }

        public virtual SemesterDto? SemesterFrom { get; set; }

        //الفصل الحالي
        public int? SemesterToId { get; set; }

        public virtual SemesterDto? SemesterTo { get; set; }




        public string? Agent { get; set; }
        public string? AgentNo { get; set; }
        public string? AgentDate { get; set; }
        public string? AgentSource { get; set; }


        public string? Note { get; set; }


        public Collection<StdAbsenceStageDto>? StdAbsenceStages { get; set; }

    }


    public class CreateStdAbsenceDto
    {



        public AbsenceState? AbsenceState { get; set; }




        public Guid? StudentId { get; set; }
        public StudentDto? Student { get; set; }



        public Guid? AbsenceOrderId { get; set; }
        public AbsenceOrderDto? AbsenceOrder { get; set; }


        //سبب التبرير
        public string? Reason { get; set; }


        public int? YearFrom { get; set; }
        public int? YearTo { get; set; }

        //الفصل الحالي
        public int? SemesterFromId { get; set; }

        public virtual SemesterDto? SemesterFrom { get; set; }

        //الفصل الحالي
        public int? SemesterToId { get; set; }

        public virtual SemesterDto? SemesterTo { get; set; }




        public string? Agent { get; set; }
        public string? AgentNo { get; set; }
        public string? AgentDate { get; set; }
        public string? AgentSource { get; set; }


        public string? Note { get; set; }


        public Collection<StdAbsenceStageDto>? StdAbsenceStages { get; set; }

    }


    public class UpdateStdAbsenceDto : CreateStdAbsenceDto
    {

        public int Id { get; set; }

    }



}

