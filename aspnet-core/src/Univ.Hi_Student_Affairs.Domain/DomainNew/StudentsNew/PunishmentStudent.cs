using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.DomainNew.PunishmentsNew;
using Univ.Hi_Student_Affairs.enums;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs.Students
{
    public class PunishmentStudent : FullAuditedEntity<int>
    {
        public PunishmentState? PunishmentState { get; set; }

        [ForeignKey("PunishmentId")]
        public int? PunishmentId { get; set; }
        public PunishmentNew? Punishment { get; set; }

        [ForeignKey("StdAbolitionId")]
        public int? StdAbolitionId { get; set; }
        public StdAbolition? StdAbolition { get; set; }

        [ForeignKey("StudentId")]
        public int? StudentId { get; set; }
        public StudentNew? Student { get; set; }

        //رمز سبب العقوبة
        public PunishmentReasonEnum? PunishmentReason { get; set; }

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
        public PunishmentStudent()
        {


        }
        public PunishmentStudent(PunishmentState punishmentState, int punishmentId, int stdAbolitionId,
             PunishmentReasonEnum punishmentReason, int year, int classId, int semesterId, int yearEnd,
              int semesterEndId, string note
            )
        {
            PunishmentState = punishmentState;
            PunishmentId = punishmentId;
            StdAbolitionId = stdAbolitionId;
            PunishmentReason = punishmentReason;
            Year = year;
            ClassId = classId;
            SemesterId = semesterId;
            YearEnd = yearEnd;
            SemesterEndId = semesterEndId;
            Note = note;

        }
        public  static PunishmentStudent create(PunishmentState punishmentState, int punishmentId, int stdAbolitionId,
             PunishmentReasonEnum punishmentReason, int year, int classId, int semesterId, int yearEnd,
              int semesterEndId, string note)
        {
            return new PunishmentStudent(punishmentState,punishmentId,stdAbolitionId,punishmentReason,
                year, classId, semesterId, yearEnd, semesterEndId, note);
        }
        public void update(PunishmentState punishmentState, int punishmentId, int stdAbolitionId,
             PunishmentReasonEnum punishmentReason, int year, int classId, int semesterId, int yearEnd,
              int semesterEndId, string note)
        {
            PunishmentState = punishmentState;
            PunishmentId = punishmentId;
            StdAbolitionId = stdAbolitionId;
            PunishmentReason = punishmentReason;
            Year = year;
            ClassId = classId;
            SemesterId = semesterId;
            YearEnd = yearEnd;
            SemesterEndId = semesterEndId;
            Note = note;
        }
    }

}
