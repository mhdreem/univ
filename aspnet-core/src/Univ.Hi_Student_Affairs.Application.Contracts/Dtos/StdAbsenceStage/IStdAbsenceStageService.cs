using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.StdAbsenceStage
{

    public interface IStdAbsenceStageService : ICrudAppService<StdAbsenceStageDto, int, PagedAndSortedResultRequestDto, CreateStdAbsenceStageDto, UpdateStdAbsenceStageDto>
    {

    }


}