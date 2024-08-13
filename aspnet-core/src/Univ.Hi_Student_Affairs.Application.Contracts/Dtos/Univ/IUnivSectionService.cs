using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.Univ
{
    public interface IUnivSectionService : ICrudAppService<UnivSectionDto, int, UnivSectionPagedAndSortedResultRequestDto, CreateUnivSectionDto, UpdateUnivSectionDto>
    {

    }
}