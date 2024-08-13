using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Univ.Hi_Student_Affairs.Domain.Student;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs.Domain.StdPunishment
{
    public class StdPunishment : FullAuditedAggregateRoot<Guid>
    {

        public PunishmentState? PunishmentState { get; private set; }


        [ForeignKey("PunishmentId")]
        public int? PunishmentId { get; private set; }
        public virtual Punishment? Punishment { get; private set; }



        [ForeignKey("StdAbolitionId")]
        public int? StdAbolitionId { get; private set; }
        public virtual StdAbolition? StdAbolition { get; private set; }



        [ForeignKey("StudentId")]
        public Guid? StudentId { get; private set; }



        [ForeignKey("PunishmentReasonId")]
        public int? PunishmentReasonId { get; private set; }
        public virtual PunishmentReason? PunishmentReason { get; private set; }




        public int? Year { get; private set; }


        [ForeignKey("ClassId")]
        public int? ClassId { get; private set; }
        public virtual Class? Class { get; private set; }


        [ForeignKey("SemesterId")]
        public int? SemesterId { get; private set; }
        public virtual Semester? Semester { get; private set; }


        public int? YearEnd { get; private set; }



        [ForeignKey("SemesterEndId")]
        public int? SemesterEndId { get; private set; }
        public virtual Semester? SemesterEnd { get; private set; }


        public string? Note { get; private set; }

        public bool? Fixed { get; private set; }

        public bool? Outside { get; private set; }

        public bool? DoublePunishment { get; private set; }

        public virtual ICollection<StdPunishmentStage>? StdPunishmentStages { get; private set; }

        private StdPunishment() { }


        public StdPunishment(
            Guid id,
         PunishmentState? punishmentState,
         int? punishmentId,
         Guid? studentId,
         int? punishmentReasonId,
         int? year,
         int? classId,
         int? semesterId,
         int? yearEnd,
         int? semesterEndId,
         string? note,
         bool? fixedStatus,
         bool? outside,
         bool? doublePunishment)
        {
            Id = id;
            PunishmentState = punishmentState;
            SetPunishment(punishmentId);
            SetStudent(studentId);
            SetPunishmentReason(punishmentReasonId);
            SetYear(year);
            SetClass(classId);
            SetSemester(semesterId);
            SetYearEnd(yearEnd);
            SetSemesterEnd(semesterEndId);
            SetNote(note);
            SetFixed(fixedStatus);
            SetOutside(outside);
            SetDoublePunishment(doublePunishment);

            StdPunishmentStages = new Collection<StdPunishmentStage>();
        }


        public StdPunishment(
            PunishmentState? punishmentState,
            int? punishmentId,
            Guid? studentId,
            int? punishmentReasonId,
            int? year,
            int? classId,
            int? semesterId,
            int? yearEnd,
            int? semesterEndId,
            string? note,
            bool? fixedStatus,
            bool? outside,
            bool? doublePunishment)
        {
            Id = Guid.NewGuid();
            PunishmentState = punishmentState;
            SetPunishment(punishmentId);
            SetStudent(studentId);
            SetPunishmentReason(punishmentReasonId);
            SetYear(year);
            SetClass(classId);
            SetSemester(semesterId);
            SetYearEnd(yearEnd);
            SetSemesterEnd(semesterEndId);
            SetNote(note);
            SetFixed(fixedStatus);
            SetOutside(outside);
            SetDoublePunishment(doublePunishment);

            StdPunishmentStages = new Collection<StdPunishmentStage>();
        }

        public void UpdatePunishment(
           PunishmentState? punishmentState,
           int? punishmentId,
           Guid? studentId,
           int? punishmentReasonId,
           int? year,
           int? classId,
           int? semesterId,
           int? yearEnd,
           int? semesterEndId,
           string? note,
           bool? fixedStatus,
           bool? outside,
           bool? doublePunishment)
        {
            PunishmentState = punishmentState;
            SetPunishment(punishmentId);
            SetStudent(studentId);
            SetPunishmentReason(punishmentReasonId);
            SetYear(year);
            SetClass(classId);
            SetSemester(semesterId);
            SetYearEnd(yearEnd);
            SetSemesterEnd(semesterEndId);
            SetNote(note);
            SetFixed(fixedStatus);
            SetOutside(outside);
            SetDoublePunishment(doublePunishment);

            StdPunishmentStages = new Collection<StdPunishmentStage>();
        }

        private void SetPunishment(int? punishmentId)
        {
            if (punishmentId == null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.DegreeNotExists);

            PunishmentId = punishmentId;
        }

        private void SetStudent(Guid? studentId)
        {
            if (studentId == null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.DeprivationNameAlreadyExists);

            StudentId = studentId;
        }

        private void SetPunishmentReason(int? punishmentReasonId)
        {
            if (punishmentReasonId == null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.DeprivationNameAlreadyExists);

            PunishmentReasonId = punishmentReasonId;
        }

        private void SetYear(int? year)
        {
            if (year == null || year <= 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.DegreeNameArAlreadyExists);

            Year = year;
        }

        private void SetClass(int? classId)
        {
            if (classId == null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.DeprivationNameAlreadyExists);

            ClassId = classId;
        }

        private void SetSemester(int? semesterId)
        {
            if (semesterId == null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.AdmissionKindNameArAlreadyExists);
            SemesterId = semesterId;
        }



        private void SetYearEnd(int? yearEnd)
        {
            if (yearEnd == null || yearEnd <= 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.AdmissionKindNameArAlreadyExists);

            YearEnd = yearEnd;
        }

        private void SetSemesterEnd(int? semesterEndId)
        {
            if (semesterEndId == null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.AbsenceOrderNotExists);

            SemesterEndId = semesterEndId;
        }

        private void SetNote(string? note)
        {
            Note = note;
        }

        private void SetFixed(bool? fixed1)
        {
            Fixed = fixed1;
        }

        private void SetOutside(bool? outside)
        {
            Outside = outside;
        }
        private void SetDoublePunishment(bool? doublePunishment)
        {
            DoublePunishment = doublePunishment;
        }


        public StdPunishment AddPunishmentStage(int punishmentStageId, Guid stdPunishmentId, int punishmentId, string? no, DateTime? date, string? note)
        {
            if (StdPunishmentStages == null)
                StdPunishmentStages = new Collection<StdPunishmentStage>();

            if (StdPunishmentStages.Any(x => x.PunishmentStageId == punishmentStageId))
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.AbsenceOrderNameAlreadyExists);

            StdPunishmentStages.Add(new StdPunishmentStage(punishmentStageId, stdPunishmentId, punishmentId, no, date, note));
            return this;
        }



        public StdPunishment UpdatePunishmentStage(Guid stdPunishmentStage, int punishmentStageId, Guid stdPunishmentId, int punishmentId, string? no, DateTime? date, string? note)
        {
            var StdPunishmentStage = StdPunishmentStages?.FirstOrDefault(x => x.StdPunishmentId == stdPunishmentStage);

            if (StdPunishmentStage == null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.PunishmentStageNotExists);

            StdPunishmentStage.Update(punishmentStageId, stdPunishmentId, punishmentId, no, date, note);
            return this;
        }

        public StdPunishment ClearPunishmentStage()
        {
            if (StdPunishmentStages != null)
            {
                StdPunishmentStages.Clear();
            }


            return this;
        }



        public StdPunishment RemovePunishmentStage(Guid stdPunishmentStageId)
        {
            var punishmentStage = StdPunishmentStages?.FirstOrDefault(x => x.Id == stdPunishmentStageId);

            if (punishmentStage == null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.PunishmentStageNotExists);

            StdPunishmentStages.Remove(punishmentStage);
            return this;
        }

        public StdPunishmentStage GetPunishmentStage(Guid stdPunishmentStageId)
        {
            var punishmentStage = StdPunishmentStages?.FirstOrDefault(x => x.Id == stdPunishmentStageId);

            if (punishmentStage == null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.PunishmentStageNotExists);

            return punishmentStage;
        }

        public override string ToString()
        {
            return $"[StdPunishment: Id={Id}, StudentId={StudentId}, PunishmentId={PunishmentId}, Year={Year}, Note={Note}, Fixed={Fixed}, Outside={Outside}, DoublePunishment={DoublePunishment}]";
        }
    }

}
