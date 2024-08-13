using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.Class
{
    public interface IClassService : ICrudAppService<ClassDto, int, ClassPagedAndSortedResultRequestDto, CreateClassDto, UpdateClassDto>
    {
    }
}

