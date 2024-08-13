using System;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Dtos.Respond;

namespace Univ.Hi_Student_Affairs.Dtos.DomainPunishment
{


    public interface IStdPunishmentAppService
    {
        Task<RespondDto> CreateCustomAsync(CreateStdPunishmentDto input);
        Task<RespondDto> UpdateCustomAsync(UpdateStdPunishmentDto input);
        Task<RespondDto> DeleteCustomAsync(Guid id);
        Task<RespondDto> AddStdPunishmentStageAsync(StdPunishmentStageDto input);
        Task<RespondDto> UpdateStdPunishmentStageAsync(UpdateStdPunishmentStageDto input);
        Task<RespondDto> RemovePunishmentStageAsync(Guid stdPunishmentId, Guid stdPunishmentStageId);
        Task<RespondDto> GetPunishmentStageAsync(Guid stdPunishmentId, Guid stdPunishmentStageId);
    }


}
