using Univ.Hi_Student_Affairs.Domain.StdPunishment;
using Univ.Hi_Student_Affairs.Dtos.DomainPunishment;
using Univ.Hi_Student_Affairs.Service.BaseService;
using Volo.Abp.Domain.Repositories;

namespace Univ.Hi_Student_Affairs.Service.DomainPunishment
{
    public class DeprivationAppService : CustomCrudAppService<Deprivation, DeprivationDto, int, CreateDeprivationDto, UpdateDeprivationDto>, IDeprivationAppService
    {
        public DeprivationAppService(
            IRepository<Deprivation, int> repository)
            : base(repository)
        {

        }

    }

}
