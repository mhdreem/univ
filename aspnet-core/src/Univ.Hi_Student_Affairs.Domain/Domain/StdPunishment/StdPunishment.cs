using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs
{
    public class StdPunishment : FullAuditedAggregateRoot<Guid>
    {
        public PunishmentState? PunishmentState { get; set; }



        [ForeignKey("PunishmentId")]
        public int? PunishmentId { get; set; }
        public Punishment? Punishment { get; set; }



        [ForeignKey("StdAbolitionId")]
        public int? StdAbolitionId { get; set; }
        public StdAbolition? StdAbolition { get; set; }




        [ForeignKey("StudentId")]
        public Guid? StudentId { get; set; }
        public Student? Student { get; set; }



        //رمز سبب العقوبة
        [ForeignKey("PunishmentReasonId")]
        public int? PunishmentReasonId { get; set; }
        public virtual PunishmentReason? PunishmentReason { get; set; }


        //عام ارتاكاب العقوبة
        public int? Year { get; set; }



        //سنة ارتكاب العقوبة
        [ForeignKey("ClassId")]
        public int? ClassId { get; set; }
        public virtual Class? Class { get; set; }


        //دورة ارتكاب العقوبة
        [ForeignKey("SemesterId")]
        public int? SemesterId { get; set; }
        public virtual Semester? Semester { get; set; }




        //عام نهاية العقوبة
        public int? YearEnd { get; set; }


        //فصل نهاية العقوبة
        [ForeignKey("SemesterEndId")]
        public int? SemesterEndId { get; set; }
        public virtual Semester? SemesterEnd { get; set; }



       





        public string? Note { get; set; }










        //مؤشر للتثبيت
        public int? Fixed { get; set; }


  

        //  العقوبة داخلية أو خارجية
        public bool? Outside { get; set; }



        //عقوبة مضاعفة
        public bool? doublePunishment { get; set; }


        public virtual Collection<StdPunishmentStage>? StdPunishmentStage { get; set; }


    }
}
