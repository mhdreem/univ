using System;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain.Student;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Domain.StdPunishment
{
    public class StdPunishmentStage : Entity<Guid>
    {
        [ForeignKey("PunishmentStageId")]
        public int PunishmentStageId { get; private set; }
        public virtual PunishmentStage? PunishmentStage { get; private set; }



        [ForeignKey("StdPunishmentId")]
        public Guid? StdPunishmentId { get; private set; }



        [ForeignKey("PunishmentId")]
        public int PunishmentId { get; private set; }
        public virtual Punishment? Punishment { get; private set; }


        // العقوبة من المرحلة
        public string? No { get; private set; }

        // تاريخ قرار العقوبة
        [Column(TypeName = "DATE")]
        public DateTime? Date { get; private set; }

        public string? Note { get; private set; }


        public StdPunishmentStage(
           Guid id,
           Guid? stdPunishmentId,
           int punishmentStageId,
           int punishmentId,
           string? no,
           DateTime? date,
           string? note)
        {
            Id = id;
            SetPunishmentStage(punishmentStageId);
            SetPunishmentID(punishmentId);
            SetStdPunishment(stdPunishmentId);

            No = no;
            Date = date;
            Note = note;
        }

        public StdPunishmentStage(
            int punishmentStageId,
            Guid? stdPunishmentId,
            int punishmentId,
            string? no,
            DateTime? date,
            string? note)
        {
            Id = Guid.NewGuid();
            SetPunishmentStage(punishmentStageId);
            SetPunishmentID(punishmentId);
            SetStdPunishment(stdPunishmentId);

            No = no;
            Date = date;
            Note = note;
        }

        public void Update(
            int punishmentStageId,
            Guid? stdPunishmentId,
            int punishmentId,
            string? no,
            DateTime? date,
            string? note)
        {
            SetPunishmentStage(punishmentStageId);
            SetStdPunishment(stdPunishmentId);
            SetPunishmentID(punishmentId);
            No = no;
            Date = date;
            Note = note;
        }

        private void SetPunishmentStage(int punishmentStageId)
        {
            if (punishmentStageId == null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.AbsenceStageNameAlreadyExists);

            PunishmentStageId = punishmentStageId;
        }

        private void SetStdPunishment(Guid? stdPunishmentId)
        {
            if (stdPunishmentId == null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.AbsenceStageNotExists);

            StdPunishmentId = stdPunishmentId;
        }

        private void SetPunishmentID(int punishmentId)
        {
            if (punishmentId == null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.DegreeNotExists);

            PunishmentId = punishmentId;
        }

        public override string ToString()
        {
            return $"[StdPunishmentStage: Id={Id}, PunishmentStageId={PunishmentStageId}, StdPunishmentId={StdPunishmentId}, PunishmentId={PunishmentId}, No={No}, Date={Date}, Note={Note}]";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var other = (StdPunishmentStage)obj;
            return Id == other.Id &&
                   PunishmentStageId == other.PunishmentStageId &&
                   StdPunishmentId == other.StdPunishmentId &&
                   PunishmentId == other.PunishmentId &&
                   No == other.No &&
                   Date == other.Date &&
                   Note == other.Note;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, PunishmentStageId, StdPunishmentId, PunishmentId, No, Date, Note);
        }
    }
}
