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
    public class UpdateStdPunishmentHandler : ILocalEventHandler<UpdateStdPunshimentEvent>, ITransientDependency
    {
        private readonly StdPunishmentManager _stdPunishmentManager;

        public UpdateStdPunishmentHandler(StdPunishmentManager stdPunishmentManager)
        {
            _stdPunishmentManager = stdPunishmentManager;
        }

        public async Task HandleEventAsync(UpdateStdPunshimentEvent eventData)
        {
           
            var stPunshiment = await _stdPunishmentManager.UpdateAsync(eventData.Id,

                eventData.punishmentState,
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
