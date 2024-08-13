using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Domain.Events;
using Univ.Hi_Student_Affairs.Dtos.DomainPunishment;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp.EventBus;



namespace Univ.Hi_Student_Affairs.Domain.Student
{
    public class StudentManager : DomainService,ITransientDependency
    {

        private readonly IRepository<Student, Guid> _Repository;
        private readonly IEventBus _eventBus;

        public StudentManager(
            IEventBus eventBus,
            IRepository<Student, Guid> Repository)
        {
            this._eventBus = eventBus;
            _Repository = Repository;
        }

        public async Task AddStdPunshiment(
            Guid studentId,
             PunishmentState? punishmentState, int? punishmentId, int? punishmentReasonId, int? year, int? classId, int? semesterId, int? yearEnd, int? semesterEndId, string? note, bool? fixedStatus, bool? outside, bool? doublePunishment, List<StdPunishmentStageDto>? stdPunishmentStageDtos)
        {
            var student = await _Repository.GetAsync(studentId);
            // Trigger the domain event using the injected IEventBus
            var NewStdPunshimentEvent = new AddNewStdPunshimentEvent(student.Id,
             punishmentState, punishmentId, punishmentReasonId, year, classId, semesterId, yearEnd, semesterEndId, note,fixedStatus, outside, doublePunishment, stdPunishmentStageDtos);
            await _eventBus.PublishAsync(NewStdPunshimentEvent);
            await _Repository.UpdateAsync(student);
        }

        public async Task UpdateStdPunshiment(
           Guid studentId, Guid stdPunshimentId,

            PunishmentState? punishmentState, int? punishmentId, int? punishmentReasonId, int? year, int? classId, int? semesterId, int? yearEnd, int? semesterEndId, string? note, bool? fixedStatus, bool? outside, bool? doublePunishment, List<StdPunishmentStageDto>? stdPunishmentStageDtos)
        {
            var student = await _Repository.GetAsync(studentId);

            // Trigger the domain event using the injected IEventBus
            var UpdateStdPunshimentEvent = new UpdateStdPunshimentEvent(
                student.Id, stdPunshimentId,
             punishmentState, punishmentId, punishmentReasonId, year, classId, semesterId, yearEnd, semesterEndId, note, fixedStatus, outside, doublePunishment, stdPunishmentStageDtos);
            await _eventBus.PublishAsync(UpdateStdPunshimentEvent);
            await _Repository.UpdateAsync(student);
        }


        public async Task DeleteStdPunshiment(
          Guid studentId, Guid stdPunshimentId)
        {
            var student = await _Repository.GetAsync(studentId);

            // Trigger the domain event using the injected IEventBus
            var DeleteStdPunshimentEvent = new DeleteStdPunshimentEvent(
                studentId, stdPunshimentId);


            await _eventBus.PublishAsync(DeleteStdPunshimentEvent);
            await _Repository.UpdateAsync(student);
        }



        public async Task<Student> CreateAsync(
            Student input

         )
        {





            return input;
        }

        public async Task<Student> UpdateAsync(
            [NotNull] Guid id,
            [NotNull] Student input
            )
        {
            //Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));
            //Check.NotNullOrWhiteSpace(input.NameEn, nameof(input.NameEn));


            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new Exception();
            }






            return Old;
        }

    }
}