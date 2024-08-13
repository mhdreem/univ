using Univ.Hi_Student_Affairs.Domain.StdPunishment;
using Univ.Hi_Student_Affairs.Dtos.DomainPunishment;
using Univ.Hi_Student_Affairs.Service.BaseService;
using Volo.Abp.Domain.Repositories;

namespace Univ.Hi_Student_Affairs.Service.DomainPunishment
{


    public class PunishmentStageAppService : CustomCrudAppService<PunishmentStage, PunishmentStageDto, int, CreatePunishmentStageDto, UpdatePunishmentStageDto>, IPunishmentStageAppService
    {
        public PunishmentStageAppService(
            IRepository<PunishmentStage, int> repository)
            : base(repository)
        {

        }

    }

}
