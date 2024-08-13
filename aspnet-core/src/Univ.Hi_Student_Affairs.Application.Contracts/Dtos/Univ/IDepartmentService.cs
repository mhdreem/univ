using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.Univ
{
    public interface IDepartmentService : ICrudAppService<DepartmentDto, int, DepartmentPagedAndSortedResultRequestDto, CreateDepartmentDto, UpdateDepartmentDto>
    {

    }
}