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
    public class DeleteStdPunishmentHandler : ILocalEventHandler<DeleteStdPunshimentEvent>, ITransientDependency
    {
        private readonly StdPunishmentManager _stdPunishmentManager;

        public DeleteStdPunishmentHandler(StdPunishmentManager stdPunishmentManager)
        {
            _stdPunishmentManager = stdPunishmentManager;
        }

        public async Task HandleEventAsync(DeleteStdPunshimentEvent eventData)
        {
            await _stdPunishmentManager.DeleteAsync(eventData.StudentId,eventData.Id);
        }
    }

}
