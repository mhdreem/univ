using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.StdAbsence
{

    public interface IStdAbsenceService : ICrudAppService<StdAbsenceDto, int, PagedAndSortedResultRequestDto, CreateStdAbsenceDto, UpdateStdAbsenceDto>
    {

    }


}