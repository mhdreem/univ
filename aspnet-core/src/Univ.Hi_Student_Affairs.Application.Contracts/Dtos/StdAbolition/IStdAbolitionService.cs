using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.StdAbolition
{
    public interface IStdAbolitionService : ICrudAppService<StdAbolitionDto, int, PagedAndSortedResultRequestDto, CreateStdAbolitionDto, UpdateStdAbolitionDto>
    {

    }


}