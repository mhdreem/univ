using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Domain.Events;
using Univ.Hi_Student_Affairs.Domain.Student;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus;

namespace Univ.Hi_Student_Affairs.Domain.StdPunishment.EventHandler
{
    public class AddNewStdPunishmentHandler : ILocalEventHandler<AddNewStdPunshimentEvent>, ITransientDependency
    {
        private readonly StdPunishmentManager _stdPunishmentManager;

        public AddNewStdPunishmentHandler(StdPunishmentManager stdPunishmentManager)
        {
            _stdPunishmentManager = stdPunishmentManager;
        }

        public async Task HandleEventAsync(AddNewStdPunshimentEvent eventData)
        {
           
            var stPunshiment = await _stdPunishmentManager.CreateAsync(eventData.punishmentState,
            eventData.punishmentId,
            eventData.StudentId,
            eventData.punishmentReasonId,
            eventData.year,
            eventData.classId,
            eventData.semesterId,
            eventData.yearEnd,
            eventData.semesterEndId,
            eventData.note,
            eventData.fixedStatus,
            eventData.outside,
            eventData.doublePunishment,
            eventData.StdPunishmentStageDtos);

        }
    }

}
