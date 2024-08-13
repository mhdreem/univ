using Volo.Abp.Application.Services;
namespace Univ.Hi_Student_Affairs.Dtos.Degree
{
    public interface IDegreeService : ICrudAppService<DegreeDto, int, DegreePagedAndSortedResultRequestDto, CreateDegreeDto, UpdateDegreeDto>
    {

    }
}
