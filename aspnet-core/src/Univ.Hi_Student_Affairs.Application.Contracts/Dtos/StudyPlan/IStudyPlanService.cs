using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.StudyPlan
{
    public interface IStudyPlanService : ICrudAppService<StudyPlanDto, int, StudyPlanPagedAndSortedResultRequestDto, CreateStudyPlanDto, UpdateStudyPlanDto>
    {

    }
}
