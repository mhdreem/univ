using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.AbsenceStage
{

    public interface IAbsenceStageService : ICrudAppService<AbsenceStageDto, int, AbsenceStagePagedAndSortedResultRequestDto, CreateAbsenceStageDto, UpdateAbsenceStageDto>
    {

    }

}
