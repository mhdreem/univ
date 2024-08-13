using Univ.Hi_Student_Affairs.Domain.StdPunishment;
using Univ.Hi_Student_Affairs.Dtos.DomainPunishment;
using Univ.Hi_Student_Affairs.Service.BaseService;
using Volo.Abp.Domain.Repositories;

namespace Univ.Hi_Student_Affairs.Service.DomainPunishment
{

    public class PunishmentAppService : CustomCrudAppService<Punishment, PunishmentDto, int, CreatePunishmentDto, UpdatePunishmentDto>, IPunishmentAppService
    {
        public PunishmentAppService(
            IRepository<Punishment, int> repository)
            : base(repository)
        {

        }

    }

}
