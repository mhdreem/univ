using System;
using System.Collections.ObjectModel;
using Univ.Hi_Student_Affairs.Dtos.Class;
using Univ.Hi_Student_Affairs.Dtos.Semester;
using Univ.Hi_Student_Affairs.Dtos.StdAbolition;
using Volo.Abp.Application.Dtos;



namespace Univ.Hi_Student_Affairs.Dtos.DomainPunishment
{
    public class StdPunishmentDto : FullAuditedEntityDto<Guid>
    {
        public PunishmentState? PunishmentState { get; set; }


        public int? PunishmentId { get; set; }
        public PunishmentDto? Punishment { get; set; }




        public int? StdAbolitionId { get; set; }
        public StdAbolitionDto? StdAbolition { get; set; }





        public Guid? StudentId { get; set; }
        public StudentDto? Student { get; set; }



        //رمز سبب العقوبة

        public int? PunishmentReasonId { get; set; }
        public virtual PunishmentReasonDto? PunishmentReason { get; set; }


        //عام ارتاكاب العقوبة
        public int? Year { get; set; }



        //سنة ارتكاب العقوبة
        public int? ClassId { get; set; }
        public virtual ClassDto? Class { get; set; }


        //دورة ارتكاب العقوبة

        public int? SemesterId { get; set; }
        public virtual SemesterDto? Semester { get; set; }




        //عام نهاية العقوبة
        public int? YearEnd { get; set; }


        //فصل نهاية العقوبة

        public int? SemesterEndId { get; set; }
        public virtual SemesterDto? SemesterEnd { get; set; }









        public string? Note { get; set; }










        //مؤشر للتثبيت
        public int? Fixed { get; set; }




        //  العقوبة داخلية أو خارجية
        public bool? Outside { get; set; }



        //عقوبة مضاعفة
        public bool? doublePunishment { get; set; }


        public virtual Collection<StdPunishmentStageDto>? StdPunishmentStages { get; set; }


    }


    public class CreateStdPunishmentDto
    {
        public PunishmentState? PunishmentState { get; set; }


        public int? PunishmentId { get; set; }
        public PunishmentDto? Punishment { get; set; }




        public int? StdAbolitionId { get; set; }
        public StdAbolitionDto? StdAbolition { get; set; }





        public Guid? StudentId { get; set; }
        public StudentDto? Student { get; set; }



        //رمز سبب العقوبة

        public int? PunishmentReasonId { get; set; }
        public virtual PunishmentReasonDto? PunishmentReason { get; set; }


        //عام ارتاكاب العقوبة
        public int? Year { get; set; }



        //سنة ارتكاب العقوبة
        public int? ClassId { get; set; }
        public virtual ClassDto? Class { get; set; }


        //دورة ارتكاب العقوبة

        public int? SemesterId { get; set; }
        public virtual SemesterDto? Semester { get; set; }




        //عام نهاية العقوبة
        public int? YearEnd { get; set; }


        //فصل نهاية العقوبة

        public int? SemesterEndId { get; set; }
        public virtual SemesterDto? SemesterEnd { get; set; }









        public string? Note { get; set; }









        public bool? Fixed { get; private set; }

        public bool? Outside { get; private set; }

        public bool? DoublePunishment { get; private set; }


        public virtual Collection<StdPunishmentStageDto>? StdPunishmentStages { get; set; }


    }


    public class UpdateStdPunishmentDto : CreateStdPunishmentDto
    {
        public Guid Id { get; set; }
    }

    public class CheckStdPunishmentDto : FullAuditedEntityDto<Guid?>
    {
        public PunishmentState? PunishmentState { get; set; }


        public int? PunishmentId { get; set; }
        public PunishmentDto? Punishment { get; set; }




        public int? StdAbolitionId { get; set; }
        public StdAbolitionDto? StdAbolition { get; set; }





        public Guid? StudentId { get; set; }
        public StudentDto? Student { get; set; }



        //رمز سبب العقوبة

        public int? PunishmentReasonId { get; set; }
        public virtual PunishmentReasonDto? PunishmentReason { get; set; }


        //عام ارتاكاب العقوبة
        public int? Year { get; set; }



        //سنة ارتكاب العقوبة
        public int? ClassId { get; set; }
        public virtual ClassDto? Class { get; set; }


        //دورة ارتكاب العقوبة

        public int? SemesterId { get; set; }
        public virtual SemesterDto? Semester { get; set; }




        //عام نهاية العقوبة
        public int? YearEnd { get; set; }


        //فصل نهاية العقوبة

        public int? SemesterEndId { get; set; }
        public virtual SemesterDto? SemesterEnd { get; set; }









        public string? Note { get; set; }









        public bool? Fixed { get; private set; }

        public bool? Outside { get; private set; }

        public bool? DoublePunishment { get; private set; }


        public virtual Collection<StdPunishmentStageDto>? StdPunishmentStages { get; set; }


    }

}
