using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Dtos.DomainPunishment;
using Volo.Abp.Domain.Entities.Events;


namespace Univ.Hi_Student_Affairs.Domain.Events
{   
    public class AddNewStdPunshimentEvent 
    {
        public AddNewStdPunshimentEvent(Guid studentId, PunishmentState? punishmentState, int? punishmentId, int? punishmentReasonId, int? year, int? classId, int? semesterId, int? yearEnd, int? semesterEndId, string? note, bool? fixedStatus, bool? outside, bool? doublePunishment, List<StdPunishmentStageDto>? stdPunishmentStageDtos)
        {
            StudentId = studentId;
            this.punishmentState = punishmentState;
            this.punishmentId = punishmentId;
            this.punishmentReasonId = punishmentReasonId;
            this.year = year;
            this.classId = classId;
            this.semesterId = semesterId;
            this.yearEnd = yearEnd;
            this.semesterEndId = semesterEndId;
            this.note = note;
            this.fixedStatus = fixedStatus;
            this.outside = outside;
            this.doublePunishment = doublePunishment;
            StdPunishmentStageDtos = stdPunishmentStageDtos;
        }

        public Guid StudentId { get; set; }
        public PunishmentState? punishmentState { get; set; }
        public int? punishmentId { get; set; }      
        public int? punishmentReasonId { get; set; }
        public int? year { get; set; }
        public int? classId { get; set; }
        public int? semesterId { get; set; }
        public int? yearEnd { get; set; }
        public int? semesterEndId { get; set; }
        public string? note { get; set; }
        public bool? fixedStatus { get; set; }
        public bool? outside { get; set; }
        public bool? doublePunishment { get; set; }

        public List<StdPunishmentStageDto>? StdPunishmentStageDtos { get; set; }

       
    }

    public class UpdateStdPunshimentEvent : AddNewStdPunshimentEvent
    {
        public Guid Id { get; set; }
        public UpdateStdPunshimentEvent(Guid studentId, Guid id, PunishmentState? punishmentState, int? punishmentId, int? punishmentReasonId, int? year, int? classId, int? semesterId, int? yearEnd, int? semesterEndId, string? note, bool? fixedStatus, bool? outside, bool? doublePunishment, List<StdPunishmentStageDto>? stdPunishmentStageDtos)
            :base(studentId, punishmentState, punishmentId, punishmentReasonId, year, classId, semesterId, yearEnd, semesterEndId, note, fixedStatus, outside, doublePunishment, stdPunishmentStageDtos)
        {
            Id = Id;
        }


    }

    public class DeleteStdPunshimentEvent
    {
        public DeleteStdPunshimentEvent(Guid studentId, Guid id)
        {
            StudentId = studentId;
            Id = id;
        }

        public Guid StudentId { get; set; }
        public Guid Id { get; set; }

    }

}
