using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.Grade
{
    public interface IGradeService : ICrudAppService<GradeDto, int, GradePagedAndSortedResultRequestDto, CreateGradeDto, UpdateGradeDto>
    {
    }
}
