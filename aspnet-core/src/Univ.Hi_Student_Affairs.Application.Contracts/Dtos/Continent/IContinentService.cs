using Univ.Hi_Student_Affairs.Dtos;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.Continent
{
    public interface IContinentService : ICrudAppService<ContinentDto, int, ContinentPagedAndSortedResultRequestDto, CreateContinentDto, UpdateContinentDto>
    {

    }
}
