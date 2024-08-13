using Univ.Hi_Student_Affairs.Domain.StdPunishment;
using Univ.Hi_Student_Affairs.Dtos.DomainPunishment;
using Univ.Hi_Student_Affairs.Service.BaseService;
using Volo.Abp.Domain.Repositories;

namespace Univ.Hi_Student_Affairs.Service.DomainPunishment
{



    public class PunishmentReasonAppService : CustomCrudAppService<PunishmentReason, PunishmentReasonDto, int, CreatePunishmentReasonDto, UpdatePunishmentReasonDto>, IPunishmentReasonAppService
    {
        public PunishmentReasonAppService(
            IRepository<PunishmentReason, int> repository)
            : base(repository)
        {

        }

    }

}
